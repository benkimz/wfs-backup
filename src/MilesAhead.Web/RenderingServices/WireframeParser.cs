using System.Text.Json;
using Microsoft.AspNetCore.Components;
using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class WireframeParser
{
    public static RenderFragment RenderWireFrame<T>(T wireFrame) where T : WireFrame
    {
        return builder =>
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
        };
    }

    public static JsonDocument ObjectFromJson(string json)
    {
        return JsonDocument.Parse(json);
    }

    public static string JsonFromObject<T>(T obj)
    {
        return JsonSerializer.Serialize(obj);
    }
}
