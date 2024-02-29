using MilesAhead.Components;

namespace MilesAhead.Web;

public class BannerSection : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Banner Section",
            Segment = "section",
            Attributes = AsJson(new { @class = "banner-area home-01" }),
            Children = [
                new WireFrame{
                    Name = "Container",
                    Segment = "div",
                    Attributes = AsJson(new { @class = "container custom-container-01" }),
                    Children = [
                        new WireFrame{
                            Name = "Banner Wrapper",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "banner-wrapper" }),
                            Children = [
                                new WireFrame{
                                    Name = "Row",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "row" }),
                                    Children = [
                                        new WireFrame{
                                            Name = "Column 1",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "col-xl-7 col-lg-10" }),
                                            Children = [
                                                new WireFrame{
                                                    Name = "Banner Inner",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "banner-inner" }),
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
                                                            Attributes = AsJson(new { @class = "header-btn" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Button Wrap 1",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "btn-wrap" }),
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Apply Online",
                                                                            Segment = "a",
                                                                            Attributes = AsJson(new { href = "#0", @class = "btn-common flat-btn btn-active" }),
                                                                            Content = "apply online"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "Button Wrap 2",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "btn-wrap margin-left-20" }),
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Discover",
                                                                            Segment = "a",
                                                                            Attributes = AsJson(new { href = "contact.html", @class = "btn-common fill-btn" }),
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
                                            Attributes = AsJson(new { @class = "col-xl-5" }),
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Ellipse 1",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/shapes/Ellipse-01.png", @class = "element-01", alt = "Ellipse" })
                                                        },
                                                        new WireFrame{
                                                            Name = "Ellipse 2",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/shapes/Ellipse-02.png", @class = "element-02", alt = "Ellipse" })
                                                        },
                                                        new WireFrame{
                                                            Name = "Vector 15",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/shapes/Vector-15.png", @class = "element-03", alt = "vector" })
                                                        },
                                                        new WireFrame{
                                                            Name = "Plane",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/header/plane.png", @class = "element-04", alt = "plane" })
                                                        },
                                                        new WireFrame{
                                                            Name = "Location",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/icon/location.png", @class = "element-05", alt = "location" })
                                                        },
                                                        new WireFrame{
                                                            Name = "Banner Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/header/header-img.png", @class = "banner-img", alt = "Student" })
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