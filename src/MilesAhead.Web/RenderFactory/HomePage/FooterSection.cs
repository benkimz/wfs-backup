using MilesAhead.Components;

namespace MilesAhead.Web;

public class FooterSection
{
    public WireFrame Build()
    {
        WireFrame FooterTop = new WireFrame
        {
            Name = "Footer Top",
            Segment = "div",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-top" }],
            Children = [
                new WireFrame
                {
                    Name = "Container",
                    Segment = "div",
                    Attributes = [new WireFrameAttribute { Name = "class", Value = "container custom-container-01" }],
                    Children = [
                        new WireFrame
                        {
                            Name = "Row",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "row" }],
                            Children = [
                                new WireFrame
                                {
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-12 col-md-12 col-sm-12" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Footer Widget",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-widget widget widget_subscribe" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Subscribe Wrapper",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "subscibe-wrapper" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Content Wrap",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "content-wrap" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Icon",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "icon" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Image",
                                                                            Segment = "img",
                                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/newslater.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
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
                                                                            Segment = "h4",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                                            Content = "Subscribe Our Newsletter"
                                                                        },
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Paragraph",
                                                                            Segment = "p",
                                                                            Attributes = [],
                                                                            Content = "Enter your mail address to get our updates, offer and study abroad related all updates"
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Subscribe Form",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "subscribe-form" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Form Group",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "form-group" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Input",
                                                                            Segment = "input",
                                                                            Attributes = [new WireFrameAttribute { Name = "type", Value = "text" }, new WireFrameAttribute { Name = "name", Value = "fname" }, new WireFrameAttribute { Name = "placeholder", Value = "Enter your Email..." }, new WireFrameAttribute { Name = "class", Value = "form-control" }, new WireFrameAttribute { Name = "required", Value = "" }, new WireFrameAttribute { Name = "aria-required", Value = "true" }]
                                                                        },
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Button Wrap",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = [new WireFrameAttribute { Name = "href", Value = "service-single.html" }, new WireFrameAttribute { Name = "class", Value = "subscribe-btn" }],
                                                                                    Children = [
                                                                                        new WireFrame
                                                                                        {
                                                                                            Name = "Image",
                                                                                            Segment = "img",
                                                                                            Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/bell.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                                                        },
                                                                                        new WireFrame
                                                                                        {
                                                                                            Name = "Text",
                                                                                            Segment = "text",
                                                                                            Content = "subscribe"
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
                        },
                        new WireFrame
                        {
                            Name = "Footer Middle",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-middle" }],
                            Children = [
                                new WireFrame
                                {
                                    Name = "Row",
                                    Segment = "div",
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "row" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Column",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-widget widget widget_nav_menu" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "widget-headline" }],
                                                            Content = "Important Links"
                                                        },
                                                        new WireFrame{
                                                            Name = "Links List",
                                                            Segment = "ul",
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content="Terms and conditions"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content="Disclaimer and copyright"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Cookie policy"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Privacy policy"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Equality and diversity"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Complaints procedure"
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
                                            Name = "Column",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-2 col-md-6 col-sm-6" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-widget widget widget_nav_menu" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "widget-headline" }],
                                                            Content = "Site Highlight"
                                                        },
                                                        new WireFrame{
                                                            Name = "Links List",
                                                            Segment = "ul",
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Student videos"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Photo gallery"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "TSC prospectus"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Student newsletter"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Student portal"
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
                                            Name = "Column",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-3 col-md-6 col-sm-6" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-widget widget widget_nav_menu" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "widget-headline" }],
                                                            Content = "Help Center"
                                                        },
                                                        new WireFrame{
                                                            Name = "Links List",
                                                            Segment = "ul",
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Courses"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "How to apply for admission"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Admission Documents"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Frequently asked questions"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Student accommodation"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Student Jobs"
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
                                            Name = "Column",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-2 col-md-6 col-sm-6" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-widget widget widget_nav_menu" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "widget-headline" }],
                                                            Content = "Services"
                                                        },
                                                        new WireFrame{
                                                            Name = "Links List",
                                                            Segment = "ul",
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Counselling"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content = "Test Preparation"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content="Admission"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content="Education Loan"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#" }],
                                                                            Content="Visa Processing"
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
                                            Name = "Column",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-2 col-md-6 col-sm-6" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-widget widget widget_nav_menu" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "widget-headline" }],
                                                            Content = "Location"
                                                        },
                                                        new WireFrame{
                                                            Name = "Contact Info List",
                                                            Segment = "ul",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "ontact_info_list" }],
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "single-info-item" }],
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "icon" }],
                                                                            Children = [
                                                                                new WireFrame{
                                                                                    Name = "Image",
                                                                                    Segment = "img",
                                                                                    Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/location-02.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                                                }
                                                                            ]
                                                                        },
                                                                        new WireFrame{
                                                                            Name = "Details",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "details" }],
                                                                            Content = "8502 Preston Rd. Inglewood, Maine Bangladesh"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "single-info-item" }],
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "icon me-4" }],
                                                                            Children = [
                                                                                new WireFrame{
                                                                                    Name = "Image",
                                                                                    Segment = "img",
                                                                                    Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/edu-award.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
                                                                                }
                                                                            ]
                                                                        },
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "icon" }],
                                                                            Children = [
                                                                                new WireFrame{
                                                                                    Name = "Image",
                                                                                    Segment = "img",
                                                                                    Attributes = [new WireFrameAttribute { Name = "src", Value = "assets/img/icon/iso.png" }, new WireFrameAttribute { Name = "alt", Value = "" }]
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

        WireFrame CopyRightArea = new WireFrame
        {
            Name = "Copy Right Area",
            Segment = "div",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "copyright-area" }],
            Children = [
                new WireFrame
                {
                    Name = "Container",
                    Segment = "div",
                    Attributes = [new WireFrameAttribute { Name = "class", Value = "container custom-container-01" }],
                    Children = [
                        new WireFrame
                        {
                            Name = "Row",
                            Segment = "div",
                            Attributes = [new WireFrameAttribute { Name = "class", Value = "row" }],
                            Children = [
                                new WireFrame
                                {
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-12" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Copy Right Area Inner",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "copy-right-area-inner" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Paragraph",
                                                    Segment = "p",
                                                    Attributes = [],
                                                    Content = "© 2022 Eduplan. All rights reserved | Developed By <span>Themeim</span>"
                                                },
                                                new WireFrame
                                                {
                                                    Name = "Footer Social Area",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-social-area" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Social Icon 02",
                                                            Segment = "ul",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "social-icon-02" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Attributes = [],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Facebook Icon",
                                                                                    Segment = "i",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "fab fa-facebook-f" }]
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Attributes = [],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Instagram Icon",
                                                                                    Segment = "i",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "fab fa-instagram" }]
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Attributes = [],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Linkedin Icon",
                                                                                    Segment = "i",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "fab fa-linkedin-in" }]
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

        return new WireFrame
        {
            Name = "Footer Section",
            Segment = "footer",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "footer-area style-01" }],
            Children = [FooterTop, CopyRightArea]
        };
    }
}