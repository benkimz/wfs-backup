using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class FeedBackSection : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Feedback-section",
            Segment = "section",
            Attributes = AsJson(new { @class = "feedback-section margin-top-110" }),
            Children = [
                new WireFrame
                {
                    Name = "container",
                    Segment = "div",
                    Attributes = AsJson(new { @class = "custom-container-01" }),
                    Children = [
                        new WireFrame
                        {
                            Name = "row",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "row justify-content-center" }),
                            Children = [
                                new WireFrame
                                {
                                    Name = "col-lg-12",
                                    Segment = "div",
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "theme-section-title",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "desktop-center text-center" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "subtitle",
                                                    Segment = "span",
                                                    Attributes = AsJson(new { @class = "subtitle" }),
                                                    Content = "FEEDBACKS"
                                                },
                                                new WireFrame
                                                {
                                                    Name = "title",
                                                    Segment = "h4",
                                                    Attributes = AsJson(new { @class = "title" }),
                                                    Content = "Our students shared their <br> visa success stories",
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "title-shape",
                                                            Segment = "svg",
                                                            Attributes = AsJson(new { @class = "title-shape", width = "355", height = "15", viewBox = "0 0 355 15", fill = "none", xmlns = "http://www.w3.org/2000/svg" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "path",
                                                                    Segment = "path",
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "path" }, { "d", "M351.66 12.6362C187.865 -6.32755 49.6478 6.37132 3.41142 12.6362" }, { "stroke", "#764AF1" }, { "stroke-width", "3" }, { "stroke-linecap", "square" } })
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "path",
                                                                    Segment = "path",
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "path" }, { "d", "M351.66 13C187.865 -5.96378 49.6478 6.73509 3.41142 13" }, { "stroke", "#764AF1" }, { "stroke-width", "3" }, { "stroke-linecap", "square" } })
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "path",
                                                                    Segment = "path",
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "path" }, { "d", "M2.5 5.5C168.5 2.0001 280.5 -1.49994 352.5 8.49985" }, { "stroke", "#FFC44E" }, { "stroke-width", "3" }, { "stroke-linecap", "square" } })
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
                        },

                        // Feedbacks
                        new WireFrame
                        {
                            Name = "Row",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "row" }),
                            Children = [
                                new WireFrame
                                {
                                    Name = "Column 1",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-lg-3 col-md-6 col-sm-6" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "image-box-item" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/sections/students/student-01.png", alt = "" })
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = AsJson(new { @class = "video-play-btn mfp-iframe", href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = AsJson(new { width = "14", height = "25", viewBox = "0 0 14 25", fill = "none", xmlns = "http://www.w3.org/2000/svg" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = AsJson(new { d = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z", fill = "white" })
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "content" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = AsJson(new { @class = "title" }),
                                                                    Content = "Annette Black"
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Content = "University of Alberta ~ Canada"
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                }
                                            ]
                                        }
                                    ]
                                },
                                new WireFrame
                                {
                                    Name = "Column 2",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-lg-3 col-md-6 col-sm-6" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "image-box-item" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/sections/students/student-02.png", alt = "" })
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = AsJson(new { @class = "video-play-btn mfp-iframe", href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = AsJson(new { width = "14", height = "25", viewBox = "0 0 14 25", fill = "none", xmlns = "http://www.w3.org/2000/svg" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = AsJson(new { d = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z", fill = "white" })
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "content" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = AsJson(new { @class = "title" }),
                                                                    Content = "Robert Fox"
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Content = "University of Alberta ~ Canada"
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                }
                                            ]
                                        }
                                    ]
                                },
                                new WireFrame
                                {
                                    Name = "Column 3",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-lg-3 col-md-6 col-sm-6" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "image-box-item" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/sections/students/student-03.png", alt = "" })
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = AsJson(new { @class = "video-play-btn mfp-iframe", href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = AsJson(new { width = "14", height = "25", viewBox = "0 0 14 25", fill = "none", xmlns = "http://www.w3.org/2000/svg" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = AsJson(new { d = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z", fill = "white" })
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "content" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = AsJson(new { @class = "title" }),
                                                                    Content = "Leslie Alexander"
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Content = "University of Alberta ~ Canada"
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                }
                                            ]
                                        }
                                    ]
                                },
                                new WireFrame
                                {
                                    Name = "Column 4",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-lg-3 col-md-6 col-sm-6" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "image-box-item" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/sections/students/student-04.png", alt = "" })
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = AsJson(new { @class = "video-play-btn mfp-iframe", href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = AsJson(new { width = "14", height = "25", viewBox = "0 0 14 25", fill = "none", xmlns = "http://www.w3.org/2000/svg" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = AsJson(new { d = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z", fill = "white" })
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "content" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = AsJson(new { @class = "title" }),
                                                                    Content = "Kristin Watson"
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Content = "University of Alberta ~ Canada"
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
                }
            ]
        };
    }
}