using MilesAhead.Components;

namespace MilesAhead.Web;

public class TopNavigationBar
{
    public WireFrame Build()
    {
        WireFrame NavBar = new WireFrame
        {
            Name = "Top Navigation Bar",
            Segment = "nav",
            Attributes = [
                new WireFrameAttribute { Name = "class", Value = "navbar navbar-area navbar-expand-lg navigation-style-02" }
            ],
        };

        NavBar.Children.AddRange([
            new WireFrame{
                Name = "Container",
                Segment = "div",
                Attributes = [
                    new WireFrameAttribute { Name = "class", Value = "container custom-container custom-container-01" }
                ],
                Children = [
                    new WireFrame{
                        Name = "Responsive Menu",
                        Segment = "div",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "responsive-menu" }
                        ],
                        Children = [
                            new WireFrame{
                                Name = "Logo Wrapper",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "logo-wrapper" }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Logo",
                                        Segment = "a",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "href", Value = "index.html" },
                                            new WireFrameAttribute { Name = "class", Value = "logo" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "src", Value = "assets/img/Logos/logo-black.svg" },
                                                    new WireFrameAttribute { Name = "alt", Value = "" }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Navbar Toggler",
                                Segment = "button",
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "navbar-toggler navbar-bs-toggler" },
                                    new WireFrameAttribute { Name = "type", Value = "button" },
                                    new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" },
                                    new WireFrameAttribute { Name = "data-bs-target", Value = "#themeim_main_menu" },
                                    new WireFrameAttribute { Name = "aria-expanded", Value = "false" },
                                    new WireFrameAttribute { Name = "aria-label", Value = "Toggle navigation" }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Navbar Toggler Icon",
                                        Segment = "span",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "navbar-toggler-icon" }
                                        ]
                                    }
                                ]
                            }
                        ]
                    },
                    new WireFrame{
                        Name = "Collapse Navbar",
                        Segment = "div",
                        Attributes = [
                            new WireFrameAttribute { Name = "class", Value = "collapse navbar-collapse" },
                            new WireFrameAttribute { Name = "id", Value = "themeim_main_menu" }
                        ],
                        Children = [
                            new WireFrame{
                                Name = "Navbar Nav",
                                Segment = "ul",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "navbar-nav" }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Home",
                                        Segment = "li",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "menu-item-has-children current-menu-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Home Link",
                                                Segment = "a",
                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Home Text",
                                                        Segment = "a",
                                                        Data = new RenderData{
                                                            FallbackRenderData = [
                                                                new RenderDataItem { Name = "Title", Value = "Home" }
                                                            ]
                                                        }
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Home Sub Menu",
                                                Segment = "ul",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "sub-menu" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Home One",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Home One Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "index.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Home One Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Home One" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Home Two",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Home Two Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "index-02.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Home Two Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Home Two" }
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
                                    new WireFrame{
                                        Name = "About Us",
                                        Segment = "li",
                                        Children = [
                                            new WireFrame{
                                                Name = "About Us Link",
                                                Segment = "a",
                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "about-us.html" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "About Us Text",
                                                        Segment = "a",
                                                        Data = new RenderData{
                                                            FallbackRenderData = [
                                                                new RenderDataItem { Name = "Title", Value = "About Us" }
                                                            ]
                                                        }
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Pages",
                                        Segment = "li",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "menu-item-has-children" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Pages Link",
                                                Segment = "a",
                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Pages Text",
                                                        Segment = "a",
                                                        Data = new RenderData{
                                                            FallbackRenderData = [
                                                                new RenderDataItem { Name = "Title", Value = "Pages" }
                                                            ]
                                                        }
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Pages Sub Menu",
                                                Segment = "ul",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "sub-menu" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Our Services",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Our Services Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "Our-services.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Our Services Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Our Services" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Services Details",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Services Details Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "services-details.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Services Details Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Services Details" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Team",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Team Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "our-team.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Team Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Team" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Instructors",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Instructors Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "instructors.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Instructors Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Instructors" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "About Instructor",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "About Instructor Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "about-instructor.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "About Instructor Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "About Instructor" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Country Details",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Country Details Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "country-details.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Country Details Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Country Details" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "All Course",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "All Course Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "all-course.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "All Course Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "All Course" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "All Course Widget",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "All Course Widget Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "all-course-widget.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "All Course Widget Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "All Course with widget" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Course Details",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Course Details Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "course-details.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Course Details Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Course Details" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Apply Online",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Apply Online Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "apply-online.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Apply Online Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Apply Online" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Shop Cart",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Shop Cart Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "shop-cart.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Shop Cart Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Shop Cart" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "FAQ",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "FAQ Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "faq.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "FAQ Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "FAQ" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "404",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "404 Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "404.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "404 Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "404" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Cart Empty",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Cart Empty Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "cart-empty.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Cart Empty Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Cart Empty" }
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
                                    new WireFrame{
                                        Name = "Blog",
                                        Segment = "li",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "menu-item-has-children" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Blog Link",
                                                Segment = "a",
                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Blog Text",
                                                        Segment = "a",
                                                        Data = new RenderData{
                                                            FallbackRenderData = [
                                                                new RenderDataItem { Name = "Title", Value = "Blog" }
                                                            ]
                                                        }
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Blog Sub Menu",
                                                Segment = "ul",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "sub-menu" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Blog",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Blog Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "blog.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Blog Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Blog" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Blog Classic",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Blog Classic Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "blog-classic.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Blog Classic Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Blog Classic" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Blog Single",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Blog Single Link",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "blog-details.html" }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Blog Single Text",
                                                                        Segment = "a",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Blog Single" }
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
                                    new WireFrame{
                                        Name = "Contact Us",
                                        Segment = "li",
                                        Children = [
                                            new WireFrame{
                                                Name = "Contact Us Link",
                                                Segment = "a",
                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "contact-us.html" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Contact Us Text",
                                                        Segment = "a",
                                                        Data = new RenderData{
                                                            FallbackRenderData = [
                                                                new RenderDataItem { Name = "Title", Value = "Contact Us" }
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
                    new WireFrame{
                        Name = "Nav Right Content",
                        Segment = "div",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "nav-right-content" }
                        ],
                        Children = [
                            new WireFrame{
                                Name = "Icon Part",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "icon-part" }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Icon List",
                                        Segment = "ul",
                                        Children = [
                                            new WireFrame{
                                                Name = "Search",
                                                Segment = "li",
                                                Attributes = [new WireFrameAttribute { Name = "id", Value = "search" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Search Link",
                                                        Segment = "a",
                                                        Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }
                                                        ],
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Search Image",
                                                                Segment = "img",
                                                                Attributes = [
                                                                    new WireFrameAttribute { Name = "src", Value = "assets/img/icon/search-icon.png" },
                                                                    new WireFrameAttribute { Name = "alt", Value = "" }
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
                                Name = "Button Wrap",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Button",
                                        Segment = "a",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "href", Value = "#" },
                                            new WireFrameAttribute { Name = "class", Value = "btn-common nav-btn" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Button Text",
                                                Segment = "a",
                                                Data = new RenderData{
                                                    FallbackRenderData = [
                                                        new RenderDataItem { Name = "Title", Value = "Free consultation" }
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
        ]);

        return new WireFrame
        {
            Name = "Top Navigation Bar Container",
            Segment = "div",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "nav-area-wrapper-relative" }
            ],
            Children = [NavBar]
        };
    }
}