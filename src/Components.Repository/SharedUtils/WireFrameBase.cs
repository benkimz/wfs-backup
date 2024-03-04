using wireframes.render.services;
using Microsoft.AspNetCore.Components;
using WireFrames.Core;
using System.Text.Json;
using System.Globalization;

namespace Components.Repository;

public class WireFrameBase : ComponentBase
{
    [Parameter]
    public string? Name { get; set; }
    [Parameter]
    public DataSource? DataSource { get; set; }
    [Parameter]
    public string? Content { get; set; }
    [Parameter]
    public string? FetchData { get; set; }
    [Parameter]
    public string? Attributes { get; set; }
    [Parameter]
    public List<WireFrame>? Children { get; set; }

    // ~ helpers: 
    protected bool IsValidString(string? value) => !string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value);
    public static string ToTitleCase(string value)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(value);
    }
    // ~ from wireframes.render.services.WireframeParser
    public static bool KeyExists(JsonDocument json, string key) => WireframeParser.KeyExists(json, key);
    public static bool KeyExists(JsonElement json, string key) => WireframeParser.KeyExists(json, key);
    public static T? ValueFromJson<T>(JsonDocument json, string key) => WireframeParser.ValueFromJson<T>(json, key);
    public static T? ValueFromJson<T>(JsonElement json, string key) => WireframeParser.ValueFromJson<T>(json, key);
    public static JsonDocument ObjectFromJson(string json) => WireframeParser.ObjectFromJson(json);
    public static T? CustomObjectFromJson<T>(string json) => WireframeParser.CustomObjectFromJson<T>(json);
    public static string JsonFromObject(object obj) => WireframeParser.JsonFromObject(obj);
}
