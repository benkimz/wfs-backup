using MilesAhead.Components;

namespace MilesAhead.Web;

public class HomePrimeRoot
{
    private PrimeRoot Root { get; set; } = new PrimeRoot { RootName = nameof(HomePrimeRoot) };
    public PrimeRoot Build()
    {
        Root.ExternalStyleSheets.AddRange([
            "assets/css/animate.css",
            "assets/css/bootstrap.min.css",
            "assets/css/magnific-popup.css",
            "assets/css/nice-select.css",
            "assets/css/odometer.css",
            "assets/css/font-awesome.min.css",
            "assets/css/slick.css",
            "assets/css/style.css",
            "assets/css/responsive.css"
        ]);

        Root.BodyScripts.AddRange([
            "assets/js/jquery-3.6.0.min.js",
            "assets/js/bootstrap.min.js",
            "assets/js/jquery.magnific-popup.js",
            "assets/js/wow.min.js",
            "assets/js/jquery.nice-select.js",
            "assets/js/jquery.countdown.min.js",
            "assets/js/odometer.min.js",
            "assets/js/viewport.jquery.js",
            "assets/js/slick.min.js",
            "assets/js/main.js"
        ]);

        Root.MetaData = new WireFrame
        {
            Name = "Head Content",
            Segment = "head",
            Children = [
                new WireFrame { Name = "charset", Segment = "meta", Attributes = [new WireFrameAttribute{
                    Name = "charset",
                    Value = "UTF-8"
                }]},
                new WireFrame { Name = "viewport", Segment = "meta", Attributes = [new WireFrameAttribute{
                    Name = "name",
                    Value = "viewport"
                }, new WireFrameAttribute{
                    Name = "content",
                    Value = "width=device-width, initial-scale=1.0"
                }]},
                new WireFrame { Name = "X-UA-Compatible", Segment = "meta", Attributes = [new WireFrameAttribute{
                    Name = "http-equiv",
                    Value = "X-UA-Compatible"
                }, new WireFrameAttribute{
                    Name = "content",
                    Value = "IE=edge"
                }]},
                new WireFrame { Name = "X-UA-Compatible", Segment = "meta", Attributes = [new WireFrameAttribute{
                    Name = "http-equiv",
                    Value = "X-UA-Compatible"
                }, new WireFrameAttribute{
                    Name = "content",
                    Value = "ie=edge"
                }]},
                new WireFrame { Name = "title", Segment = "title", Data = new RenderData{
                    FallbackRenderData = [
                        new RenderDataItem { Name = "Title", Value = "Eduplan HTML-5 Template" }
                    ]
                }},
                new WireFrame { Name = "favicon", Segment = "link", Attributes = [
                    new WireFrameAttribute{
                    Name = "rel",
                    Value = "icon"
                }, new WireFrameAttribute{
                    Name = "href",
                    Value = "assets/img/favicon.png"
                }, new WireFrameAttribute{
                    Name = "sizes",
                    Value = "20x20"
                }, new WireFrameAttribute{
                    Name = "type",
                    Value = "image/png"
                }]}
            ]
        };

        WireFrame RootBody = new WireFrame { Name = $"{Root.RootName} Body", Segment = "body" };

        WireFrame BodyMain = new WireFrame
        {
            Name = "Main",
            Segment = "main",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "page-wrapper" }]
        };


        WireFrame PagesSubMenu1 = new WireFrame
        {
            Name = "sub-menu",
            Segment = "ul",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "sub-menu" }],
            Children = [
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "index.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Home One" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "index-02.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Home Two" }
                                ]
                            }
                        }
                    ]
                }
            ]
        };

        WireFrame PagesSubMenu2 = new WireFrame
        {
            Name = "sub-menu",
            Segment = "ul",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "sub-menu" }],
            Children = [
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "Our-services.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Our Services" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "services-details.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Services Details" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "our-team.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Team" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "instructors.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Instructors" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "about-instructor.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "About Instructor" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "country-details.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Country Details" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "all-course.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "All Course" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "all-course-widget.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "All Course with widget" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "course-details.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Course Details" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "apply-online.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Apply Online" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "shop-cart.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Shop Cart" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "faq.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "FAQ" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "404.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "404" }
                                ]
                            }
                        }
                    ]
                },
                new WireFrame
                {
                    Name = "li",
                    Segment = "li",
                    Children = [
                        new WireFrame
                        {
                            Name = "a",
                            Segment = "a",
                            Attributes = [new WireFrameAttribute { Name = "href", Value = "cart-empty.html" }],
                            Data = new RenderData
                            {
                                FallbackRenderData = [
                                    new RenderDataItem { Name = "Title", Value = "Cart Empty" }
                                ]
                            }
                        }
                    ]
                }
            ]
        };



        BodyMain.Children.AddRange([
            // we will generate the rest of the body content here

            // nav area
            new WireFrame
            {
                Name = "Nav Area",
                Segment = "div",
                Attributes = [new WireFrameAttribute { Name = "class", Value = "nav-area-wrapper-relative" }],
                Children = [
                    new WireFrame
                    {
                        Name = "navbar",
                        Segment = "nav",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "navbar navbar-area navbar-expand-lg navigation-style-02" }],
                        Children = [
                            new WireFrame
                            {
                                Name = "container",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "container custom-container custom-container-01" }],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "responsive-menu",
                                        Segment = "div",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "responsive-menu" }],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "logo-wrapper",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "logo-wrapper" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "logo",
                                                        Segment = "a",
                                                        Attributes = [new WireFrameAttribute { Name = "href", Value = "index.html" }, new WireFrameAttribute { Name = "class", Value = "logo" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/Logos/logo-black.svg" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                            }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame
                                            {
                                                Name = "navbar-toggler",
                                                Segment = "button",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "navbar-toggler navbar-bs-toggler" }, new WireFrameAttribute { Name = "type", Value = "button" }, new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-target", Value = "#themeim_main_menu" }, new WireFrameAttribute { Name = "aria-expanded", Value = "false" }, new WireFrameAttribute { Name = "aria-label", Value = "Toggle navigation" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "navbar-toggler-icon",
                                                        Segment = "span",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "navbar-toggler-icon" }]
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame
                                    {
                                        Name = "collapse",
                                        Segment = "div",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "collapse navbar-collapse" }, new WireFrameAttribute { Name = "id", Value = "themeim_main_menu" }],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "navbar-nav",
                                                Segment = "ul",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "navbar-nav" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "menu-item-has-children",
                                                        Segment = "li",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "menu-item-has-children current-menu-item" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }],
                                                                Data = new RenderData
                                                                {
                                                                    FallbackRenderData = [
                                                                        new RenderDataItem { Name = "Title", Value = "Home" }
                                                                    ]
                                                                }
                                                            },
                                                            PagesSubMenu1
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "a",
                                                        Segment = "a",
                                                        Attributes = [new WireFrameAttribute { Name = "href", Value = "about-us.html" }],
                                                        Data = new RenderData
                                                        {
                                                            FallbackRenderData = [
                                                                new RenderDataItem { Name = "Title", Value = "About Us" }
                                                            ]
                                                        }
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "menu-item-has-children",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                Data = new RenderData
                                                                {
                                                                    FallbackRenderData = [
                                                                        new RenderDataItem { Name = "Title", Value = "Pages" }
                                                                    ]
                                                                }
                                                            },
                                                            PagesSubMenu2,
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "menu-item-has-children",
                                                        Segment = "li",
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "a",
                                                                Segment = "a",
                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                Data = new RenderData
                                                                {
                                                                    FallbackRenderData = [
                                                                        new RenderDataItem { Name = "Title", Value = "Blog" }
                                                                    ]
                                                                }
                                                            },
                                                            PagesSubMenu2,
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "a",
                                                        Segment = "a",
                                                        Attributes = [new WireFrameAttribute { Name = "href", Value = "contact-us.html" }],
                                                        Data = new RenderData
                                                        {
                                                            FallbackRenderData = [
                                                                new RenderDataItem { Name = "Title", Value = "Contact Us" }
                                                            ]
                                                        }
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame
                                    {
                                        Name = "nav-right-content",
                                        Segment = "div",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "nav-right-content" }],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "icon-part",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "icon-part" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "ul",
                                                        Segment = "ul",
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "li",
                                                                Segment = "li",
                                                                Attributes = [new WireFrameAttribute { Name = "id", Value = "search" }],
                                                                Children = [
                                                                    new WireFrame
                                                                    {
                                                                        Name = "a",
                                                                        Segment = "a",
                                                                        Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                        Children = [
                                                                            new WireFrame
                                                                            {
                                                                                Name = "img",
                                                                                Segment = "img",
                                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/search-icon.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
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
                                                Name = "btn-wrap",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "a",
                                                        Segment = "a",
                                                        Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }, new WireFrameAttribute { Name = "class", Value = "btn-common nav-btn" }],
                                                        Data = new RenderData
                                                        {
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
                ]
            },

        ]);











        RootBody.Children.AddRange([
        // preloader
            new WireFrame
            {
                Name = "preloader",
                Segment = "div",
                Attributes = [new WireFrameAttribute { Name = "class", Value = "preloader" }],
                Children = [
                    new WireFrame
                    {
                        Name = "preloader-inner",
                        Segment = "div",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "preloader-inner" }],
                        Children = [
                            new WireFrame
                            {
                                Name = "loader",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "loader" }]
                            }
                        ]
                    }
                ]
            }, 
            // body overlay
            new WireFrame
            {
                Name = "body-overlay",
                Segment = "div",
                Attributes = [new WireFrameAttribute { Name = "class", Value = "body-overlay" }]
            }, 
            // search popup
            new WireFrame
            {
                Name = "search-popup",
                Segment = "div",
                Attributes = [new WireFrameAttribute { Name = "class", Value = "search-popup" }],
                Children = [
                    new WireFrame
                    {
                        Name = "search-form",
                        Segment = "form",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "search-form" }],
                        Children = [
                            new WireFrame
                            {
                                Name = "form-group",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "form-group" }],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "search-input",
                                        Segment = "input",
                                        Attributes = [new WireFrameAttribute { Name = "type", Value = "text" }, new WireFrameAttribute { Name = "class", Value = "form-control" }, new WireFrameAttribute { Name = "placeholder", Value = "Search....." }]
                                    }
                                ]
                            },
                            new WireFrame
                            {
                                Name = "close-btn",
                                Segment = "button",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "close-btn border-none" }],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "search-icon",
                                        Segment = "i",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "fas fa-search" }]
                                    }
                                ]
                            }
                        ]
                    }
                ]
            },
            // main
            BodyMain,
            // back to top
            new WireFrame
            {
                Name = "back-to-top",
                Segment = "div",
                Attributes = [new WireFrameAttribute { Name = "class", Value = "back-to-top" }],
                Children = [
                    new WireFrame
                    {
                        Name = "icon",
                        Segment = "i",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "fas fa-angle-up" }]
                    }
                ]
            }
        ]);

        WireFrame BodyMainNavArea = new WireFrame
        {
            Name = "Nav Area",
            Segment = "div",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "nav-area-wrapper-relative" }]
        };

        BodyMain.Children.AddRange([
            // nav area
            BodyMainNavArea,
        ]);


        Root.AddChild(RootBody);

        return Root;
    }
}

