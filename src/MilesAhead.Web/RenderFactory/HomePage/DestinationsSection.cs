using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class DestinationsSection : BaseBuilder
{
    public WireFrame Build()
    {
        WireFrame DestinationsFrame = new WireFrame
        {
            Name = "Destinations Section",
            Segment = "section",
            Attributes = AsJson(new { @class = "margin-top-110 section-bottom-space" })
        };

        DestinationsFrame.Children.AddRange([
            new WireFrame
            {
                Name = "Destination Section",
                Segment = "div",
                Attributes = AsJson(new {@class = "destination-section"}),
                Children = [
                    new WireFrame
                    {
                        Name = "Mountant",
                        Segment = "img",
                        Attributes = AsJson(new { src = "assets/img/shapes/mountant.png", @class = "shape-01 wow animate__animated animate__delay-1s animate__fadeInUp", alt = "mountant" })
                    },
                    new WireFrame
                    {
                        Name = "Plane Wrap",
                        Segment = "div",
                        Attributes = AsJson(new {@class = "plane-wrap"}),
                        Children = [
                            new WireFrame
                            {
                                Name = "Plane",
                                Segment = "img",
                                Attributes = AsJson(new { src = "assets/img/shapes/plane.png", @class = "shape-02", alt = "mountant" })
                            }
                        ]
                    },
                    new WireFrame
                    {
                        Name = "Container",
                        Segment = "div",
                        Attributes = AsJson(new {@class = "container custom-container-01"}),
                        Children = [
                            new WireFrame
                            {
                                Name = "Row",
                                Segment = "div",
                                Attributes = AsJson(new {@class = "row justify-content-center"}),
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "Column",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "col-lg-6"}),
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "Theme Section Title",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "theme-section-title desktop-center text-center"}),
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "Title",
                                                        Segment = "h4",
                                                        Attributes = AsJson(new {@class = "title"}),
                                                        Content = "Top Destinations"
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "Paragraph",
                                                        Segment = "p",
                                                        Content = "We have quality partners in variety of destinations around the globe."
                                                    }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Items Wrap",
                                Segment = "div",
                                Attributes = AsJson(new {@class = "destination-items-wrap"}),
                                Children = [
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "destination-single-item"}),
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "thumbnail"}),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = AsJson(new { src = "assets/img/sections/destination/canda.png", alt = "" })
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Content = "Canada"
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "destination-single-item"}),
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "thumbnail"}),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = AsJson(new { src = "assets/img/sections/destination/usa.png", alt = "" })
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Content = "America"
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "destination-single-item"}),
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "thumbnail"}),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = AsJson(new { src = "assets/img/sections/destination/australia.png", alt = "" })
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Content = "London"
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "destination-single-item"}),
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "thumbnail"}),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = AsJson(new { src = "assets/img/sections/destination/span.png", alt = "" })
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Content = "Spain"
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "destination-single-item"}),
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "thumbnail"}),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = AsJson(new { src = "assets/img/sections/destination/franch.png", alt = "" })
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Content = "French"
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "destination-single-item"}),
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "thumbnail"}),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = AsJson(new { src = "assets/img/sections/destination/swideen.png", alt = "" })
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Content = "Sweden"
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = AsJson(new {@class = "destination-single-item"}),
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = AsJson(new {@class = "thumbnail"}),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = AsJson(new { src = "assets/img/sections/destination/italy.png", alt = "" })
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Content = "Italy"
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame
                            {
                                Name = "Button Wrap",
                                Segment = "div",
                                Attributes = AsJson(new {@class = "btn-wrap desktop-center margin-top-40 text-center"}),
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "Button",
                                        Segment = "a",
                                        Attributes = AsJson(new { href = "contact.html", @class = "btn-common fill-btn style-01" }),
                                        Content = "apply online"
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ]);

        return DestinationsFrame;
    }
}
