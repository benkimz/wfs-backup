using WireFrames.Core;

namespace MilesAhead.Web;

public class Feedback : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Feedback Section",
            Segment = "eduplan.homekit.FeedbackSection",
            Children = [
                new WireFrame{
                    Name = "Theme Section Title",
                    Segment = "eduplan.homekit.feedback.widgets.SectionTitle",
                    Content = AsJson(new { subtitle = "FEEDBACKS", title = "Our students shared their <br> visa success stories"}),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Image box video-items",
                    Segment = "eduplan.homekit.feedback.widgets.ImageBoxItems",
                    Content = AsJson(new List<object>{
                        new {
                            image = new {
                                src = "_content/Components.Repository/assets/eduplan/img/sections/students/student-01.png",
                                alt = "Annette Black"
                            },
                            playButton = new {
                                href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk"
                            },
                            content = new {
                                title = "Annette Black",
                                description = "University of Alberta ~ Canada"
                            }
                        },
                        new {
                            image = new {
                                src = "_content/Components.Repository/assets/eduplan/img/sections/students/student-02.png",
                                alt = "Robert Fox"
                            },
                            playButton = new {
                                href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk"
                            },
                            content = new {
                                title = "Robert Fox",
                                description = "University of Alberta ~ Canada"
                            }
                        },
                        new {
                            image = new {
                                src = "_content/Components.Repository/assets/eduplan/img/sections/students/student-03.png",
                                alt = "Leslie Alexander"
                            },
                            playButton = new {
                                href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk"
                            },
                            content = new {
                                title = "Leslie Alexander",
                                description = "University of Alberta ~ Canada"
                            }
                        },
                        new {
                            image = new {
                                src = "_content/Components.Repository/assets/eduplan/img/sections/students/student-04.png",
                                alt = "Kristin Watson"
                            },
                            playButton = new {
                                href = "https://www.youtube.com/watch?v=c7XEhXZ_rsk"
                            },
                            content = new {
                                title = "Kristin Watson",
                                description = "University of Alberta ~ Canada"
                            }
                        }
                    }),
                    IsBlazorComponent = true
                }
            ],
            IsBlazorComponent = true
        };
    }
}
