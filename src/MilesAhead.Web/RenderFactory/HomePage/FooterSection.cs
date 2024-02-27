﻿using MilesAhead.Components;

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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Subscribe our newsletter"}]}
                                                                        },
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Paragraph",
                                                                            Segment = "p",
                                                                            Attributes = [],
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Enter your mail address to get our updates, offer and study abroad related all updates"}]
                                                                        }
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
                                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="subscribe"}]}
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
                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Important Links"}]
                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Terms and conditions"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Disclaimer and copyright"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Cookie policy"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Privacy policy"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Equality and diversity"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Complaints procedure"}]
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
                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Site Highlight"}]
                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Student videos"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Photo gallery"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="TSC prospectus"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Student newsletter"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Student portal"}]
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
                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Help Center"}]
                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Courses"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="How to apply for admission"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Admission Documents"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Frequently asked questions"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Student accommodation"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Student Jobs"}]
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
                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Services"}]
                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Counselling"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Test Preparation"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Admission"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Education Loan"}]
                                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Visa Processing"}]
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
                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Location"}]
                                                        }
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
                                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="8502 Preston Rd. Inglewood, Maine Bangladesh"}]
                                                                            }
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
                                                    Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="© 2022 Eduplan. All rights reserved | Developed By "}]},
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Span",
                                                            Segment = "span",
                                                            Data = new RenderData{FallbackRenderData = [new RenderDataItem{Name="text", Value="Themeim"}]}
                                                        }
                                                    ]
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