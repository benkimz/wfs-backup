using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class BodyOverLay : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "body-overlay",
            Segment = "div",
            Attributes = AsJson(new { @class = "body-overlay", id = "body-overlay" })
        };
    }
}
