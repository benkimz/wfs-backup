using MilesAhead.Components;

namespace MilesAhead.Web;

public class NewsSection : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "News Section",
            Segment = "section",
            Attributes = AsJson(new { @class = "news-section-area margin-top-110" }),
            Children = [
                new WireFrame{
                    Name = "Container",
                    Segment = "div",
                    Attributes = AsJson(new { @class = "container custom-container-01" }),
                    Children = [
                        new WireFrame{
                            Name = "Row",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "row justify-content-center" }),
                            Children = [
                                new WireFrame{
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-lg-12" }),
                                    Children = [
                                        new WireFrame{
                                            Name = "Title",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "theme-section-title desktop-center text-center" }),
                                            Children = [
                                                new WireFrame{
                                                    Name = "Subtitle",
                                                    Segment = "span",
                                                    Attributes = AsJson(new { @class = "subtitle" }),
                                                    Content = "EDUPLAN UPDATES"
                                                },
                                                new WireFrame{
                                                    Name = "Title",
                                                    Segment = "h4",
                                                    Content = "Eduplan Latest Blog"
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
                            Attributes = AsJson(new { @class = "row" }),
                            Children = [
                                new WireFrame{
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-md-6 col-lg-4" }),
                                    Children = [
                                        new WireFrame{
                                            Name = "Blog Item",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "blog-grid-item" }),
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/h-blog/01.png", @class = "border-radius-20" })
                                                        }
                                                    ]
                                                },
                                                new WireFrame{
                                                    Name = "Content",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "content" }),
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Categories",
                                                            Segment = "ul",
                                                            Attributes = AsJson(new { @class = "post-categories" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Date",
                                                                    Segment = "li",
                                                                    Content = "19th Jan 2022"
                                                                },
                                                                new WireFrame{
                                                                    Name = "Time",
                                                                    Segment = "li",
                                                                    Content = "12 noon to 4 pm"
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame{
                                                            Name = "Title",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "title" }),
                                                            Content = "Overseas Education Fair Amravati 2023"
                                                        },
                                                        new WireFrame{
                                                            Name = "Button",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "btn-wrap" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Read More",
                                                                    Segment = "a",
                                                                    Attributes = AsJson(new { href = "#0", @class = "more-btn" }),
                                                                    Content = "Read More",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "i",
                                                                            Attributes = AsJson(new { @class = "fa-solid fa-angle-right icon" })
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
                                    Attributes = AsJson(new { @class = "col-md-6 col-lg-4" }),
                                    Children = [
                                        new WireFrame{
                                            Name = "Blog Item",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "blog-grid-item" }),
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/h-blog/02.png" })
                                                        }
                                                    ]
                                                },
                                                new WireFrame{
                                                    Name = "Content",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "content" }),
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Categories",
                                                            Segment = "ul",
                                                            Attributes = AsJson(new { @class = "post-categories" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Date",
                                                                    Segment = "li",
                                                                    Content = "19th Jan 2022",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "img",
                                                                            Attributes = AsJson(new { src = "assets/img/icon/calander.png", @class = "icon" })
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "Time",
                                                                    Segment = "li",
                                                                    Content = "12 noon to 4 pm"
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame{
                                                            Name = "Title",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "title" }),
                                                            Content = "Overseas Education Fair Amravati 2023"
                                                        },
                                                        new WireFrame{
                                                            Name = "Button",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "btn-wrap" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Read More",
                                                                    Segment = "a",
                                                                    Attributes = AsJson(new { href = "#0", @class = "more-btn" }),
                                                                    Content = "Read More",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "i",
                                                                            Attributes = AsJson(new { @class = "fa-solid fa-angle-right icon" })
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
                                    Attributes = AsJson(new { @class = "col-md-6 col-lg-4" }),
                                    Children = [
                                        new WireFrame{
                                            Name = "Blog Item",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "blog-grid-item" }),
                                            Children = [
                                                new WireFrame{
                                                    Name = "Thumbnail",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "thumbnail" }),
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Image",
                                                            Segment = "img",
                                                            Attributes = AsJson(new { src = "assets/img/h-blog/03.png", alt = "" })
                                                        }
                                                    ]
                                                },
                                                new WireFrame{
                                                    Name = "Content",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "content" }),
                                                    Children = [
                                                        new WireFrame{
                                                            Name = "Categories",
                                                            Segment = "ul",
                                                            Attributes = AsJson(new { @class = "post-categories" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Date",
                                                                    Segment = "li",
                                                                    Content = "19th Jan 2022",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "img",
                                                                            Attributes = AsJson(new { src = "assets/img/icon/calander.png", @class = "icon" })
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "Time",
                                                                    Segment = "li",
                                                                    Content = "12 noon to 4 pm"
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame{
                                                            Name = "Title",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "title" }),
                                                            Content = "Overseas Education Fair Amravati 2023"
                                                        },
                                                        new WireFrame{
                                                            Name = "Button",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "btn-wrap" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "Read More",
                                                                    Segment = "a",
                                                                    Attributes = AsJson(new { href = "#0", @class = "more-btn" }),
                                                                    Content = "Read More",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "i",
                                                                            Attributes = AsJson(new { @class = "fa-solid fa-angle-right icon" })
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
    }
}