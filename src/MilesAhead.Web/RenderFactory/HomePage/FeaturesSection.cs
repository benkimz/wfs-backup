using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class FeaturesSection : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Features Area",
            Segment = "section",
            Attributes = AsJson(new { @class = "features-section margin-top-100" }),
            Children = [
                    new WireFrame
                    {
                        Name = "img",
                        Segment = "img",
                        Attributes = AsJson(new { src = "assets/img/shapes/graduation.png", @class = "shape", alt = "graduation cap" })
                    },
                    new WireFrame
                    {
                        Name = "container",
                        Segment = "div",
                        Attributes = AsJson(new { @class = "container custom-container-01" }),
                        Children = [
                            new WireFrame
                            {
                                Name = "row",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "row" }),
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "col-lg-4 col-md-6",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "col-lg-4 col-md-6" }),
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "icon-box-item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "icon-box-item" }),
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "icon",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "icon" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/icon/idea.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "content" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h4",
                                                                Attributes = AsJson(new { @class = "title" }),
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
                                                        Attributes = AsJson(new { @class = "btn-wrap" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = AsJson(new { href = "#0", @class = "more-btn" }),
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
                                        Attributes = AsJson(new { @class = "col-lg-4 col-md-6" }),
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "icon-box-item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "icon-box-item" }),
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "icon",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "icon" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/icon/coversation.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "content" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h4",
                                                                Attributes = AsJson(new { @class = "title" }),
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
                                                        Attributes = AsJson(new { @class = "btn-wrap" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = AsJson(new { href = "#0", @class = "more-btn" }),
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
                                        Attributes = AsJson(new { @class = "col-lg-4 col-md-6" }),
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "icon-box-item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "icon-box-item" }),
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "icon",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "icon" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/icon/emergency.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "content" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h4",
                                                                Attributes = AsJson(new { @class = "title" }),
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
                                                        Attributes = AsJson(new { @class = "btn-wrap" }),
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = AsJson(new { href = "#0", @class = "more-btn" }),
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
