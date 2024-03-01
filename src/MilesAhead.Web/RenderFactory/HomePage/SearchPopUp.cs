using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class SearchPopUp : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Search Popup",
            Segment = "div",
            Attributes = AsJson(new { @class = "search-popup", id = "search-popup" }),
            Children = [
                new WireFrame
                {
                    Name = "Search Form",
                    Segment = "form",
                    Attributes = AsJson(new { action = "index.html", @class = "search-form" }),
                    Children = [
                        new WireFrame
                        {
                            Name = "Form Group",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "form-group" }),
                            Children = [
                                new WireFrame
                                {
                                    Name = "Input",
                                    Segment = "input",
                                    Attributes = AsJson(new { type = "text", @class = "form-control", placeholder = "Search....." })
                                }
                            ]
                        },
                        new WireFrame
                        {
                            Name = "Close Button",
                            Segment = "button",
                            Attributes = AsJson(new { @class = "close-btn border-none" }),
                            Children = [
                                new WireFrame
                                {
                                    Name = "Icon",
                                    Segment = "i",
                                    Attributes = AsJson(new { @class = "fas fa-search" })
                                }
                            ]
                        }
                    ]
                }
            ]
        };
    }
}
