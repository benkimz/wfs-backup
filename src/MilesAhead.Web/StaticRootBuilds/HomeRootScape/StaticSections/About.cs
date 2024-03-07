using WireFrames.Core;

namespace MilesAhead.Web;

public class About : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "About Section",
            Segment = "eduplan.homekit.AboutSection",
            Children = [
                new WireFrame{
                    Name = "Section Title",
                    Segment = "eduplan.homekit.about.widgets.SectionTitle",
                    Content = AsJson(new { title = "Moving beyond product innovation to gain a competitive advantage", subtitle = "ABOUT US & EXPERIENCE" }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "About Content",
                    Segment = "eduplan.homekit.about.widgets.TextContent",
                    Content = AsJson(new {
                        paragraphs =  new List<string>{
                            "Ouya Education, which is based in Victoria, British Columbia, Canada, frequently deals with issues of employment (recruitment and retention) for temporary foreign workers (TFW), as well as temporary and permanent residency applications and other general immigration matters with Canadian federal departments (IRCC and CBSA).",
                            "Education also provides educational consulting services for student- clients who want to study in Canada, and require help with the application process."
                        },
                        core = "Core strength"
                    }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Counter-Up Items",
                    Segment = "eduplan.homekit.about.widgets.CounterUpItems",
                    Content = AsJson(new List<object>{
                        new {
                            subtitle = "Years Experience",
                            color = "color-01",
                            odoStyle = "",
                            odoMeterData = "15"
                        },
                        new {
                            subtitle = "VISA Approved",
                            color = "color-02",
                            odoStyle = "style-01",
                            odoMeterData = "875"
                        },
                        new {
                            subtitle = "Admission success",
                            color = "color-03",
                            odoStyle = "style-02",
                            odoMeterData = "96",
                            odoAreaTitle = "%"
                        }
                    }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Section Button",
                    Segment = "eduplan.homekit.about.widgets.SectionButton",
                    Content = AsJson(new { targetUrl = "#", buttonText = "Get Free Consultation"}),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Section Thumbnail",
                    Segment = "eduplan.homekit.about.widgets.SectionThumbnail",
                    Content = AsJson(new { imageUrl = "_content/Components.Repository/assets/eduplan/img/sections/about/student-in-library.png" }),
                    IsBlazorComponent = true
                }
            ],
            IsBlazorComponent = true
        };
    }
}
