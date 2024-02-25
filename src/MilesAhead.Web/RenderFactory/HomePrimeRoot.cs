﻿using MilesAhead.Components;

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

            // banner area
            new WireFrame
            {
                Name = "Banner Area",
                Segment = "section",
                Attributes = [new WireFrameAttribute { Name = "class", Value = "banner-area home-01" }],
                Children = [
                    new WireFrame
                    {
                        Name = "container",
                        Segment = "div",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "container custom-container-01" }],
                        Children = [
                            new WireFrame
                            {
                                Name = "banner-wrapper",
                                Segment = "div",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "banner-wrapper" }],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "row",
                                        Segment = "div",
                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "row" }],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "col-xl-7 col-lg-10",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "col-xl-7 col-lg-10" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "banner-inner",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "banner-inner" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "subtitle",
                                                                Segment = "p",
                                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "subtitle" }],
                                                                Data = new RenderData
                                                                {
                                                                    FallbackRenderData = [
                                                                        new RenderDataItem { Name = "Title", Value = "SPECIAL OFFER FIRST CUSTOMER" }
                                                                    ]
                                                                }
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "title",
                                                                Segment = "h1",
                                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                Children = [
                                                                    new WireFrame
                                                                    {
                                                                        Name = "span",
                                                                        Segment = "span",
                                                                        Data = new RenderData
                                                                        {
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem { Name = "Title", Value = "Your success journey start with us!" }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "p",
                                                                Segment = "p",
                                                                Data = new RenderData
                                                                {
                                                                    FallbackRenderData = [
                                                                        new RenderDataItem { Name = "Title", Value = "Eduplan Education Can Fulfil Your International Education Dream As Per Your Best Fit with world top universities and collages." }
                                                                    ]
                                                                }
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "header-btn",
                                                                Segment = "div",
                                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "header-btn" }],
                                                                Children = [
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
                                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }, new WireFrameAttribute { Name = "class", Value = "btn-common flat-btn btn-active" }],
                                                                                Data = new RenderData
                                                                                {
                                                                                    FallbackRenderData = [
                                                                                        new RenderDataItem { Name = "Title", Value = "apply online" }
                                                                                    ]
                                                                                }
                                                                            }
                                                                        ]
                                                                    },
                                                                    new WireFrame
                                                                    {
                                                                        Name = "btn-wrap",
                                                                        Segment = "div",
                                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap margin-left-20" }],
                                                                        Children = [
                                                                            new WireFrame
                                                                            {
                                                                                Name = "a",
                                                                                Segment = "a",
                                                                                Attributes = [new WireFrameAttribute { Name = "href", Value = "contact.html" }, new WireFrameAttribute { Name = "class", Value = "btn-common fill-btn" }],
                                                                                Data = new RenderData
                                                                                {
                                                                                    FallbackRenderData = [
                                                                                        new RenderDataItem { Name = "Title", Value = "Discover" }
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
                                                Name = "col-xl-5",
                                                Segment = "div",
                                                Attributes = [new WireFrameAttribute { Name = "class", Value = "col-xl-5" }],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "thumbnail",
                                                        Segment = "div",
                                                        Attributes = [new WireFrameAttribute { Name = "class", Value = "thumbnail" }],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/Ellipse-01.png" }, new WireFrameAttribute { Name = "class", Value = "element-01" }, new WireFrameAttribute { Name = "alt", Value = "Ellipse" }]
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/Ellipse-02.png" }, new WireFrameAttribute { Name = "class", Value = "element-02" }, new WireFrameAttribute { Name = "alt", Value = "Ellipse" }]
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/Vector-15.png" }, new WireFrameAttribute { Name = "class", Value = "element-03" }, new WireFrameAttribute { Name = "alt", Value = "vector" }]
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/header/plane.png" }, new WireFrameAttribute { Name = "class", Value = "element-04" }, new WireFrameAttribute { Name = "alt", Value = "plane" }]
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/location.png" }, new WireFrameAttribute { Name = "class", Value = "element-05" }, new WireFrameAttribute { Name = "alt", Value = "location" }]
                                                            },
                                                            new WireFrame
                                                            {
                                                                Name = "img",
                                                                Segment = "img",
                                                                Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/header/header-img.png" }, new WireFrameAttribute { Name = "class", Value = "banner-img" }, new WireFrameAttribute { Name = "alt", Value = "Student" }]
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

            // features area
            new FeaturesSection().Build(),
            // feedback area
            new FeedBackSection().Build(),
            // destinations area
            new DestinationsSection().Build(),
            // about area
            new AboutSection().Build(),
            // category area
            new CategorySection().Build(),
            // steps area
            new StepsSection().Build(),

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



        Root.AddChild(RootBody);

        return Root;
    }
}
