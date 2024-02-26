using MilesAhead.Components;

namespace MilesAhead.Web;

public class FeedBackSection
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Feedback-section",
            Segment = "section",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "feedback-section margin-top-110" }],
            Children = [
                new WireFrame
                {
                    Name = "container",
                    Segment = "div",
                    Attributes = [new WireFrameAttribute { Name = "class", Value = "custom-container-01" }],
                    Children = [
                        new WireFrame
                        {
                            Name = "row",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "justify-content-center" }],
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
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "desktop-center text-center" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "subtitle",
                                                    Segment = "span",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "subtitle" }],
                                                    Data = new RenderData
                                                    {
                                                        FallbackRenderData = [
                                                            new RenderDataItem { Name = "Subtitle", Value = "FEEDBACKS" }
                                                        ]
                                                    }
                                                },
                                                new WireFrame
                                                {
                                                    Name = "title",
                                                    Segment = "h4",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                    Data = new RenderData
                                                    {
                                                        FallbackRenderData = [
                                                            new RenderDataItem { Name = "Title", Value = "Our students shared their <br> visa success stories" }
                                                        ]
                                                    },
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "title-shape",
                                                            Segment = "svg",
                                                            Attributes = [
                                                                new WireFrameAttribute{Name="class", Value="title-shape"},
                                                                new WireFrameAttribute { Name = "width", Value = "355" },
                                                                new WireFrameAttribute { Name = "height", Value = "15" },
                                                                new WireFrameAttribute { Name = "viewBox", Value = "0 0 355 15" },
                                                                new WireFrameAttribute { Name = "fill", Value = "none" },
                                                                new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }
                                                            ],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "path",
                                                                    Segment = "path",
                                                                    Attributes = [
                                                                        new WireFrameAttribute { Name = "class", Value = "path" },
                                                                        new WireFrameAttribute { Name = "d", Value = "M351.66 12.6362C187.865 -6.32755 49.6478 6.37132 3.41142 12.6362" },
                                                                        new WireFrameAttribute { Name = "stroke", Value = "#764AF1" },
                                                                        new WireFrameAttribute { Name = "stroke-width", Value = "3" },
                                                                        new WireFrameAttribute { Name = "stroke-linecap", Value = "square" }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "path",
                                                                    Segment = "path",
                                                                    Attributes = [
                                                                        new WireFrameAttribute { Name = "class", Value = "path" },
                                                                        new WireFrameAttribute { Name = "d", Value = "M351.66 13C187.865 -5.96378 49.6478 6.73509 3.41142 13" },
                                                                        new WireFrameAttribute { Name = "stroke", Value = "#764AF1" },
                                                                        new WireFrameAttribute { Name = "stroke-width", Value = "3" },
                                                                        new WireFrameAttribute { Name = "stroke-linecap", Value = "square" }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "path",
                                                                    Segment = "path",
                                                                    Attributes = [
                                                                        new WireFrameAttribute { Name = "class", Value = "path" },
                                                                        new WireFrameAttribute { Name = "d", Value = "M2.5 5.5C168.5 2.0001 280.5 -1.49994 352.5 8.49985" },
                                                                        new WireFrameAttribute { Name = "stroke", Value = "#FFC44E" },
                                                                        new WireFrameAttribute { Name = "stroke-width", Value = "3" },
                                                                        new WireFrameAttribute { Name = "stroke-linecap", Value = "square" }
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
                        },

                        // Feedbacks
                        new WireFrame
                        {
                            Name = "Row",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "row" }],
                            Children = [
                                new WireFrame
                                {
                                    Name = "Column 1",
                                    Segment = "div",
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "image-box-item" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "thumbnail" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-01.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" }, new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = [new WireFrameAttribute { Name = "width", Value = "14" }, new WireFrameAttribute { Name = "height", Value = "25" }, new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" }, new WireFrameAttribute { Name = "fill", Value = "none" }, new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = [new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" }, new WireFrameAttribute { Name = "fill", Value = "white" }]
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "content" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Title", Value = "Annette Black" }
                                                                        ]
                                                                    }
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Paragraph", Value = "University of Alberta ~ Canada" }
                                                                        ]
                                                                    }
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
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "image-box-item" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "thumbnail" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-02.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" }, new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = [new WireFrameAttribute { Name = "width", Value = "14" }, new WireFrameAttribute { Name = "height", Value = "25" }, new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" }, new WireFrameAttribute { Name = "fill", Value = "none" }, new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = [new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" }, new WireFrameAttribute { Name = "fill", Value = "white" }]
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "content" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Title", Value = "Robert Fox" }
                                                                        ]
                                                                    }
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Paragraph", Value = "University of Alberta ~ Canada" }
                                                                        ]
                                                                    }
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
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "image-box-item" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "thumbnail" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-03.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" }, new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = [new WireFrameAttribute { Name = "width", Value = "14" }, new WireFrameAttribute { Name = "height", Value = "25" }, new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" }, new WireFrameAttribute { Name = "fill", Value = "none" }, new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = [new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" }, new WireFrameAttribute { Name = "fill", Value = "white" }]
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "content" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Title", Value = "Leslie Alexander" }
                                                                        ]
                                                                    }
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Paragraph", Value = "University of Alberta ~ Canada" }
                                                                        ]
                                                                    }
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
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Image Box Item",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "image-box-item" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "thumbnail" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-04.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Video Play Button",
                                                            Segment = "a",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" }, new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "SVG",
                                                                    Segment = "svg",
                                                                    Attributes = [new WireFrameAttribute { Name = "width", Value = "14" }, new WireFrameAttribute { Name = "height", Value = "25" }, new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" }, new WireFrameAttribute { Name = "fill", Value = "none" }, new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Path",
                                                                            Segment = "path",
                                                                            Attributes = [new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" }, new WireFrameAttribute { Name = "fill", Value = "white" }]
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Content",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "content" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Title",
                                                                    Segment = "h6",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Title", Value = "Kristin Watson" }
                                                                        ]
                                                                    }
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Paragraph",
                                                                    Segment = "p",
                                                                    Data = new RenderData
                                                                    {
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem { Name = "Paragraph", Value = "University of Alberta ~ Canada" }
                                                                        ]
                                                                    }
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