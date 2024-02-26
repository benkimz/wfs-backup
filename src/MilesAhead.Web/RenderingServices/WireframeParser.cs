using Microsoft.AspNetCore.Components;
using MilesAhead.Components;

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
                foreach (var attribute in wireFrame.Attributes)
                {
                    builder.AddAttribute(1, attribute.Name, attribute.Value);
                }
            }
            if (wireFrame.Data != null && wireFrame.Data.FallbackRenderData != null)
            {
                foreach (var data in wireFrame.Data.FallbackRenderData)
                {
                    builder.AddContent(2, (MarkupString)(data.Value ?? string.Empty));
                }
            }
            foreach (var child in wireFrame.Children)
            {
                builder.AddContent(3, RenderWireFrame(child));
            }
            builder.CloseComponent();
        };
    }
}
