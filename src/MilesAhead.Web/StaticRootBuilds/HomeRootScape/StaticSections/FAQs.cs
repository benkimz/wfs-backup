using WireFrames.Core;

namespace MilesAhead.Web;

public class FAQs : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Faq Section",
            Segment = "eduplan.homekit.FaqSection",
            Children = [
                new WireFrame{
                    Name = "Section Title",
                    Segment = "eduplan.homekit.faqs.widgets.SectionTitle",
                    Content =AsJson(new { title = "Frequently asked question", subtitle = "FAQ"}),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Section Content | Headline",
                    Segment = "eduplan.homekit.faqs.widgets.SectionContent",
                    Content = AsJson(new { subtitle = "Still do you have any questions to know? <br> Feel free to ask our experts here.", btnLink = "#0", btnText = "ASK YOUR QUESTIONS"}),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "FAQ Card Items",
                    Segment = "eduplan.homekit.faqs.widgets.FaqCardItems",
                    Content = AsJson(new List<object>{
                        new {
                            question = "1. How is get admission in abroad university?",
                            answer = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study.",
                            collapseTarget = "collapseOne",
                            heading = "headingOne"
                        },
                        new {
                            question = "2. Do you offer complete solution for students?",
                            answer = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study.",
                            collapseTarget = "collapseTwo",
                            heading = "headingTwo"
                        },
                        new {
                            question = "3. Which country is safe and better for higher study?",
                            answer = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study.",
                            collapseTarget = "collapseThree",
                            heading = "headingThree"
                        },
                        new {
                            question = "4. Which country offer PR after study getting job?",
                            answer = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study.",
                            collapseTarget = "collapseFour",
                            heading = "headingFour"
                        },
                        new {
                            question = "5. Can i get scholarship with my low cGPA?",
                            answer = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study.",
                            collapseTarget = "collapseFive",
                            heading = "headingFive"
                        },
                        new {
                            question = "6. Do you allow accomadation for students in abroad?",
                            answer = "Norway, USA, UK, Germany & Italy is most safest country in the world for Bangladeshi students for higer study.",
                            collapseTarget = "collapseSix",
                            heading = "headingSix"
                        }
                    }),
                    IsBlazorComponent = true,
                }
            ],
            IsBlazorComponent = true
        };
    }
}
