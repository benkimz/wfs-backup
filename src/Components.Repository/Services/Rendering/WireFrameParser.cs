using System.Text.Json;
using Microsoft.AspNetCore.Components;
using WireFrames.Core;

namespace wireframes.render.services;

public class WireframeParser
{
    public static RenderFragment RenderWireFrame<T>(T wireFrame) where T : WireFrame
    {
        return builder =>
        {
            if (wireFrame.IsVisible != true) return;
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
}
