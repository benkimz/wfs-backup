using MilesAhead.Components;

namespace MilesAhead.Web;

public class FaqSection
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "FAQ Section",
            Segment = "section",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "faq-section-area margin-top-90" }],
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
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-6" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Theme Section Title",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "theme-section-title" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Subtitle",
                                                    Segment = "span",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "subtitle" }],
                                                    Content = "FAQ"
                                                },
                                                new WireFrame
                                                {
                                                    Name = "Title",
                                                    Segment = "h4",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "title" }],
                                                    Content = "Frequently asked question"
                                                }
                                            ]
                                        },
                                        new WireFrame
                                        {
                                            Name = "FAQ Content",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "faq-content" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Subtitle",
                                                    Segment = "h6",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "subtitle" }],
                                                    Content = "Still do you have any questions to know? <br> Feel free to ask our experts here."
                                                },
                                                new WireFrame
                                                {
                                                    Name = "Button Wrap",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "btn-wrap" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Button",
                                                            Segment = "a",
                                                            Attributes = [new WireFrameAttribute { Name = "href", Value = "#0" }, new WireFrameAttribute { Name = "class", Value = "btn-common flat-btn" }],
                                                            Content = "ASK YOUR QUESTIONS"
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
                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "col-lg-6" }],
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Accordion Wrapper",
                                            Segment = "div",
                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "accordion-wrapper" }],
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Accordion",
                                                    Segment = "div",
                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "accordionOne" }],
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Card",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "headingOne" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "mb-0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "collapsed" }, new WireFrameAttribute { Name = "role", Value = "button" }, new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-target", Value = "#collapseOne" }, new WireFrameAttribute { Name = "aria-expanded", Value = "false" }, new WireFrameAttribute { Name = "aria-controls", Value = "collapseOne" }],
                                                                                    Content = "1. How is get admission in abroad university?",
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Collapse",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "collapseOne" }, new WireFrameAttribute { Name = "class", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-parent", Value = "#accordionOne" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card-body" }],
                                                                            Content = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study."
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Card",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "headingTwo" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "mb-0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "collapsed" }, new WireFrameAttribute { Name = "role", Value = "button" }, new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-target", Value = "#collapseTwo" }, new WireFrameAttribute { Name = "aria-expanded", Value = "false" }, new WireFrameAttribute { Name = "aria-controls", Value = "collapseTwo" }],
                                                                                    Content = "2. Do you offer complete solution for students?"
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Collapse",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "collapseTwo" }, new WireFrameAttribute { Name = "class", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-parent", Value = "#accordionOne" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card-body" }],
                                                                            Content = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study."
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Card",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "headingThree" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "mb-0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "collapsed" }, new WireFrameAttribute { Name = "role", Value = "button" }, new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-target", Value = "#collapseThree" }, new WireFrameAttribute { Name = "aria-expanded", Value = "false" }, new WireFrameAttribute { Name = "aria-controls", Value = "collapseThree" }],
                                                                                    Content = "3. Which country is safe and better for higher study?"
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Collapse",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "collapseThree" }, new WireFrameAttribute { Name = "class", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-parent", Value = "#accordionOne" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card-body" }],
                                                                            Content = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study."
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Card",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "headingFour" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "mb-0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "collapsed" }, new WireFrameAttribute { Name = "role", Value = "button" }, new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-target", Value = "#collapseFour" }, new WireFrameAttribute { Name = "aria-expanded", Value = "false" }, new WireFrameAttribute { Name = "aria-controls", Value = "collapseFour" }],
                                                                                    Content = "4. Which country offer PR after study getting job?"
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Collapse",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "collapseFour" }, new WireFrameAttribute { Name = "class", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-parent", Value = "#accordionOne" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card-body" }],
                                                                            Content = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study."
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Card",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "headingFive" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "mb-0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "collapsed" }, new WireFrameAttribute { Name = "role", Value = "button" }, new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-target", Value = "#collapseFive" }, new WireFrameAttribute { Name = "aria-expanded", Value = "false" }, new WireFrameAttribute { Name = "aria-controls", Value = "collapseFive" }],
                                                                                    Content = "5. Can i get scholarship with my low cGPA?"
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Collapse",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "collapseFive" }, new WireFrameAttribute { Name = "class", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-parent", Value = "#accordionOne" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card-body" }],
                                                                            Content = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study."
                                                                        }
                                                                    ]
                                                                }
                                                            ]
                                                        },
                                                        new WireFrame
                                                        {
                                                            Name = "Card",
                                                            Segment = "div",
                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card" }],
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "headingSix" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "mb-0" }],
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = [new WireFrameAttribute { Name = "class", Value = "collapsed" }, new WireFrameAttribute { Name = "role", Value = "button" }, new WireFrameAttribute { Name = "data-bs-toggle", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-target", Value = "#collapseSix" }, new WireFrameAttribute { Name = "aria-expanded", Value = "false" }, new WireFrameAttribute { Name = "aria-controls", Value = "collapseSix" }],
                                                                                    Content = "6. Do you allow accomadation for students in abroad?"
                                                                                }
                                                                            ]
                                                                        }
                                                                    ]
                                                                },
                                                                new WireFrame
                                                                {
                                                                    Name = "Collapse",
                                                                    Segment = "div",
                                                                    Attributes = [new WireFrameAttribute { Name = "id", Value = "collapseSix" }, new WireFrameAttribute { Name = "class", Value = "collapse" }, new WireFrameAttribute { Name = "data-bs-parent", Value = "#accordionOne" }],
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = [new WireFrameAttribute { Name = "class", Value = "card-body" }],
                                                                            Content = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study."
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