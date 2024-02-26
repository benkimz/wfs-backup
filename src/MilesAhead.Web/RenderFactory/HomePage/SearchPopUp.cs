using MilesAhead.Components;

namespace MilesAhead.Web;

public class SearchPopUp
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Search Popup",
            Segment = "div",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "search-popup" }, new WireFrameAttribute { Name = "id", Value = "search-popup" }],
            Children = [
                new WireFrame
                {
                    Name = "Search Form",
                    Segment = "form",
                    Attributes = [new WireFrameAttribute { Name = "action", Value = "index.html" }, new WireFrameAttribute { Name = "class", Value = "search-form" }],
                    Children = [
                        new WireFrame
                        {
                            Name = "Form Group",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "form-group" }],
                            Children = [
                                new WireFrame
                                {
                                    Name = "Input",
                                    Segment = "input",
                                    Attributes = [new WireFrameAttribute { Name = "type", Value = "text" }, new WireFrameAttribute { Name = "class", Value = "form-control" }, new WireFrameAttribute { Name = "placeholder", Value = "Search....." }]
                                }
                            ]
                        },
                        new WireFrame
                        {
                            Name = "Close Button",
                            Segment = "button",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "close-btn border-none" }],
                            Children = [
                                new WireFrame
                                {
                                    Name = "Icon",
                                    Segment = "i",
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "fas fa-search" }]
                                }
                            ]
                        }
                    ]
                }
            ]
        };
    }
}
