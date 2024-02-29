using MilesAhead.Components;

namespace MilesAhead.Web;

public class AboutSection : BaseBuilder
{
    public WireFrame Build()
    {
        WireFrame AboutFrame = new WireFrame
        {
            Name = "About Section",
            Segment = "section",
            Attributes = AsJson(new { @class = "about-section-area section-top-space about-home-02" }),
        };

        AboutFrame.Children.AddRange([
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
                                Attributes = AsJson(new { @class = "col-lg-6 col-md-12" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Theme Section Title",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "theme-section-title" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Subtitle",
                                                Segment = "span",
                                                Attributes = AsJson(new { @class = "subtitle" }),
                                                Content="ABOUT US & EXPERIENCE"
                                            },
                                            new WireFrame{
                                                Name = "Title",
                                                Segment = "h4",
                                                Attributes = AsJson(new { @class = "title" }),
                                                Content = "Moving beyond product innovation to gain a competitive advantage"
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "About Content Wrap",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "about-content-wrap" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Paragraph",
                                                Segment = "p",
                                                Content = "Ouya Education, which is based in Victoria, British Columbia, Canada, frequently deals with issues of employment (recruitment and retention) for temporary foreign workers (TFW), as well as temporary and permanent residency applications and other general immigration matters with Canadian federal departments (IRCC and CBSA)."
                                            },
                                            new WireFrame{
                                                Name = "Paragraph",
                                                Segment = "p",
                                                Content = "Education also provides educational consulting services for student- clients who want to study in Canada, and require help with the application process."
                                            },
                                            new WireFrame{
                                                Name = "Core Strength",
                                                Segment = "span",
                                                Attributes = AsJson(new { @class = "core" }),
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Counter Section",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "counter-section-inner style-a" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Single Counterup",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "single-counterup color-01" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Content Wrap",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "content-wrap" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Odo Area",
                                                                Segment = "div",
                                                                Attributes = AsJson(new { @class = "odo-area" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Odometer",
                                                                        Segment = "h3",
                                                                        Attributes = AsJson(new Dictionary<string, string>{ {"class", "odometer odo-title style-01"}, {"data-odometer-final", "15"} }),
                                                                        Content = "0"
                                                                    },
                                                                ]
                                                            },
                                                            new WireFrame{
                                                                Name = "Content",
                                                                Segment = "div",
                                                                Attributes = AsJson(new { @class = "content" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Subtitle",
                                                                        Segment = "h6",
                                                                        Attributes = AsJson(new { @class = "subtitle" }),
                                                                        Content = "Years Experience"
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Single Counterup",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "single-counterup color-02" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Content Wrap",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "content-wrap" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Odo Area",
                                                                Segment = "div",
                                                                Attributes = AsJson(new { @class = "odo-area" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Odometer",
                                                                        Segment = "h3",
                                                                        Attributes = AsJson(new Dictionary<string, string>{ {"class", "odometer odo-title style-01"}, {"data-odometer-final", "875"} }),
                                                                        Content = "0"
                                                                    },
                                                                ]
                                                            },
                                                            new WireFrame{
                                                                Name = "Content",
                                                                Segment = "div",
                                                                Attributes = AsJson(new { @class = "content" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Subtitle",
                                                                        Segment = "h6",
                                                                        Attributes = AsJson(new { @class = "subtitle" }),
                                                                        Content = "VISAs Approved"
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Single Counterup",
                                                Segment = "div",
                                                Attributes = AsJson(new { @class = "single-counterup color-02" }),
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Content Wrap",
                                                        Segment = "div",
                                                        Attributes = AsJson(new { @class = "content-wrap" }),
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Odo Area",
                                                                Segment = "div",
                                                                Attributes = AsJson(new { @class = "odo-area" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Odometer",
                                                                        Segment = "h3",
                                                                        Attributes = AsJson(new Dictionary<string, string>{ {"class", "odometer odo-title style-02"}, {"data-odometer-final", "96"} }),
                                                                        Content = "0"
                                                                    },
                                                                    new WireFrame{
                                                                        Name = "Title",
                                                                        Segment = "h3",
                                                                        Content = "%",
                                                                    }
                                                                ]
                                                            },
                                                            new WireFrame{
                                                                Name = "Content",
                                                                Segment = "div",
                                                                Attributes = AsJson(new { @class = "content" }),
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Subtitle",
                                                                        Segment = "h6",
                                                                        Attributes = AsJson(new { @class = "subtitle" }),
                                                                        Content = "Admission Success"
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    }
                                                ]
                                            },
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Button Wrap",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "btn-wrap" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Button",
                                                Segment = "a",
                                                Attributes = AsJson(new { href = "#", @class = "btn-common fill-btn"}),
                                                Content = "Get Free Consultation",
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Column",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "col-lg-6 col-md-12" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = AsJson(new { src = "assets/img/sections/about/student-in-library.png", @alt = "" })
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

        return AboutFrame;
    }
}
