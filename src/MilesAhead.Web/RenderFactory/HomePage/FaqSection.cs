using MilesAhead.Components;

namespace MilesAhead.Web;

public class FaqSection : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "FAQ Section",
            Segment = "section",
            Attributes = AsJson(new { @class = "faq-section-area margin-top-90" }),
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
                                    Attributes = AsJson(new { @class = "col-lg-6" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Theme Section Title",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "theme-section-title" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Subtitle",
                                                    Segment = "span",
                                                    Attributes = AsJson(new { @class = "subtitle" }),
                                                    Content = "FAQ"
                                                },
                                                new WireFrame
                                                {
                                                    Name = "Title",
                                                    Segment = "h4",
                                                    Attributes = AsJson(new { @class = "title" }),
                                                    Content = "Frequently asked question"
                                                }
                                            ]
                                        },
                                        new WireFrame
                                        {
                                            Name = "FAQ Content",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "faq-content" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Subtitle",
                                                    Segment = "h6",
                                                    Attributes = AsJson(new { @class = "subtitle" }),
                                                    Content = "Still do you have any questions to know? <br> Feel free to ask our experts here."
                                                },
                                                new WireFrame
                                                {
                                                    Name = "Button Wrap",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { @class = "btn-wrap" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Button",
                                                            Segment = "a",
                                                            Attributes = AsJson(new { href = "#0", @class = "btn-common flat-btn" }),
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
                                    Attributes = AsJson(new { @class = "col-lg-6" }),
                                    Children = [
                                        new WireFrame
                                        {
                                            Name = "Accordion Wrapper",
                                            Segment = "div",
                                            Attributes = AsJson(new { @class = "accordion-wrapper" }),
                                            Children = [
                                                new WireFrame
                                                {
                                                    Name = "Accordion",
                                                    Segment = "div",
                                                    Attributes = AsJson(new { id = "accordionOne" }),
                                                    Children = [
                                                        new WireFrame
                                                        {
                                                            Name = "Card",
                                                            Segment = "div",
                                                            Attributes = AsJson(new { @class = "card" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "card-header", id = "headingOne" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = AsJson(new { @class = "mb-0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "collapsed" }, { "role", "button" }, { "data-bs-toggle", "collapse" }, { "data-bs-target", "#collapseOne" }, { "aria-expanded", "false" }, { "aria-controls", "collapseOne" } }),
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
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "id", "collapseOne" }, { "class", "collapse" }, { "data-bs-parent", "#accordionOne" } }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "card-body" }),
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
                                                            Attributes = AsJson(new { @class = "card" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "card-header", id = "headingTwo" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = AsJson(new { @class = "mb-0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "collapsed" }, { "role", "button" }, { "data-bs-toggle", "collapse" }, { "data-bs-target", "#collapseTwo" }, { "aria-expanded", "false" }, { "aria-controls", "collapseTwo" } }),
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
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "id", "collapseTwo" }, { "class", "collapse" }, { "data-bs-parent", "#accordionOne" } }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "card-body" }),
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
                                                            Attributes = AsJson(new { @class = "card" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "card-header", id = "headingThree" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = AsJson(new { @class = "mb-0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "collapsed" }, { "role", "button" }, { "data-bs-toggle", "collapse" }, { "data-bs-target", "#collapseThree" }, { "aria-expanded", "false" }, { "aria-controls", "collapseThree" } }),
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
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "id", "collapseThree" }, { "class", "collapse" }, { "data-bs-parent", "#accordionOne" } }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "card-body" }),
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
                                                            Attributes = AsJson(new { @class = "card" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "card-header", id = "headingFour" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = AsJson(new { @class = "mb-0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "collapsed" }, { "role", "button" }, { "data-bs-toggle", "collapse" }, { "data-bs-target", "#collapseFour" }, { "aria-expanded", "false" }, { "aria-controls", "collapseFour" } }),
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
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "id", "collapseFour" }, { "class", "collapse" }, { "data-bs-parent", "#accordionOne" } }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "card-body" }),
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
                                                            Attributes = AsJson(new { @class = "card" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "card-header", id = "headingFive" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = AsJson(new { @class = "mb-0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "collapsed" }, { "role", "button" }, { "data-bs-toggle", "collapse" }, { "data-bs-target", "#collapseFive" }, { "aria-expanded", "false" }, { "aria-controls", "collapseFive" } }),
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
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "id", "collapseFive" }, { "class", "collapse" }, { "data-bs-parent", "#accordionOne" } }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "card-body" }),
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
                                                            Attributes = AsJson(new { @class = "card" }),
                                                            Children = [
                                                                new WireFrame
                                                                {
                                                                    Name = "Card Header",
                                                                    Segment = "div",
                                                                    Attributes = AsJson(new { @class = "card-header", id = "headingSix" }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Title",
                                                                            Segment = "h5",
                                                                            Attributes = AsJson(new { @class = "mb-0" }),
                                                                            Children = [
                                                                                new WireFrame
                                                                                {
                                                                                    Name = "Anchor",
                                                                                    Segment = "a",
                                                                                    Attributes = AsJson(new Dictionary<string, string> { { "class", "collapsed" }, { "role", "button" }, { "data-bs-toggle", "collapse" }, { "data-bs-target", "#collapseSix" }, { "aria-expanded", "false" }, { "aria-controls", "collapseSix" } }),
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
                                                                    Attributes = AsJson(new Dictionary<string, string> { { "id", "collapseSix" }, { "class", "collapse" }, { "data-bs-parent", "#accordionOne" } }),
                                                                    Children = [
                                                                        new WireFrame
                                                                        {
                                                                            Name = "Card Body",
                                                                            Segment = "div",
                                                                            Attributes = AsJson(new { @class = "card-body" }),
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