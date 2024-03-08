using WireFrames.Core;

namespace MilesAhead.Web;

public class Categories : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Categories Section",
            Segment = "eduplan.homekit.CategoriesSection",
            Children = [
                new WireFrame{
                    Name = "Section Header",
                    Segment = "eduplan.homekit.categories.widgets.SectionHeader",
                    Content = AsJson(new {
                        title = "Popular Discipline & Collage",
                        subtitle = "CATEGORIES",
                        navpills = new [] {
                            new { title = "Discipline", target = "discipline" },
                            new { title = "Collage", target = "collage" }
                        }
                    }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Category Tab Items",
                    Segment = "eduplan.homekit.categories.widgets.CategoryItems",
                    Content = AsJson(new []{
                        new {
                            tabId = "discipline",
                            tabItems = new [] {
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/foresty.png", name = "Agriculture & <br> Foresty" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/science.png", name = "science <br> & professional" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/art.png", name = "Art, Design & <br> Culture" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/business.png", name = "Business & <br> Management" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/pc.png", name = "Computer <br> Science & IT" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/book.png", name = "Education & <br> Training" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/click.png", name = "Engeneering & <br> Technology" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/french-fry.png", name = "Hopitality & <br> Sports" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/news-paper.png", name = "Journalism & <br> Media" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/first-aid-kit.png", name = "Medicine & <br> Health" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/law.png", name = "Law" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/enverment.png", name = "Social Science" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/humanity.png", name = "Humanities" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/recicle.png", name = "Enviromental <br> Studies"}
                            }
                        },
                        new {
                            tabId = "collage",
                            tabItems = new [] {
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/french-fry.png", name = "Hopitality & <br> Sports" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/news-paper.png", name = "Journalism & <br> Media" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/first-aid-kit.png", name = "Medicine & <br> Health" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/law.png", name = "Law" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/enverment.png", name = "Social Science" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/humanity.png", name = "Humanities" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/recicle.png", name = "Enviromental <br> Studies" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/foresty.png", name = "Agriculture & <br> Foresty" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/science.png", name = "science <br> & professional" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/art.png", name = "Art, Design & <br> Culture" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/business.png", name = "Business & <br> Management" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/pc.png", name = "Computer <br> Science & IT" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/book.png", name = "Education & <br> Training" },
                                new { thumbnail = "_content/Components.Repository/assets/eduplan/img/sections/desipline/click.png", name = "Engeneering & <br> Technology" }
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
