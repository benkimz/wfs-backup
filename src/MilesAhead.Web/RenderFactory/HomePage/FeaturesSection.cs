using MilesAhead.Components;

namespace MilesAhead.Web;

public class FeaturesSection
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Features Area",
            Segment = "section",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "features-section margin-top-100" }],
            Children = [
                    new WireFrame
                    {
                        Name = "img",
                        Segment = "img",
                        Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/graduation.png" }, new WireFrameAttribute { Name = "class", Value = "shape" }, new WireFrameAttribute { Name = "alt", Value = "graduation cap" }]
                    },
                    new WireFrame
                    {
                        Name = "container",
                        Segment = "div",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "container custom-container-01" }],
                        Children = [
                            new WireFrame
                            {
                                Name = "row",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "row" }],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "col-lg-4 col-md-6",
                                        Segment = "div",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-4 col-md-6" }],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "icon-box-item",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "icon-box-item" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "icon",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "icon" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/idea.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "content" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h4",
                                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                Content = "One Stop Study Solution"
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Content = "Get a full view so you know where to save. Track spending, deta keep tab subscription lorem ipsum text"
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "btn-wrap",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }, new WireFrameAttribute { Name = "class", Value = "more-btn" }],
                                                                Content = "Learn More"
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame
                                    {
                                        Name = "col-lg-4 col-md-6",
                                        Segment = "div",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-4 col-md-6" }],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "icon-box-item",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "icon-box-item" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "icon",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "icon" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/coversation.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "content" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h4",
                                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                Content = "One To One Discussion"
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Content = "Get a full view so you know where to save. Track spending, deta keep tab subscription lorem ipsum text"
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "btn-wrap",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }, new WireFrameAttribute { Name = "class", Value = "more-btn" }],
                                                                Content = "Learn More"
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame
                                    {
                                        Name = "col-lg-4 col-md-6",
                                        Segment = "div",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-4 col-md-6" }],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "icon-box-item",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "icon-box-item" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "icon",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "icon" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/emergency.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "content" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h4",
                                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                Content = "End To End Support"
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Content = "Get a full view so you know where to save. Track spending, deta keep tab subscription lorem ipsum text"
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "btn-wrap",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }, new WireFrameAttribute { Name = "class", Value = "more-btn" }],
                                                                Content = "Learn More"
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            }
                        ]
                    }
                ]
        };
    }
}
