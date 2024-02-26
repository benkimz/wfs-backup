using MilesAhead.Components;

namespace MilesAhead.Web;

public class BodyOverLay
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "body-overlay",
            Segment = "div",
            Attributes = [new WireFrameAttribute{
            Name = "class",
            Value = "body-overlay"
        }, new WireFrameAttribute{
            Name = "id",
            Value = "body-overlay"
        }]
        };
    }
}
