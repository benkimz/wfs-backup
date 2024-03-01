using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class CategorySection : BaseBuilder
{
    public WireFrame Build()
    {
        WireFrame CategoryFrame = new WireFrame
        {
            Name = "Category Section",
            Segment = "section",
            Attributes = AsJson(new { @class = "category-section-area" }),
        };

        CategoryFrame.Children.AddRange([
            new WireFrame{
                Name = "Container",
                Segment = "div",
                Attributes = AsJson(new { @class = "container custom-container-01" }),
                Children = [
                    new WireFrame{
                        Name = "Row",
                        Segment = "div",
                        Attributes = AsJson(new { @class = "row" }),
                        Children = [
                            new WireFrame{
                                Name = "Column",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "col-lg-12" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Section Title Wrapper",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "section-title-wrapper d-flex justify-content-between" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Theme Section Title",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "theme-section-title" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Subtitle",
                                                        Segment = "span",
                                                        Content = "CATEGORIES"
                                                    },
                                                    new WireFrame{
                                                        Name = "Title",
                                                        Segment = "h4",
                                                        Content = "Popular Discipline & Collage"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Nav",
                                                Segment = "ul",
                                                Attributes = AsJson(new { @class = "nav nav-pills" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Nav Item",
                                                        Segment = "li",
                                                        Attributes = AsJson(new { @class = "nav-item" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Nav Link",
                                                                Segment = "a",
                                                                Attributes = AsJson(new Dictionary<string, string>
                                                                {{ "href", "#" },
                                                                    { "class", "nav-link active" },
                                                                    { "data-bs-toggle", "pill" },
                                                                    { "data-bs-target", "#discipline" }}),
                                                                Content = "Discipline"
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Nav Item",
                                                        Segment = "li",
                                                        Attributes = AsJson(new { @class = "nav-item" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Nav Link",
                                                                Segment = "a",
                                                                Attributes = AsJson(new Dictionary<string, string>
                                                                {{ "href", "#" },
                                                                    { "class", "nav-link" },
                                                                    { "data-bs-toggle", "pill" },
                                                                    { "data-bs-target", "#collage" }}),
                                                                Content = "Collage"
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
                        Name = "Tab Content",
                        Segment = "div",
                        Attributes = AsJson(new { @class = "tab-content" }),
                        Children = [
                            new WireFrame{
                                Name = "Tab Pane",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "tab-pane fade show active", id = "discipline" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Destination Items Wrap",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "destination-items-wrap" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/foresty.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Agriculture & Foresty"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/science.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Science & Professional"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/art.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Art, Design & Culture"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/business.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Business & Management"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/pc.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Computer Science & IT"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/book.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Education & Training"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/click.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Engeneering & Technology"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/french-fry.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Hopitality & Sports"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/news-paper.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Journalism & Media"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/first-aid-kit.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Medicine & Health"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/law.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Law"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/enverment.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Social Science"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/humanity.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Humanities"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/recicle.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Enviromental Studies"
                                                    }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Tab Pane",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "tab-pane fade", id = "collage" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Destination Items Wrap",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "destination-items-wrap" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/french-fry.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Hopitality & Sports"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/news-paper.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Journalism & Media"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/first-aid-kit.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Medicine & Health"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/law.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Law"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/enverment.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Social Science"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/humanity.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        // Attributes = [
                                                        //     new WireFrameAttribute{
                                                        //         Name = "class",
                                                        //         Value = "name"
                                                        //     }
                                                        // ],
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Humanities"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/recicle.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Enviromental Studies"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/foresty.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Agriculture & Foresty"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/science.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Science & Professional"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/art.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Art, Design & Culture"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/business.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Business & Management"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/pc.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Computer Science & IT"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
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
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/book.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Education & Training"
                                                    }
                                                ]
                                            },
                                            new WireFrame
                                            {
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "destination-single-item style-01" }),
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
                                                                Attributes = AsJson(new { src = "assets/img/sections/desipline/click.png", alt = "" })
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = AsJson(new { @class = "name" }),
                                                        Content = "Engeneering & Technology"
                                                    }
                                                ]
                                            },
                                        ]
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ]);

        return CategoryFrame;
    }
}