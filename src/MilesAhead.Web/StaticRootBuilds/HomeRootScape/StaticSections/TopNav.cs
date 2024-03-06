using WireFrames.Core;

namespace MilesAhead.Web;

public class TopNav : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Top Navigation Bar",
            Segment = "eduplan.homekit.TopNavigationBar",
            IsBlazorComponent = true,
            Children = [
                            new WireFrame{
                                Name = "Link Logo",
                                Segment = "eduplan.homekit.topnav.widgets.LinkImageLogo",
                                Attributes = AsJson(new { imageUrl = "_content/Components.Repository/assets/eduplan/img/Logos/logo-black.svg", alt = "Logo", linkUrl = "/" }),
                                IsBlazorComponent = true,
                            },
                            new WireFrame{
                                Name = "Top Navigation Menu",
                                Segment = "eduplan.homekit.topnav.widgets.TopNavMenu",
                                Attributes = AsJson(new {
                                    home = new {
                                        url = "/",
                                        subUrls = new Dictionary<string, string>{
                                            { "Home One", "index.html" },
                                            { "Home Two", "index-02.html" }
                                        }
                                    },
                                    about = new {url = "about-us.html"},
                                    pages = new {
                                        url = "#",
                                        subUrls = new Dictionary<string, string>{
                                            { "Our Services", "Our-services.html" },
                                            { "Services Details", "services-details.html" },
                                            { "Team", "our-team.html" },
                                            { "Instructors", "instructors.html" },
                                            { "About Instructor", "about-instructor.html" },
                                            { "Country Details", "country-details.html" },
                                            { "All Course", "all-course.html" },
                                            { "All Course with widget", "all-course-widget.html" },
                                            { "Course Details", "course-details.html" },
                                            { "Apply Online", "apply-online.html" },
                                            { "Shop Cart", "shop-cart.html" },
                                            { "FAQ", "faq.html" },
                                            { "404", "404.html" },
                                            { "Cart Empty", "cart-empty.html" }
                                        }
                                    },
                                    blog = new {
                                        url = "#",
                                        subUrls = new Dictionary<string, string>{
                                            { "Blog", "blog.html" },
                                            { "Blog Classic", "blog-classic.html" },
                                            { "Blog Single", "blog-details.html" }
                                        }
                                    },
                                    contact = new {url = "contact-us.html"}
                                }),
                                IsBlazorComponent = true
                            },
                            new WireFrame{
                                Name = "Search Icon",
                                Segment = "eduplan.homekit.topnav.widgets.SearchIcon",
                                Attributes = AsJson(new { targetUrl = "#", iconImageUrl = "_content/Components.Repository/assets/eduplan/img/icon/search-icon.png", iconImageAlt = "Search Icon" }),
                                IsBlazorComponent = true
                            },
                            new WireFrame{
                                Name = "Consultation Button",
                                Segment = "eduplan.homekit.topnav.widgets.ConsultationButton",
                                Attributes = AsJson(new { targetUrl = "#", buttonText = "Free consultation" }),
                                IsBlazorComponent = true
                            }
                        ]
        };
    }
}
