using WireFrames.Core;

namespace MilesAhead.Web;

public class News : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "News Section",
            Segment = "eduplan.homekit.NewsSection",
            Children = [
                new WireFrame{
                    Name = "Section Title",
                    Segment = "eduplan.homekit.news.widgets.SectionTitle",
                    Content = AsJson(new { title = "Eduplan Latest Blog", subtitle = "EDUPLAN UPDATES"}),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Blog Grid Items",
                    Segment = "eduplan.homekit.news.widgets.BlogGridItems",
                    Content = AsJson(new List<object>{
                        new {
                            image = new {
                                src = "_content/Components.Repository/assets/eduplan/img/h-blog/01.png",
                                alt = "",
                                @class = "border-radius-20"
                            },
                            content = new {
                                date = "19th Jan 2022",
                                time = "12 noon to 4 pm",
                                title = "Overseas Education Fair Amravati 2023",
                                link = "#0",
                                linkText = "Read More"
                            }
                        },
                        new {
                            image = new {
                                src = "_content/Components.Repository/assets/eduplan/img/h-blog/02.png",
                                alt = ""
                            },
                            content = new {
                                date = "19th Jan 2022",
                                time = "12 noon to 4 pm",
                                title = "Overseas Education Fair Amravati 2023",
                                link = "#0",
                                linkText = "Read More"
                            }
                        },
                        new {
                            image = new {
                                src = "_content/Components.Repository/assets/eduplan/img/h-blog/03.png",
                                alt = ""
                            },
                            content = new {
                                date = "19th Jan 2022",
                                time = "12 noon to 4 pm",
                                title = "Overseas Education Fair Amravati 2023",
                                link = "#0",
                                linkText = "Read More"
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
