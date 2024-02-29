using MilesAhead.Components;

namespace MilesAhead.Web;

public class PagePreloader : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Preloader",
            Segment = "div",
            Attributes = AsJson(new { @class = "preloader", id = "preloader" }),
            Children = [
               new WireFrame
                {
                    Name = "Preloader Inner",
                    Segment = "div",
                    Attributes = AsJson(new { @class = "preloader-inner" }),
                    Children = [
                        new WireFrame
                        {
                            Name = "Loader",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "loader" })
                        }
                    ]
                }
           ]
        };

    }
}
