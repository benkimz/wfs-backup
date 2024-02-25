using MilesAhead.Components;

namespace MilesAhead.Web;

public class FeedBackSection
{
    public WireFrame Build()
    {
        WireFrame FeedBackFrame = new WireFrame
        {
            Name = "FeedBackFrame",
            Segment = "section",
            Attributes = [
                new WireFrameAttribute { Name = "class", Value = "feedback-section margin-top-110" }
            ],
        };

        FeedBackFrame.Children.AddRange([
            new WireFrame
            {
                Name = "container",
                Segment = "div",
                Attributes = [
                    new WireFrameAttribute { Name = "class", Value = "container custom-container-01" }
                ],
                Children = [
                    new WireFrame
                    {
                        Name = "row",
                        Segment = "div",
                        Attributes = [
                            new WireFrameAttribute { Name = "class", Value = "row justify-content-center" }
                        ],
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
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "theme-section-title desktop-center text-center" }
                                        ],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "subtitle",
                                                Segment = "span",
                                                Data =new RenderData{FallbackRenderData = [new RenderDataItem{Name = "subtitle", Value = "FEEDBACKS"}]}
                                            },
                                            new WireFrame
                                            {
                                                Name = "title",
                                                Segment = "h4",
                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "title", Value = "Our students shared their <br> visa success stories"}]},
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "title-shape",
                                                        Segment = "svg",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "class", Value = "title-shape" },
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
                    new WireFrame
                    {
                        Name = "row",
                        Segment = "div",
                        Children = [
                            new WireFrame
                            {
                                Name = "col-lg-3",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }
                                ],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "image-box-item",
                                        Segment = "div",
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "thumbnail",
                                                Segment = "div",
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "img",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-01.png" },
                                                            new WireFrameAttribute { Name = "alt", Value = "" }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "video-play-btn",
                                                        Segment = "a",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" },
                                                            new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }
                                                        ],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "svg",
                                                                Segment = "svg",
                                                                Attributes = [
                                                                    new WireFrameAttribute { Name = "width", Value = "14" },
                                                                    new WireFrameAttribute { Name = "height", Value = "25" },
                                                                    new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" },
                                                                    new WireFrameAttribute { Name = "fill", Value = "none" },
                                                                    new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame
                                                                    {
                                                                        Name = "path",
                                                                        Segment = "path",
                                                                        Attributes = [
                                                                            new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" },
                                                                            new WireFrameAttribute { Name = "fill", Value = "white" }
                                                                        ]
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h6",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "title", Value = "Annette Black"}]}
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "p", Value = "University of Alberta ~ Canada"}]}
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
                                Name = "col-lg-3",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }
                                ],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "image-box-item",
                                        Segment = "div",
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "thumbnail",
                                                Segment = "div",
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "img",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-02.png" },
                                                            new WireFrameAttribute { Name = "alt", Value = "" }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "video-play-btn",
                                                        Segment = "a",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" },
                                                            new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }
                                                        ],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "svg",
                                                                Segment = "svg",
                                                                Attributes = [
                                                                    new WireFrameAttribute { Name = "width", Value = "14" },
                                                                    new WireFrameAttribute { Name = "height", Value = "25" },
                                                                    new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" },
                                                                    new WireFrameAttribute { Name = "fill", Value = "none" },
                                                                    new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame
                                                                    {
                                                                        Name = "path",
                                                                        Segment = "path",
                                                                        Attributes = [
                                                                            new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" },
                                                                            new WireFrameAttribute { Name = "fill", Value = "white" }
                                                                        ]
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h6",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "title", Value = "Robert Fox"}]}
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "p", Value = "University of Alberta ~ Canada"}]}
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
                                Name = "col-lg-3",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }
                                ],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "image-box-item",
                                        Segment = "div",
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "thumbnail",
                                                Segment = "div",
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "img",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-03.png" },
                                                            new WireFrameAttribute { Name = "alt", Value = "" }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "video-play-btn",
                                                        Segment = "a",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" },
                                                            new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }
                                                        ],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "svg",
                                                                Segment = "svg",
                                                                Attributes = [
                                                                    new WireFrameAttribute { Name = "width", Value = "14" },
                                                                    new WireFrameAttribute { Name = "height", Value = "25" },
                                                                    new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" },
                                                                    new WireFrameAttribute { Name = "fill", Value = "none" },
                                                                    new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame
                                                                    {
                                                                        Name = "path",
                                                                        Segment = "path",
                                                                        Attributes = [
                                                                            new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" },
                                                                            new WireFrameAttribute { Name = "fill", Value = "white" }
                                                                        ]
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h6",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "title", Value = "Leslie Alexander"}]}
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "p", Value = "University of Alberta ~ Canada"}]}
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
                                Name = "col-lg-3",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }
                                ],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "image-box-item",
                                        Segment = "div",
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "thumbnail",
                                                Segment = "div",
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "img",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "src", Value = "assets/img/sections/students/student-04.png" },
                                                            new WireFrameAttribute { Name = "alt", Value = "" }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "video-play-btn",
                                                        Segment = "a",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "class", Value = "video-play-btn mfp-iframe" },
                                                            new WireFrameAttribute { Name = "href", Value = "https://www.youtube.com/watch?v=c7XEhXZ_rsk" }
                                                        ],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "svg",
                                                                Segment = "svg",
                                                                Attributes = [
                                                                    new WireFrameAttribute { Name = "width", Value = "14" },
                                                                    new WireFrameAttribute { Name = "height", Value = "25" },
                                                                    new WireFrameAttribute { Name = "viewBox", Value = "0 0 14 25" },
                                                                    new WireFrameAttribute { Name = "fill", Value = "none" },
                                                                    new WireFrameAttribute { Name = "xmlns", Value = "http://www.w3.org/2000/svg" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame
                                                                    {
                                                                        Name = "path",
                                                                        Segment = "path",
                                                                        Attributes = [
                                                                            new WireFrameAttribute { Name = "d", Value = "M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z" },
                                                                            new WireFrameAttribute { Name = "fill", Value = "white" }
                                                                        ]
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "content",
                                                        Segment = "div",
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h6",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "title", Value = "Kristin Watson"}]}
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name = "p", Value = "University of Alberta ~ Canada"}]}
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
        ]);

        return FeedBackFrame;
    }
}
