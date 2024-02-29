using MilesAhead.Components;

namespace MilesAhead.Web;

public class TopNavigationBar : BaseBuilder
{
    public WireFrame Build()
    {
        WireFrame NavBar = new WireFrame
        {
            Name = "Top Navigation Bar",
            Segment = "nav",
            Attributes = AsJson(new { @class = "navbar navbar-area navbar-expand-lg navigation-style-02" })
        };

        NavBar.Children.AddRange([
            new WireFrame{
                Name = "Container",
                Segment = "div",
                Attributes = AsJson(new { @class = "container custom-container custom-container-01" }),
                Children = [
                    new WireFrame{
                        Name = "Responsive Menu",
                        Segment = "div",
                        Attributes = AsJson(new { @class = "responsive-menu" }),
                        Children = [
                            new WireFrame{
                                Name = "Logo Wrapper",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "logo-wrapper" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Logo",
                                        Segment = "a",
                                        Attributes = AsJson(new { href = "index.html", @class = "logo" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = AsJson(new { src = "assets/img/Logos/logo-black.svg", alt = "" })
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Navbar Toggler",
                                Segment = "button",
                                Attributes = AsJson(new Dictionary<string, string>
                                {
                                    { "class", "navbar-toggler navbar-bs-toggler" },
                                    { "type", "button" },
                                    { "data-bs-toggle", "collapse" },
                                    { "data-bs-target", "#themeim_main_menu" },
                                    { "aria-expanded", "false" },
                                    { "aria-label", "Toggle navigation" }
                                }),
                                Children = [
                                    new WireFrame{
                                        Name = "Navbar Toggler Icon",
                                        Segment = "span",
                                        Attributes = AsJson(new { @class = "navbar-toggler-icon" })
                                    }
                                ]
                            }
                        ]
                    },
                    new WireFrame{
                        Name = "Collapse Navbar",
                        Segment = "div",
                        Attributes = AsJson(new { @class = "collapse navbar-collapse", id = "themeim_main_menu" }),
                        Children = [
                            new WireFrame{
                                Name = "Navbar Nav",
                                Segment = "ul",
                                Attributes = AsJson(new { @class = "navbar-nav" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Home",
                                        Segment = "li",
                                        Attributes = AsJson(new { @class = "menu-item-has-children current-menu-item" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Home Link",
                                                Segment = "a",
                                                Attributes = AsJson(new { href = "#0" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Home Text",
                                                        Segment = "a",
                                                        Content = "Home"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Home Sub Menu",
                                                Segment = "ul",
                                                Attributes = AsJson(new { @class = "sub-menu" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Home One",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Home One Link",
                                                                Segment = "a",
                                                                Attributes = AsJson(new { href = "index.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Home One Text",
                                                                        Segment = "a",
                                                                        Content = "Home One"
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
                                                                Attributes = AsJson(new { href = "index-02.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Home Two Text",
                                                                        Segment = "a",
                                                                        Content = "Home Two"
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
                                                Attributes = AsJson(new { href = "about-us.html" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "About Us Text",
                                                        Segment = "a",
                                                        Content = "About Us"
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Pages",
                                        Segment = "li",
                                        Attributes = AsJson(new { @class = "menu-item-has-children" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Pages Link",
                                                Segment = "a",
                                                Attributes = AsJson(new { href = "#" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Pages Text",
                                                        Segment = "a",
                                                        Content = "Pages"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Pages Sub Menu",
                                                Segment = "ul",
                                                Attributes = AsJson(new { @class = "sub-menu" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Our Services",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Our Services Link",
                                                                Segment = "a",
                                                                Attributes = AsJson(new { href = "Our-services.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Our Services Text",
                                                                        Segment = "a",
                                                                        Content = "Our Services"
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
                                                                Attributes = AsJson(new { href = "services-details.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Services Details Text",
                                                                        Segment = "a",
                                                                        Content = "Services Details"
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
                                                                Attributes = AsJson(new { href = "our-team.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Team Text",
                                                                        Segment = "a",
                                                                        Content = "Team"
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
                                                                Attributes = AsJson(new { href = "instructors.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Instructors Text",
                                                                        Segment = "a",
                                                                        Content = "Instructors"
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
                                                                Attributes = AsJson(new { href = "about-instructor.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "About Instructor Text",
                                                                        Segment = "a",
                                                                        Content = "About Instructor"
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
                                                                Attributes = AsJson(new { href = "country-details.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Country Details Text",
                                                                        Segment = "a",
                                                                        Content = "Country Details"
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
                                                                Attributes = AsJson(new { href = "all-course.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "All Course Text",
                                                                        Segment = "a",
                                                                        Content = "All Course"
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
                                                                Attributes = AsJson(new { href = "all-course-widget.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "All Course Widget Text",
                                                                        Segment = "a",
                                                                        Content = "All Course Widget"
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
                                                                Attributes = AsJson(new { href = "course-details.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Course Details Text",
                                                                        Segment = "a",
                                                                        Content = "Course Details"
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
                                                                Attributes = AsJson(new { href = "apply-online.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Apply Online Text",
                                                                        Segment = "a",
                                                                        Content = "Apply Online"
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
                                                                Attributes = AsJson(new { href = "shop-cart.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Shop Cart Text",
                                                                        Segment = "a",
                                                                        Content = "Shop Cart"
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
                                                                Attributes = AsJson(new { href = "faq.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "FAQ Text",
                                                                        Segment = "a",
                                                                        Content = "FAQ"
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
                                                                Attributes = AsJson(new { href = "404.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "404 Text",
                                                                        Segment = "a",
                                                                        Content = "404"
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
                                                                Attributes = AsJson(new { href = "cart-empty.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Cart Empty Text",
                                                                        Segment = "a",
                                                                        Content = "Cart Empty"
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
                                        Attributes = AsJson(new { @class = "menu-item-has-children" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Blog Link",
                                                Segment = "a",
                                                Attributes = AsJson(new { href = "#" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Blog Text",
                                                        Segment = "a",
                                                        Content = "Blog"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Blog Sub Menu",
                                                Segment = "ul",
                                                Attributes = AsJson(new { @class = "sub-menu" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Blog",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Blog Link",
                                                                Segment = "a",
                                                                Attributes = AsJson(new { href = "blog.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Blog Text",
                                                                        Segment = "a",
                                                                        Content = "Blog"
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
                                                                Attributes = AsJson(new { href = "blog-classic.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Blog Classic Text",
                                                                        Segment = "a",
                                                                        Content = "Blog Classic"
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
                                                                Attributes = AsJson(new { href = "blog-details.html" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Blog Single Text",
                                                                        Segment = "a",
                                                                        Content = "Blog Single"
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
                                                Attributes = AsJson(new { href = "contact-us.html" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Contact Us Text",
                                                        Segment = "a",
                                                        Content = "Contact Us"
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
                        Attributes = AsJson(new { @class = "nav-right-content" }),
                        Children = [
                            new WireFrame{
                                Name = "Icon Part",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "icon-part" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Icon List",
                                        Segment = "ul",
                                        Children = [
                                            new WireFrame{
                                                Name = "Search",
                                                Segment = "li",
                                                Attributes = AsJson(new { @class = "search" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Search Link",
                                                        Segment = "a",
                                                        Attributes = AsJson(new { href = "#" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Search Image",
                                                                Segment = "img",
                                                                Attributes = AsJson(new { src = "assets/img/icon/search-icon.png", alt = "" })
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
                                Attributes  = AsJson(new { @class = "btn-wrap" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Button",
                                        Segment = "a",
                                        Attributes = AsJson(new { href = "#", @class = "btn-common nav-btn" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Button Text",
                                                Segment = "a",
                                                Content = "Free consultation"
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
            Attributes = AsJson(new { @class = "nav-area-wrapper-relative" }),
            Children = [NavBar]
        };
    }
}