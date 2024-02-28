using MilesAhead.Components;

namespace MilesAhead.Web;

public class BannerSection
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Banner Section",
            Segment = "section",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "banner-area home-01" }],
            Children = [
                new WireFrame{
                    Name = "Container",
                    Segment = "div",
                    Attributes = [new WireFrameAttribute { Name = "class", Value = "container custom-container-01" }],
                    Children = [
                        new WireFrame{
                            Name = "Banner Wrapper",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "banner-wrapper" }],
                            Children = [
                                new WireFrame{
                                    Name = "Row",
                                    Segment = "div",
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "row" }],
                                    Children = [
                                        new WireFrame{
                                            Name = "Column 1",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "col-xl-7 col-lg-10" }],
                                            Children = [
                                                new WireFrame{
                                                    Name = "Banner Inner",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "banner-inner" }],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Subtitle",
                                                            Segment = "p",
                                                            Content = "SPECIAL OFFER FIRST CUSTOMER"
                                                        },
                                                        new WireFrame{
                                                            Name = "Title",
                                                            Segment = "h1",
                                                            Content = "Your <span>success</span> journey start with us!"
                                                        },
                                                        new WireFrame{
                                                            Name = "Paragraph",
                                                            Segment = "p",
                                                            Content = "Eduplan Education Can Fulfil Your International Education Dream <br> As Per Your Best Fit with world top universities and collages."
                                                        },
                                                        new WireFrame{
                                                            Name = "Header Button",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "header-btn" }],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Button Wrap 1",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }],
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Apply Online",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }, new WireFrameAttribute { Name = "class", Value = "btn-common flat-btn btn-active" }],
                                                                            Content = "apply online"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "Button Wrap 2",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap margin-left-20" }],
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Discover",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "contact.html" }, new WireFrameAttribute { Name = "class", Value = "btn-common fill-btn" }],
                                                                            Content = "Discover",
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                }
                                            ]
                                        },
                                        new WireFrame{
                                            Name = "Column 2",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "col-xl-5" }],
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "thumbnail" }],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Ellipse 1",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/Ellipse-01.png" }, new WireFrameAttribute { Name = "class", Value = "element-01" }, new WireFrameAttribute { Name = "alt", Value = "Ellipse" }]
                                                        },
                                                        new WireFrame{
                                                            Name = "Ellipse 2",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/Ellipse-02.png" }, new WireFrameAttribute { Name = "class", Value = "element-02" }, new WireFrameAttribute { Name = "alt", Value = "Ellipse" }]
                                                        },
                                                        new WireFrame{
                                                            Name = "Vector 15",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/Vector-15.png" }, new WireFrameAttribute { Name = "class", Value = "element-03" }, new WireFrameAttribute { Name = "alt", Value = "vector" }]
                                                        },
                                                        new WireFrame{
                                                            Name = "Plane",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/header/plane.png" }, new WireFrameAttribute { Name = "class", Value = "element-04" }, new WireFrameAttribute { Name = "alt", Value = "plane" }]
                                                        },
                                                        new WireFrame{
                                                            Name = "Location",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/location.png" }, new WireFrameAttribute { Name = "class", Value = "element-05" }, new WireFrameAttribute { Name = "alt", Value = "location" }]
                                                        },
                                                        new WireFrame{
                                                            Name = "Banner Image",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/header/header-img.png" }, new WireFrameAttribute { Name = "class", Value = "banner-img" }, new WireFrameAttribute { Name = "alt", Value = "Student" }]
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