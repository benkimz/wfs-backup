using MilesAhead.Components;

namespace MilesAhead.Web;

public class FooterSection : BaseBuilder
{
    public WireFrame Build()
    {
        WireFrame FooterTop = new WireFrame
        {
            Name = "Footer Top",
            Segment = "div",
            Attributes = AsJson(new { @class = "footer-top" }),
            Children = [
                new WireFrame
                {
                    Name = "Container",
                    Segment = "div",
                    Attributes = AsJson(new { @class = "container custom-container-01" }),
                    Children = [
                        new WireFrame
                        {
                            Name = "Row",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "row" }),
                            Children = [
                                new WireFrame
                                {
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-lg-12 col-md-12 col-sm-12" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Footer Widget",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "footer-widget widget widget_subscribe" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Subscribe Wrapper",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "subscibe-wrapper" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Content Wrap",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "content-wrap" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Icon",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "icon" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Image",
                                                                            Segment = "img",
                                                                            Attributes = AsJson(new { src = "assets/img/icon/newslater.png", alt = "" })
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Content",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "content" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h4",
                                                                            Attributes = AsJson(new { @class = "title" }),
                                                                            Content = "Subscribe Our Newsletter"
                                                                        },
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Paragraph",
                                                                            Segment = "p",
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
                                                            Attributes = AsJson(new { @class = "subscribe-form" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Form Group",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "form-group" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Input",
                                                                            Segment = "input",
                                                                            Attributes = AsJson(new Dictionary<string, string> { { "type", "text" }, { "name", "fname" }, { "placeholder", "Enter your Email..." }, { "class", "form-control" }, { "required", "" }, { "aria-required", "true" } })
                                                                        },
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Button Wrap",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "btn-wrap" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = AsJson(new { href = "service-single.html", @class = "subscribe-btn" }),
                                                                                    Children = [
                                                                                        new WireFrame
                                                                                        {
                                                                                            Name = "Image",
                                                                                            Segment = "img",
                                                                                            Attributes = AsJson(new { src = "assets/img/icon/bell.png", alt = "" })
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
                            Attributes = AsJson(new { @class = "footer-middle" }),
                            Children = [
                                new WireFrame
                                {
                                    Name = "Row",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "row" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Column",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "col-lg-3 col-md-6 col-sm-6" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "footer-widget widget widget_nav_menu" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "widget-headline" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                            Attributes = AsJson(new { @class = "col-lg-2 col-md-6 col-sm-6" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "footer-widget widget widget_nav_menu" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "widget-headline" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                            Attributes = AsJson(new { @class = "col-lg-3 col-md-6 col-sm-6" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "footer-widget widget widget_nav_menu" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "widget-headline" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                            Attributes = AsJson(new { @class = "col-lg-2 col-md-6 col-sm-6" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "footer-widget widget widget_nav_menu" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "widget-headline" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                                                            Attributes = AsJson(new { href = "#" }),
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
                                            Attributes = AsJson(new { @class = "col-lg-2 col-md-6 col-sm-6" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Footer Widget",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "footer-widget widget widget_nav_menu" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Headline",
                                                            Segment = "h4",
                                                            Attributes = AsJson(new { @class = "widget-headline" }),
                                                            Content = "Location"
                                                        },
                                                        new WireFrame{
                                                            Name = "Contact Info List",
                                                            Segment = "ul",
                                                            Attributes = AsJson(new { @class = "contact_info_list" }),
                                                            Children = [
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Attributes = AsJson(new { @class = "single-info-item" }),
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "icon me-4" }),
                                                                            Children = [
                                                                                new WireFrame{
                                                                                    Name = "Image",
                                                                                    Segment = "img",
                                                                                    Attributes = AsJson(new { src = "assets/img/icon/location-02.png", alt = "" })
                                                                                }
                                                                            ]
                                                                        },
                                                                        new WireFrame{
                                                                            Name = "Details",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "details" }),
                                                                            Content = "8502 Preston Rd. Inglewood, Maine Bangladesh"
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame{
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Attributes = AsJson(new { @class = "single-info-item" }),
                                                                    Children = [
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "icon me-4" }),
                                                                            Children = [
                                                                                new WireFrame{
                                                                                    Name = "Image",
                                                                                    Segment = "img",
                                                                                    Attributes = AsJson(new { src = "assets/img/icon/edu-award.png", alt = "" })
                                                                                }
                                                                            ]
                                                                        },
                                                                        new WireFrame{
                                                                            Name = "Icon",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "details" }),
                                                                            Children = [
                                                                                new WireFrame{
                                                                                    Name = "Image",
                                                                                    Segment = "img",
                                                                                    Attributes = AsJson(new { src = "assets/img/icon/iso.png", alt = "" })
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
            Attributes = AsJson(new { @class = "copy-right-area" }),
            Children = [
                new WireFrame
                {
                    Name = "Container",
                    Segment = "div",
                    Attributes = AsJson(new { @class = "container custom-container-01" }),
                    Children = [
                        new WireFrame
                        {
                            Name = "Row",
                            Segment = "div",
                            Attributes = AsJson(new { @class = "row" }),
                            Children = [
                                new WireFrame
                                {
                                    Name = "Column",
                                    Segment = "div",
                                    Attributes = AsJson(new { @class = "col-lg-12" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Copy Right Area Inner",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "copy-right-area-inner" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Paragraph",
                                                    Segment = "p",
                                                    Content = "© 2022 Eduplan. All rights reserved | Developed By <span>Themeim</span>"
                                                },
                                                new WireFrame
                                                {
                                                    Name = "Footer Social Area",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "footer-social-area" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Social Icon 02",
                                                            Segment = "ul",
                                                            Attributes = AsJson(new { @class = "social-icon-02" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = AsJson(new { href = "#0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Facebook Icon",
                                                                                    Segment = "i",
                                                                                    Attributes = AsJson(new { @class = "fab fa-facebook-f" })
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = AsJson(new { href = "#0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Instagram Icon",
                                                                                    Segment = "i",
                                                                                    Attributes = AsJson(new { @class = "fab fa-instagram" })
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "List Item",
                                                                    Segment = "li",
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Anchor",
                                                                            Segment = "a",
                                                                            Attributes = AsJson(new { href = "#0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Linkedin Icon",
                                                                                    Segment = "i",
                                                                                    Attributes = AsJson(new { @class = "fab fa-linkedin-in" })
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
            Attributes = AsJson(new { @class = "footer-area style-01" }),
            Children = [FooterTop, CopyRightArea]
        };
    }
}