/* Page Body design & components
----------------------------------------------------------------

<body>

    <main class="page-wrapper">
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Nav Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <div class="nav-area-wrapper-relative">
            <nav class="navbar navbar-area navbar-expand-lg navigation-style-02">
                <div class="container custom-container custom-container-01">
                    <div class="responsive-menu">
                        <div class="logo-wrapper">
                            <a href="index.html" class="logo">
                                <img src="assets/img/Logos/logo-black.svg" alt="">
                            </a>
                        </div>
                        <button class="navbar-toggler navbar-bs-toggler" type="button" data-bs-toggle="collapse"
                            data-bs-target="#themeim_main_menu" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon"></span>
                        </button>
                    </div>
                    <div class="collapse navbar-collapse" id="themeim_main_menu">
                        <ul class="navbar-nav">
                            <li class="menu-item-has-children current-menu-item">
                                <a href="#0">Home</a>
                                <ul class="sub-menu">
                                    <li><a href="index.html">Home One</a></li>
                                    <li><a href="index-02.html">Home Two</a></li>
                                </ul>
                            </li>

                            <li><a href="about-us.html">About Us</a></li>

                            <li class="menu-item-has-children">
                                <a href="#">Pages</a>
                                <ul class="sub-menu">
                                    <li><a href="Our-services.html">Our Services</a></li>
                                    <li><a href="services-details.html">Services Details</a></li>
                                    <li><a href="our-team.html">Team</a></li>
                                    <li><a href="instructors.html">Instructors</a></li>
                                    <li><a href="about-instructor.html">About Instructor</a></li>
                                    <li><a href="country-details.html">Country Details</a></li>
                                    <li><a href="all-course.html">All Course</a></li>
                                    <li><a href="all-course-widget.html">All Course with widget</a></li>
                                    <li><a href="course-details.html">Course Details</a></li>
                                    <li><a href="apply-online.html">Apply Online</a></li>
                                    <li><a href="shop-cart.html">Shop Cart</a></li>
                                    <li><a href="faq.html">FAQ</a></li>
                                    <li><a href="404.html">404</a></li>
                                    <li><a href="cart-empty.html">Cart Empty</a></li>
                                </ul>
                            </li>

                            <li class="menu-item-has-children">
                                <a href="#">Blog</a>
                                <ul class="sub-menu">
                                    <li><a href="blog.html">Blog</a></li>
                                    <li><a href="blog-classic.html">Blog Classic</a></li>
                                    <li><a href="blog-details.html">Blog Single</a></li>
                                </ul>
                            </li>

                            <li><a href="contact-us.html">Contact Us</a></li>
                        </ul>
                    </div>
                    <div class="nav-right-content">
                        <div class="icon-part">
                            <ul>
                                <li id="search"><a href="#"><img src="assets/img/icon/search-icon.png" alt=""></a></li>
                            </ul>
                        </div>
                        <div class="btn-wrap">
                            <a href="#" class="btn-common nav-btn">Free consultation</a>
                        </div>
                    </div>
                </div>
            </nav>
        </div>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Nav Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Banner Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="banner-area home-01">
            <div class="container custom-container-01">
                <div class="banner-wrapper">
                    <div class="row">
                        <div class="col-xl-7 col-lg-10">
                            <div class="banner-inner">
                                <p class="subtitle">SPECIAL OFFER FIRST CUSTOMER</p>
                                <h1 class="title">Your <span>success</span> journey start with us!</h1>
                                <p>Eduplan Education Can Fulfil Your International Education Dream <br> As Per Your Best
                                    Fit with world top universities and collages.</p>
                                <div class="header-btn">
                                    <div class="btn-wrap">
                                        <a href="#0" class="btn-common flat-btn btn-active">apply online</a>
                                    </div>
                                    <div class="btn-wrap margin-left-20">
                                        <a href="contact.html" class="btn-common fill-btn">Discover</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-xl-5">
                            <div class="thumbnail">
                                <img src="assets/img/shapes/Ellipse-01.png" class="element-01" alt="Ellipse">
                                <img src="assets/img/shapes/Ellipse-02.png" class="element-02" alt="Ellipse">
                                <img src="assets/img/shapes/Vector-15.png" class="element-03" alt="vector">
                                <img src="assets/img/header/plane.png" class="element-04" alt="plane">
                                <img src="assets/img/icon/location.png" class="element-05" alt="location">
                                <img src="assets/img/header/header-img.png" class="banner-img" alt="Student">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Banner Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Features Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="features-section margin-top-100">
            <img src="assets/img/shapes/graduation.png" class="shape" alt="graduation cap">
            <div class="container custom-container-01">
                <div class="row">
                    <div class="col-lg-4 col-md-6">
                        <div class="icon-box-item">
                            <div class="icon">
                                <img src="assets/img/icon/idea.png" alt="">
                            </div>
                            <div class="content">
                                <h4 class="title">One Stop Study Solution</h4>
                                <p>Get a full view so you know where to save. Track spending, deta keep tab subscription
                                    lorem ipsum text</p>
                            </div>
                            <div class="btn-wrap">
                                <a href="#0" class="more-btn">Learn More <i class="fa-solid fa-angle-right icon"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="icon-box-item">
                            <div class="icon">
                                <img src="assets/img/icon/coversation.png" alt="">
                            </div>
                            <div class="content">
                                <h4 class="title">One To One Discussion</h4>
                                <p>Get a full view so you know where to save. Track spending, deta keep tab subscription
                                    lorem ipsum text</p>
                            </div>
                            <div class="btn-wrap">
                                <a href="#0" class="more-btn">Learn More <i class="fa-solid fa-angle-right icon"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="icon-box-item">
                            <div class="icon">
                                <img src="assets/img/icon/emergency.png" alt="">
                            </div>
                            <div class="content">
                                <h4 class="title">End To End Support</h4>
                                <p>Get a full view so you know where to save. Track spending, deta keep tab subscription
                                    lorem ipsum text</p>
                            </div>
                            <div class="btn-wrap">
                                <a href="#0" class="more-btn">Learn More <i class="fa-solid fa-angle-right icon"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Feedback Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Feedback Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="feedback-section margin-top-110">
            <div class="container custom-container-01">
                <div class="row justify-content-center">
                    <div class="col-lg-12">
                        <div class="theme-section-title desktop-center text-center">
                            <span class="subtitle">FEEDBACKS</span>
                            <h4 class="title">Our students shared their <br> visa success stories
                                <svg class="title-shape" width="355" height="15" viewBox="0 0 355 15" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <path class="path"
                                        d="M351.66 12.6362C187.865 -6.32755 49.6478 6.37132 3.41142 12.6362"
                                        stroke="#764AF1" stroke-width="3" stroke-linecap="square" />
                                    <path class="path" d="M351.66 13C187.865 -5.96378 49.6478 6.73509 3.41142 13"
                                        stroke="#764AF1" stroke-width="3" stroke-linecap="square" />
                                    <path class="path" d="M2.5 5.5C168.5 2.0001 280.5 -1.49994 352.5 8.49985"
                                        stroke="#FFC44E" stroke-width="3" stroke-linecap="square" />
                                </svg>
                            </h4>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="image-box-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/students/student-01.png" alt="">
                                <a class="video-play-btn mfp-iframe" href="https://www.youtube.com/watch?v=c7XEhXZ_rsk">
                                    <svg width="14" height="25" viewBox="0 0 14 25" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <path d="M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z"
                                            fill="white" />
                                    </svg>
                                </a>
                                <div class="content">
                                    <h6 class="title">Annette Black</h6>
                                    <p>University of Alberta ~ Canada</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="image-box-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/students/student-02.png" alt="">
                                <a class="video-play-btn mfp-iframe" href="https://www.youtube.com/watch?v=c7XEhXZ_rsk">
                                    <svg width="14" height="25" viewBox="0 0 14 25" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <path d="M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z"
                                            fill="white" />
                                    </svg>
                                </a>
                                <div class="content">
                                    <h6 class="title">Robert Fox</h6>
                                    <p>University of Alberta ~ Canada</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="image-box-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/students/student-03.png" alt="">
                                <a class="video-play-btn mfp-iframe" href="https://www.youtube.com/watch?v=c7XEhXZ_rsk">
                                    <svg width="14" height="25" viewBox="0 0 14 25" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <path d="M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z"
                                            fill="white" />
                                    </svg>
                                </a>
                                <div class="content">
                                    <h6 class="title">Leslie Alexander</h6>
                                    <p>University of Alberta ~ Canada</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 col-sm-6">
                        <div class="image-box-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/students/student-04.png" alt="">
                                <a class="video-play-btn mfp-iframe" href="https://www.youtube.com/watch?v=c7XEhXZ_rsk">
                                    <svg width="14" height="25" viewBox="0 0 14 25" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <path d="M13.124 12.6362L0.364909 24.7606L0.36491 0.511875L13.124 12.6362Z"
                                            fill="white" />
                                    </svg>
                                </a>
                                <div class="content">
                                    <h6 class="title">Kristin Watson</h6>
                                    <p>University of Alberta ~ Canada</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Features Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Destinations Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="margin-top-110 section-bottom-space">
            <div class="destination-section">
                <img src="assets/img/shapes/mountant.png"
                    class="shape-01 wow animate__animated animate__delay-1s animate__fadeInUp" alt="mountant">
                <div class="plane-wrap">
                    <img src="assets/img/shapes/plane.png" class="shape-02" alt="mountant">
                </div>
                <div class="container custom-container-01">
                    <div class="row justify-content-center">
                        <div class="col-lg-6">
                            <div class="theme-section-title desktop-center text-center">
                                <h4 class="title">Top Destinations</h4>
                                <p>We have quality partners in variety of destinations around the globe.</p>
                            </div>
                        </div>
                    </div>
                    <div class="destination-items-wrap">
                        <div class="destination-single-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/destination/canda.png" alt="">
                            </div>
                            <h6 class="name">Canada</h6>
                        </div>
                        <div class="destination-single-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/destination/usa.png" alt="">
                            </div>
                            <h6 class="name">America</h6>
                        </div>
                        <div class="destination-single-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/destination/australia.png" alt="">
                            </div>
                            <h6 class="name">London</h6>
                        </div>
                        <div class="destination-single-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/destination/span.png" alt="">
                            </div>
                            <h6 class="name">Spain</h6>
                        </div>
                        <div class="destination-single-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/destination/franch.png" alt="">
                            </div>
                            <h6 class="name">French</h6>
                        </div>
                        <div class="destination-single-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/destination/swideen.png" alt="">
                            </div>
                            <h6 class="name">Sweden</h6>
                        </div>
                        <div class="destination-single-item">
                            <div class="thumbnail">
                                <img src="assets/img/sections/destination/italy.png" alt="">
                            </div>
                            <h6 class="name">Italy</h6>
                        </div>
                    </div>
                    <div class="btn-wrap desktop-center margin-top-40 text-center">
                        <a href="contact.html" class="btn-common fill-btn style-01">apply online</a>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Destinations Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            About Section Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="about-section-area section-top-space about-home-02">
            <div class="container custom-container-01">
                <div class="row">
                    <div class="col-lg-6 col-md-12">
                        <div class="theme-section-title">
                            <span class="subtitle">ABOUT US & EXPERIENCE</span>
                            <h4 class="title">Moving beyond product innovation to gain a competitive advantage
                                <svg class="title-shape style-01" width="355" height="15" viewBox="0 0 355 15"
                                    fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <path class="path"
                                        d="M351.66 12.6362C187.865 -6.32755 49.6478 6.37132 3.41142 12.6362"
                                        stroke="#764AF1" stroke-width="3" stroke-linecap="square" />
                                    <path class="path" d="M351.66 13C187.865 -5.96378 49.6478 6.73509 3.41142 13"
                                        stroke="#764AF1" stroke-width="3" stroke-linecap="square" />
                                    <path class="path" d="M2.5 5.5C168.5 2.0001 280.5 -1.49994 352.5 8.49985"
                                        stroke="#FFC44E" stroke-width="3" stroke-linecap="square" />
                                </svg>
                            </h4>
                        </div>
                        <div class="about-content-wrap">
                            <p>Ouya Education, which is based in Victoria, British Columbia, Canada, frequently deals
                                with issues of employment (recruitment and retention) for temporary foreign workers
                                (TFW), as well as temporary and permanent residency applications and other general
                                immigration matters with Canadian federal departments (IRCC and CBSA).</p>
                            <p>Education also provides educational consulting services for student- clients who want to
                                study in Canada, and require help with the application process.</p>
                            <span class="core">Core strength</span>
                        </div>
                        <div class="counter-section-inner style-a">
                            <div class="single-counterup color-01">
                                <div class="content-wrap">
                                    <div class="odo-area">
                                        <h3 class="odometer odo-title" data-odometer-final="15">0</h3>
                                    </div>
                                    <div class="content">
                                        <h6 class="subtitle">Years Experience</h6>
                                    </div>
                                </div>
                            </div>
                            <div class="single-counterup color-02">
                                <div class="content-wrap">
                                    <div class="odo-area">
                                        <h3 class="odometer odo-title style-01" data-odometer-final="875">0</h3>
                                    </div>
                                    <div class="content">
                                        <h6 class="subtitle">VISA Approved</h6>
                                    </div>
                                </div>
                            </div>
                            <div class="single-counterup color-03">
                                <div class="content-wrap">
                                    <div class="odo-area">
                                        <h3 class="odometer odo-title style-02" data-odometer-final="96">0</h3>
                                        <h3 class="title">%</h3>
                                    </div>
                                    <div class="content">
                                        <h6 class="subtitle">Admission success</h6>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="btn-wrap">
                            <a href="#" class="btn-common fill-btn">Get Free Consultation</a>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-12">
                        <div class="thumbnail">
                            <img src="assets/img/sections/about/student-in-library.png" alt="">
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            About Section Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Category Section Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="category-section-area">
            <div class="container custom-container-01">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="section-title-wrapper d-flex justify-content-between">
                            <div class="theme-section-title">
                                <span class="subtitle">CATEGORIES</span>
                                <h4 class="title">Popular Discipline & Collage</h4>
                            </div>
                            <ul class="nav nav-pills">
                                <li class="nav-item">
                                    <a href="#" class="nav-link active" data-bs-toggle="pill"
                                        data-bs-target="#discipline">Discipline</a>
                                </li>
                                <li class="nav-item">
                                    <a href="#" class="nav-link" data-bs-toggle="pill"
                                        data-bs-target="#collage">Collage</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="tab-content">
                    <div class="tab-pane fade show active" id="discipline">
                        <div class="destination-items-wrap">
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/foresty.png" alt="">
                                </div>
                                <h6 class="name">Agriculture & <br> Foresty</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/science.png" alt="">
                                </div>
                                <h6 class="name">science <br> & professional</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/art.png" alt="">
                                </div>
                                <h6 class="name">Art, Design & <br> Culture</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/business.png" alt="">
                                </div>
                                <h6 class="name">Business & <br> Management</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/pc.png" alt="">
                                </div>
                                <h6 class="name">Computer <br> Science & IT</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/book.png" alt="">
                                </div>
                                <h6 class="name">Education & <br> Training</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/click.png" alt="">
                                </div>
                                <h6 class="name">Engeneering & <br> Technology</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/french-fry.png" alt="">
                                </div>
                                <h6 class="name">Hopitality & <br> Sports</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/news-paper.png" alt="">
                                </div>
                                <h6 class="name">Journalism & <br> Media</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/first-aid-kit.png" alt="">
                                </div>
                                <h6 class="name">Medicine & <br> Health</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/law.png" alt="">
                                </div>
                                <h6 class="name">Law</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/enverment.png" alt="">
                                </div>
                                <h6 class="name">Social Science</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/humanity.png" alt="">
                                </div>
                                <h6 class="name">Humanities</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/recicle.png" alt="">
                                </div>
                                <h6 class="name">Enviromental <br> Studies</h6>
                            </div>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="collage">
                        <div class="destination-items-wrap">
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/french-fry.png" alt="">
                                </div>
                                <h6 class="name">Hopitality & <br> Sports</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/news-paper.png" alt="">
                                </div>
                                <h6 class="name">Journalism & <br> Media</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/first-aid-kit.png" alt="">
                                </div>
                                <h6 class="name">Medicine & <br> Health</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/law.png" alt="">
                                </div>
                                <h6 class="name">Law</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/enverment.png" alt="">
                                </div>
                                <h6 class="name">Social Science</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/humanity.png" alt="">
                                </div>
                                <h6 class="name">Humanities</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/recicle.png" alt="">
                                </div>
                                <h6 class="name">Enviromental <br> Studies</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/foresty.png" alt="">
                                </div>
                                <h6 class="name">Agriculture & <br> Foresty</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/science.png" alt="">
                                </div>
                                <h6 class="name">science <br> & professional</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/art.png" alt="">
                                </div>
                                <h6 class="name">Art, Design & <br> Culture</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/business.png" alt="">
                                </div>
                                <h6 class="name">Business & <br> Management</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/pc.png" alt="">
                                </div>
                                <h6 class="name">Computer <br> Science & IT</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/book.png" alt="">
                                </div>
                                <h6 class="name">Education & <br> Training</h6>
                            </div>
                            <div class="destination-single-item style-01">
                                <div class="thumbnail">
                                    <img src="assets/img/sections/desipline/click.png" alt="">
                                </div>
                                <h6 class="name">Engeneering & <br> Technology</h6>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Category Section Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Steps Section Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="destination-section style-01 margin-top-110 instruction">
            <div class="container custom-container-01">
                <div class="row justify-content-center">
                    <div class="col-lg-12">
                        <div class="theme-section-title desktop-center text-center">
                            <span class="subtitle">STEPS</span>
                            <h4 class="title">Steps to Get your Destination</h4>
                        </div>
                    </div>
                </div>
                <div class="destination-items-wrap">
                    <div class="destination-single-item style-02">
                        <div class="thumbnail">
                            <img src="assets/img/icon/step-01.png" alt="">
                        </div>
                        <h6 class="name">Identify course <br> country & collage</h6>
                    </div>
                    <div class="destination-single-item style-02">
                        <div class="thumbnail">
                            <img src="assets/img/icon/step-02.png" alt="">
                        </div>
                        <h6 class="name">science <br> & professional</h6>
                    </div>
                    <div class="destination-single-item style-02">
                        <div class="thumbnail">
                            <img src="assets/img/icon/step-03.png" alt="">
                        </div>
                        <h6 class="name">Art, Design & <br> Culture</h6>
                    </div>
                    <div class="destination-single-item style-02">
                        <div class="thumbnail">
                            <img src="assets/img/icon/step-04.png" alt="">
                        </div>
                        <h6 class="name">Business & <br> Management</h6>
                    </div>
                    <div class="destination-single-item style-02">
                        <div class="thumbnail">
                            <img src="assets/img/icon/step-05.png" alt="">
                        </div>
                        <h6 class="name">Computer <br> Science & IT</h6>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Steps Section Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            News Section Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="news-section-area margin-top-110">
            <div class="container custom-container-01">
                <div class="row justify-content-center">
                    <div class="col-lg-12">
                        <div class="theme-section-title desktop-center text-center">
                            <span class="subtitle">EDUPLAN UPDATES</span>
                            <h4 class="title">Eduplan Latest Blog</h4>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6 col-lg-4">
                        <div class="blog-grid-item">
                            <div class="thumbnail">
                                <img src="assets/img/h-blog/01.png" alt="" class="border-radius-20">
                            </div>
                            <div class="content">
                                <ul class="post-categories">
                                    <li><img src="assets/img/icon/calander.png" alt="">19th Jan 2022</li>
                                    <li>12 noon to 4 pm</li>
                                </ul>
                                <h4 class="title">Overseas Education Fair Amravati 2023</h4>
                                <div class="btn-wrap">
                                    <a href="#0" class="more-btn">Read More <i
                                            class="fa-solid fa-angle-right icon"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 col-lg-4">
                        <div class="blog-grid-item">
                            <div class="thumbnail">
                                <img src="assets/img/h-blog/02.png" alt="">
                            </div>
                            <div class="content">
                                <ul class="post-categories">
                                    <li><img src="assets/img/icon/calander.png" alt="">19th Jan 2022</li>
                                    <li>12 noon to 4 pm</li>
                                </ul>
                                <h4 class="title">Overseas Education Fair Amravati 2023</h4>
                                <div class="btn-wrap">
                                    <a href="#0" class="more-btn">Read More <i
                                            class="fa-solid fa-angle-right icon"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 col-lg-4">
                        <div class="blog-grid-item">
                            <div class="thumbnail">
                                <img src="assets/img/h-blog/03.png" alt="">
                            </div>
                            <div class="content">
                                <ul class="post-categories">
                                    <li><img src="assets/img/icon/calander.png" alt="">19th Jan 2022</li>
                                    <li>12 noon to 4 pm</li>
                                </ul>
                                <h4 class="title">Overseas Education Fair Amravati 2023</h4>
                                <div class="btn-wrap">
                                    <a href="#0" class="more-btn">Read More <i
                                            class="fa-solid fa-angle-right icon"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            News Section Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Faq Section Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="faq-section-area margin-top-90">
            <div class="container custom-container-01">
                <div class="row">
                    <div class="col-lg-6">
                        <div class="theme-section-title">
                            <span class="subtitle">FAQ</span>
                            <h4 class="title">Frequently asked question</h4>
                        </div>
                        <div class="faq-content">
                            <h6 class="subtitle">Still do you have any questions to know? <br> Feel free to ask our
                                experts here.</h6>
                            <div class="btn-wrap">
                                <a href="#0" class="btn-common flat-btn">ASK YOUR QUESTIONS</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="accordion-wrapper">
                            <!-- accordion wrapper -->
                            <div id="accordionOne">
                                <div class="card">
                                    <div class="card-header" id="headingOne">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseOne" aria-expanded="false"
                                                aria-controls="collapseOne">
                                                1. How is get admission in abroad university?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseOne" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingTwo">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseTwo" aria-expanded="false"
                                                aria-controls="collapseTwo">
                                                2. Do you offer complete solution for students?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseTwo" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingThree">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseThree" aria-expanded="false"
                                                aria-controls="collapseThree">
                                                3. Which country is safe and better for higher study?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseThree" class="collapse show" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingFour">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseFour" aria-expanded="false"
                                                aria-controls="collapseFour">
                                                4. Which country offer PR after study getting job?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseFour" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingFive">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseFive" aria-expanded="false"
                                                aria-controls="collapseFive">
                                                5. Can i get scholarship with my low cGPA?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseFive" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingSix">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseSix" aria-expanded="false"
                                                aria-controls="collapseSix">
                                                6. Do you allow accomadation for students in abroad?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseSix" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Faq Section Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            footer area start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <footer class="footer-area style-01">
            <div class="footer-top">
                <div class="container custom-container-01">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <div class="footer-widget widget widget_subscribe">
                                <div class="subscibe-wrapper">
                                    <div class="content-wrap">
                                        <div class="icon">
                                            <img src="assets/img/icon/newslater.png" alt="">
                                        </div>
                                        <div class="content">
                                            <h4 class="title">Subscribe our newsletter</h4>
                                            <p>Enter your mail address to get our updates, offer and study abroad
                                                related all updates</p>
                                        </div>

                                    </div>
                                    <div class="subscribe-form">
                                        <div class="form-group">
                                            <input type="text" name="fname" placeholder="Enter your Email..."
                                                class="form-control" required="" aria-required="true">
                                            <div class="btn-wrap">
                                                <a href="service-single.html" class="subscribe-btn">
                                                    <img src="assets/img/icon/bell.png" alt="">subscribe</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="footer-middle">
                        <div class="row">
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Important Links</h4>
                                    <ul>
                                        <li><a href="#">Terms and conditions</a></li>
                                        <li><a href="#">Disclaimer and copyright</a></li>
                                        <li><a href="#">Cookie policy</a></li>
                                        <li><a href="#">Privacy policy</a></li>
                                        <li><a href="#">Equality and diversity</a></li>
                                        <li><a href="#">Complaints procedure</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Site Highlight</h4>
                                    <ul>
                                        <li><a href="#">Student videos</a></li>
                                        <li><a href="#">Photo gallery</a></li>
                                        <li><a href="#">TSC prospectus</a></li>
                                        <li><a href="#">Student newsletter</a></li>
                                        <li><a href="#">Student portal</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Help Center</h4>
                                    <ul>
                                        <li><a href="#">Courses</a></li>
                                        <li><a href="#">How to apply for admission</a></li>
                                        <li><a href="#">Admission Documents</a></li>
                                        <li><a href="#">Frequently asked questions</a></li>
                                        <li><a href="#">Student accommodation</a></li>
                                        <li><a href="#">Student Jobs</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Services</h4>
                                    <ul>
                                        <li><a href="#">Counselling</a></li>
                                        <li><a href="#">Test Preparation</a></li>
                                        <li><a href="#">Admission</a></li>
                                        <li><a href="#">Education Loan</a></li>
                                        <li><a href="#">Visa Processing</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Location</h4>
                                    <ul class="contact_info_list">
                                        <li class="single-info-item">
                                            <div class="icon">
                                                <img src="assets/img/icon/location-02.png" alt="">
                                            </div>
                                            <div class="details">
                                                8502 Preston Rd. Inglewood, Maine Bangladesh
                                            </div>
                                        </li>
                                        <li class="single-info-item">
                                            <div class="icon me-4">
                                                <img src="assets/img/icon/edu-award.png" alt="">
                                            </div>
                                            <div class="icon">
                                                <img src="assets/img/icon/iso.png" alt="">
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="copyright-area">
                <div class="container custom-container-01">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="copyright-area-inner">
                                <p>© 2022 Eduplan. All rights reserved | Developed By <span>Themeim</span></p>
                                <div class="footer-social-area">
                                    <ul class="social-icon-02">
                                        <li><a href="#0"><i class="fab fa-facebook-f"></i></a></li>
                                        <li><a href="#0"><i class="fab fa-instagram"></i></a></li>
                                        <li><a href="#0"><i class="fab fa-linkedin-in"></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            footer area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
    </main>

    <!-- back to top area start -->
    <div class="back-to-top">
        <span class="back-top"><i class="fa fa-angle-up"></i></span>
    </div>
    <!-- back to top area end -->
</body>
*/
