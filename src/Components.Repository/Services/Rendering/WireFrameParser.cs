using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WireFrames.Core;

namespace wireframes.render.services;

public class WireframeParser
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IConfiguration _configuration;
    public static WireframeParser? instance { get; private set; }
    public WireframeParser(IServiceProvider serviceProvider, IConfiguration configuration)
    {
        _serviceProvider = serviceProvider;
        _configuration = configuration;
        if (instance == null) instance = this;
    }

    public static RenderFragment RenderWireFrame<T>(T wireFrame) where T : WireFrame
    {
        return builder =>
        {
            if (wireFrame.IsVisible != true) return;

            // ~ dev mode
            if (instance is not null)
            {
                if (instance._configuration["wfs-mode"] == "dev")
                {
                    builder.OpenElement(0, "a");
                    if (wireFrame is PrimeRoot)
                        builder.AddAttribute(1, "href", $"http://localhost:5123/prs/{wireFrame.Id}");
                    else
                        builder.AddAttribute(1, "href", $"http://localhost:5123/wfs/{wireFrame.Id}");
                    builder.AddAttribute(2, "class", "wfs-dev-link");
                    builder.AddAttribute(3, "target", "_blank");
                    builder.CloseComponent();
                }
            } // ~ end of dev mode

            if (wireFrame.IsBlazorComponent == true)
            {
                Type? razorNodeType = ComponentType(wireFrame.Segment);
                if (razorNodeType != null)
                {
                    builder.OpenComponent(0, razorNodeType);
                    builder.AddAttribute(1, "Name", wireFrame.Name);
                    builder.AddAttribute(2, "DataSource", wireFrame.DataSource);
                    builder.AddAttribute(3, "Content", wireFrame.Content);
                    builder.AddAttribute(4, "FetchData", wireFrame.FetchData);
                    builder.AddAttribute(5, "Children", wireFrame.Children);
                    builder.AddAttribute(6, "Attributes", wireFrame.Attributes);
                    builder.CloseComponent();
                }
                else
                {
                    Alert($"Component '{wireFrame.Segment}' not found");
                }
            }
            else
            {
                builder.OpenElement(0, wireFrame.Segment);
                if (wireFrame.Attributes != null)
                {
                    var attrs = ObjectFromJson(wireFrame.Attributes);
                    foreach (JsonProperty attr in attrs.RootElement.EnumerateObject())
                    {
                        builder.AddAttribute(1, attr.Name, attr.Value);
                    }
                }
                if (wireFrame.Content != null)
                {
                    builder.AddContent(2, (MarkupString)(wireFrame.Content ?? string.Empty));
                }
                foreach (var child in wireFrame.Children)
                {
                    builder.AddContent(3, RenderWireFrame(child));
                }
                builder.CloseComponent();
            }
        };
    }

    public static JsonDocument ObjectFromJson(string json)
    {
        return JsonDocument.Parse(json);
    }
    public static T? CustomObjectFromJson<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json);
    }

    public static bool KeyExists(JsonDocument json, string key) => json.RootElement.TryGetProperty(key, out _);
    public static bool KeyExists(JsonElement json, string key) => json.TryGetProperty(key, out _);
    public static T? ValueFromJson<T>(JsonDocument json, string key)
    {
        if (json.RootElement.TryGetProperty(key, out JsonElement propertyValue))
        {
            return propertyValue.Deserialize<T>();
        }
        return default;
    }
    public static T? ValueFromJson<T>(JsonElement json, string key)
    {
        if (json.TryGetProperty(key, out JsonElement propertyValue))
        {
            return propertyValue.Deserialize<T>();
        }
        return default;
    }

    public static string JsonFromObject<T>(T obj)
    {
        return JsonSerializer.Serialize(obj);
    }

    private static Type? ComponentType(string segment) => Type.GetType($"{segment}, Components.Repository");

    // ~ console alerts & warnings
    public static void Alert(string message) => Console.WriteLine($"\n\n Warning: '{message}' << WireframeParser >> \n\n");


    // ~ critical - methods: required for a correct page retrieval

    // ~ helper method to prepare a target configuration file
    private static string ValidatePrimeRootsConfigFile()
    {
        string root = Path.Combine(Directory.GetCurrentDirectory(), "PrimeRoots"),
        path = Path.Combine(root, "config.json");

        if (!Directory.Exists(root)) Directory.CreateDirectory(root);

        if (!File.Exists(path))
        {
            File.Create(path).Close();
            File.WriteAllText(path, "{}");
        }
        return path;
    }
    // ~ helper method to capture a root id on an accessible configuration file
    public static void CapturePrimeRootId(string property, string value)
    {
        string path = ValidatePrimeRootsConfigFile();

        var data = CustomObjectFromJson<Dictionary<string, object>>(File.ReadAllText(path));
        if (data != null) data[property] = value;

        File.WriteAllText(path, JsonFromObject(data));
    }
    // ~ helper method to retrieve a root id from an accessible configuration file
    public static string? GetPrimeRootId(string property)
    {
        string path = ValidatePrimeRootsConfigFile();

        var data = CustomObjectFromJson<Dictionary<string, object>>(File.ReadAllText(path));
        if (data != null && data.ContainsKey(property)) return data[property].ToString();
        return null;
    }

    // ~ helper method to persit a root to the database and capture its id
    public async Task<PrimeRoot?> PersistRoot(PrimeRoot root, string name)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var prsRepo = scope.ServiceProvider.GetRequiredService<PrimeRootRepository>();
            if (prsRepo == null) return null;
            var result = await prsRepo.Add(root);
            if (result != null) CapturePrimeRootId(name, result.Guid.ToString());
            return result;
        }
    }

}
