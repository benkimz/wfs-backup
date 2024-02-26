using MilesAhead.Components;

namespace MilesAhead.Web;

public class PagePreloader
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Preloader",
            Segment = "div",
            Attributes = [
               new WireFrameAttribute { Name = "class", Value = "preloader" },
                new WireFrameAttribute { Name = "id", Value = "preloader" }
           ],
            Children = [
               new WireFrame
                {
                    Name = "Preloader Inner",
                    Segment = "div",
                    Attributes = [new WireFrameAttribute { Name = "class", Value = "preloader-inner" }],
                    Children = [
                        new WireFrame
                        {
                            Name = "Loader",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "loader" }]
                        }
                    ]
                }
           ]
        };

    }
}
