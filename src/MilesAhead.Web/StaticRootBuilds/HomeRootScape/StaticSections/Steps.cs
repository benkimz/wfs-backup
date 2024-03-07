using WireFrames.Core;

namespace MilesAhead.Web;

public class Steps : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Steps Section",
            Segment = "eduplan.homekit.StepsSection",
            Children = [
                new WireFrame{
                    Name = "Section Title",
                    Segment = "eduplan.homekit.steps.widgets.SectionTitle",
                    Content = AsJson(new {title = "Steps to Get your Destination", subtitle = "STEPS"}),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Step Items",
                    Segment = "eduplan.homekit.steps.widgets.StepItems",
                    Content = AsJson(new List<object>{
                        new {
                            imageUrl = "_content/Components.Repository/assets/eduplan/img/icon/step-01.png",
                            caption = "Identify course <br> country & collage"
                        },
                        new {
                            imageUrl = "_content/Components.Repository/assets/eduplan/img/icon/step-02.png",
                            caption = "science <br> & professional"
                        },
                        new {
                            imageUrl = "_content/Components.Repository/assets/eduplan/img/icon/step-03.png",
                            caption = "Art, Design & <br> Culture"
                        },
                        new {
                            imageUrl = "_content/Components.Repository/assets/eduplan/img/icon/step-04.png",
                            caption = "Business & <br> Management"
                        },
                        new {
                            imageUrl = "_content/Components.Repository/assets/eduplan/img/icon/step-05.png",
                            caption = "Computer <br> Science & IT"
                        }
                    }),
                    IsBlazorComponent = true
                }
            ],
            IsBlazorComponent = true
        };
    }
}