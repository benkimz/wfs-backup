using MilesAhead.Components;

namespace MilesAhead.Web;

public class NewsSection
{
    public WireFrame Build()
    {
        WireFrame NewsFrame = new WireFrame
        {
            Name = "News Section",
            Segment = "section",
            Attributes = [
                new WireFrameAttribute
                {
                    Name = "class",
                    Value = "news-section-area margin-top-110"
                }
            ],
            Children = [
                new WireFrame{
                    Name = "Container",
                    Segment = "div",
                    Attributes = [
                        new WireFrameAttribute
                        {
                            Name = "class",
                            Value = "container custom-container-01"
                        }
                    ],
                    Children = [
                        new WireFrame{
                            Name = "Row",
                            Segment = "div",
                            Attributes = [
                                new WireFrameAttribute
                                {
                                    Name = "class",
                                    Value = "row justify-content-center"
                                }
                            ],
                            Children = [
                                new WireFrame{
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = [
                                        new WireFrameAttribute
                                        {
                                            Name = "class",
                                            Value = "col-lg-12"
                                        }
                                    ],
                                    Children = [
                                        new WireFrame{
                                            Name = "Title",
                                            Segment = "div",
                                            Attributes = [
                                                new WireFrameAttribute
                                                {
                                                    Name = "class",
                                                    Value = "theme-section-title desktop-center text-center"
                                                }
                                            ],
                                            Children = [
                                                new WireFrame{
                                                    Name = "Subtitle",
                                                    Segment = "span",
                                                    Attributes = [
                                                        new WireFrameAttribute
                                                        {
                                                            Name = "class",
                                                            Value = "subtitle"
                                                        }
                                                    ],
                                                    Data = new RenderData{
                                                        FallbackRenderData = [
                                                            new RenderDataItem{
                                                                Name = "text",
                                                                Value = "EDUPLAN UPDATES"
                                                            }
                                                        ]
                                                    }
                                                },
                                                new WireFrame{
                                                    Name = "Title",
                                                    Segment = "h4",
                                                    Data = new RenderData{
                                                        FallbackRenderData = [
                                                            new RenderDataItem{
                                                                Name = "text",
                                                                Value = "Eduplan Latest Blog"
                                                            }
                                                        ]
                                                    }
                                                }
                                            ]
                                        }
                                    ]
                                }
                            ]
                        },
                        new WireFrame{
                            Name = "Row",
                            Segment = "div",
                            Attributes = [
                                new WireFrameAttribute
                                {
                                    Name = "class",
                                    Value = "row"
                                }
                            ],
                            Children = [
                                new WireFrame{
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = [
                                        new WireFrameAttribute
                                        {
                                            Name = "class",
                                            Value = "col-md-6 col-lg-4"
                                        }
                                    ],
                                    Children = [
                                        new WireFrame{
                                            Name = "Blog Item",
                                            Segment = "div",
                                            Attributes = [
                                                new WireFrameAttribute
                                                {
                                                    Name = "class",
                                                    Value = "blog-grid-item"
                                                }
                                            ],
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [
                                                        new WireFrameAttribute
                                                        {
                                                            Name = "class",
                                                            Value = "thumbnail"
                                                        }
                                                    ],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "src",
                                                                    Value = "assets/img/h-blog/01.png"
                                                                },
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "alt",
                                                                    Value = ""
                                                                },
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "border-radius-20"
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                },
                                                new WireFrame{
                                                    Name = "Content",
                                                    Segment = "div",
                                                    Attributes = [
                                                        new WireFrameAttribute
                                                        {
                                                            Name = "class",
                                                            Value = "content"
                                                        }
                                                    ],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Categories",
                                                            Segment = "ul",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "post-categories"
                                                                }
                                                            ],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Date",
                                                                    Segment = "li",
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "19th Jan 2022"
                                                                            }
                                                                        ]
                                                                    }
                                                                },
                                                                new WireFrame{
                                                                    Name = "Time",
                                                                    Segment = "li",
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "12 noon to 4 pm"
                                                                            }
                                                                        ]
                                                                    }
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame{
                                                            Name = "Title",
                                                            Segment = "h4",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "title"
                                                                }
                                                            ],
                                                            Data = new RenderData{
                                                                FallbackRenderData = [
                                                                    new RenderDataItem{
                                                                        Name = "text",
                                                                        Value = "Overseas Education Fair Amravati 2023"
                                                                    }
                                                                ]
                                                            }
                                                        },
                                                        new WireFrame{
                                                            Name = "Button",
                                                            Segment = "div",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "btn-wrap"
                                                                }
                                                            ],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Read More",
                                                                    Segment = "a",
                                                                    Attributes = [
                                                                        new WireFrameAttribute
                                                                        {
                                                                            Name = "href",
                                                                            Value = "#0"
                                                                        },
                                                                        new WireFrameAttribute
                                                                        {
                                                                            Name = "class",
                                                                            Value = "more-btn"
                                                                        }
                                                                    ],
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "Read More"
                                                                            }
                                                                        ]
                                                                    },
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "i",
                                                                            Attributes = [
                                                                                new WireFrameAttribute
                                                                                {
                                                                                    Name = "class",
                                                                                    Value = "fa-solid fa-angle-right icon"
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
                                },
                                new WireFrame{
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = [
                                        new WireFrameAttribute
                                        {
                                            Name = "class",
                                            Value = "col-md-6 col-lg-4"
                                        }
                                    ],
                                    Children = [
                                        new WireFrame{
                                            Name = "Blog Item",
                                            Segment = "div",
                                            Attributes = [
                                                new WireFrameAttribute
                                                {
                                                    Name = "class",
                                                    Value = "blog-grid-item"
                                                }
                                            ],
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [
                                                        new WireFrameAttribute
                                                        {
                                                            Name = "class",
                                                            Value = "thumbnail"
                                                        }
                                                    ],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "src",
                                                                    Value = "assets/img/h-blog/02.png"
                                                                },
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "alt",
                                                                    Value = ""
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                },
                                                new WireFrame{
                                                    Name = "Content",
                                                    Segment = "div",
                                                    Attributes = [
                                                        new WireFrameAttribute
                                                        {
                                                            Name = "class",
                                                            Value = "content"
                                                        }
                                                    ],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Categories",
                                                            Segment = "ul",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "post-categories"
                                                                }
                                                            ],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Date",
                                                                    Segment = "li",
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "19th Jan 2022"
                                                                            }
                                                                        ]
                                                                    },
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "img",
                                                                            Attributes = [
                                                                                new WireFrameAttribute
                                                                                {
                                                                                    Name = "src",
                                                                                    Value = "assets/img/icon/calander.png"
                                                                                },
                                                                                new WireFrameAttribute
                                                                                {
                                                                                    Name = "alt",
                                                                                    Value = ""
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "Time",
                                                                    Segment = "li",
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "12 noon to 4 pm"
                                                                            }
                                                                        ]
                                                                    }
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame{
                                                            Name = "Title",
                                                            Segment = "h4",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "title"
                                                                }
                                                            ],
                                                            Data = new RenderData{
                                                                FallbackRenderData = [
                                                                    new RenderDataItem{
                                                                        Name = "text",
                                                                        Value = "Overseas Education Fair Amravati 2023"
                                                                    }
                                                                ]
                                                            }
                                                        },
                                                        new WireFrame{
                                                            Name = "Button",
                                                            Segment = "div",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "btn-wrap"
                                                                }
                                                            ],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Read More",
                                                                    Segment = "a",
                                                                    Attributes = [
                                                                        new WireFrameAttribute
                                                                        {
                                                                            Name = "href",
                                                                            Value = "#0"
                                                                        },
                                                                        new WireFrameAttribute
                                                                        {
                                                                            Name = "class",
                                                                            Value = "more-btn"
                                                                        }
                                                                    ],
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "Read More"
                                                                            }
                                                                        ]
                                                                    },
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "i",
                                                                            Attributes = [
                                                                                new WireFrameAttribute
                                                                                {
                                                                                    Name = "class",
                                                                                    Value = "fa-solid fa-angle-right icon"
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
                                },
                                new WireFrame{
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = [
                                        new WireFrameAttribute
                                        {
                                            Name = "class",
                                            Value = "col-md-6 col-lg-4"
                                        }
                                    ],
                                    Children = [
                                        new WireFrame{
                                            Name = "Blog Item",
                                            Segment = "div",
                                            Attributes = [
                                                new WireFrameAttribute
                                                {
                                                    Name = "class",
                                                    Value = "blog-grid-item"
                                                }
                                            ],
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = [
                                                        new WireFrameAttribute
                                                        {
                                                            Name = "class",
                                                            Value = "thumbnail"
                                                        }
                                                    ],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "src",
                                                                    Value = "assets/img/h-blog/03.png"
                                                                },
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "alt",
                                                                    Value = ""
                                                                }
                                                            ]
                                                        }
                                                    ]
                                                },
                                                new WireFrame{
                                                    Name = "Content",
                                                    Segment = "div",
                                                    Attributes = [
                                                        new WireFrameAttribute
                                                        {
                                                            Name = "class",
                                                            Value = "content"
                                                        }
                                                    ],
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Categories",
                                                            Segment = "ul",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "post-categories"
                                                                }
                                                            ],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Date",
                                                                    Segment = "li",
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "19th Jan 2022"
                                                                            }
                                                                        ]
                                                                    },
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "img",
                                                                            Attributes = [
                                                                                new WireFrameAttribute
                                                                                {
                                                                                    Name = "src",
                                                                                    Value = "assets/img/icon/calander.png"
                                                                                },
                                                                                new WireFrameAttribute
                                                                                {
                                                                                    Name = "alt",
                                                                                    Value = ""
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "Time",
                                                                    Segment = "li",
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "12 noon to 4 pm"
                                                                            }
                                                                        ]
                                                                    }
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame{
                                                            Name = "Title",
                                                            Segment = "h4",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "title"
                                                                }
                                                            ],
                                                            Data = new RenderData{
                                                                FallbackRenderData = [
                                                                    new RenderDataItem{
                                                                        Name = "text",
                                                                        Value = "Overseas Education Fair Amravati 2023"
                                                                    }
                                                                ]
                                                            }
                                                        },
                                                        new WireFrame{
                                                            Name = "Button",
                                                            Segment = "div",
                                                            Attributes = [
                                                                new WireFrameAttribute
                                                                {
                                                                    Name = "class",
                                                                    Value = "btn-wrap"
                                                                }
                                                            ],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Read More",
                                                                    Segment = "a",
                                                                    Attributes = [
                                                                        new WireFrameAttribute
                                                                        {
                                                                            Name = "href",
                                                                            Value = "#0"
                                                                        },
                                                                        new WireFrameAttribute
                                                                        {
                                                                            Name = "class",
                                                                            Value = "more-btn"
                                                                        }
                                                                    ],
                                                                    Data = new RenderData{
                                                                        FallbackRenderData = [
                                                                            new RenderDataItem{
                                                                                Name = "text",
                                                                                Value = "Read More"
                                                                            }
                                                                        ]
                                                                    },
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "i",
                                                                            Attributes = [
                                                                                new WireFrameAttribute
                                                                                {
                                                                                    Name = "class",
                                                                                    Value = "fa-solid fa-angle-right icon"
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
                        }
                    ]
                }
            ]
        };

        return NewsFrame;
    }
}