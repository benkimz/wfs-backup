using WireFrames.Core;

namespace MilesAhead.Web;

public class HomeRoot : RootBuildHelpers
{
    private PrimeRoot Root { get; set; } = new PrimeRoot { RootName = nameof(HomeRoot) };

    public PrimeRoot Build()
    {
        Root.Name = "Miles Ahead Home Page";
        Root.PageTitle = "Eduplan HTML-5 Template";
        Root.FaviconUrl = "_content/Components.Repository/assets/eduplan/img/favicon.png";
        Root.ExternalStyleSheets.AddRange([
            "_content/Components.Repository/assets/eduplan/css/animate.css",
            "_content/Components.Repository/assets/eduplan/css/bootstrap.min.css",
            "_content/Components.Repository/assets/eduplan/css/magnific-popup.css",
            "_content/Components.Repository/assets/eduplan/css/nice-select.css",
            "_content/Components.Repository/assets/eduplan/css/odometer.css",
            "_content/Components.Repository/assets/eduplan/css/font-awesome.min.css",
            "_content/Components.Repository/assets/eduplan/css/slick.css",
            "_content/Components.Repository/assets/eduplan/css/style.css",
            "_content/Components.Repository/assets/eduplan/css/responsive.css"
        ]);
        Root.BodyScripts.AddRange([
            "_content/Components.Repository/assets/eduplan/js/jquery-3.6.0.min.js",
            "_content/Components.Repository/assets/eduplan/js/bootstrap.min.js",
            "_content/Components.Repository/assets/eduplan/js/jquery.magnific-popup.js",
            "_content/Components.Repository/assets/eduplan/js/wow.min.js",
            "_content/Components.Repository/assets/eduplan/js/jquery.nice-select.js",
            "_content/Components.Repository/assets/eduplan/js/jquery.countdown.min.js",
            "_content/Components.Repository/assets/eduplan/js/odometer.min.js",
            "_content/Components.Repository/assets/eduplan/js/viewport.jquery.js",
            "_content/Components.Repository/assets/eduplan/js/slick.min.js",
            "_content/Components.Repository/assets/eduplan/js/main.js"
        ]);

        WireFrame RootBody = new WireFrame { Name = $"{Root.RootName} Body", Segment = "body" };

        RootBody.Children.AddRange([
            new WireFrame{Name = "Page Preloader", Segment = "eduplan.shared.PreLoader", IsBlazorComponent = true},

            new WireFrame{ Name = "Body Overlay", Segment = "eduplan.shared.BodyOverLay", IsBlazorComponent = true},

            new WireFrame{Name = "Search PopUp", Segment = "eduplan.homekit.SearchPopUp", IsBlazorComponent = true},

            new WireFrame{
                Name = "Body Main",
                Segment = "main",
                Attributes = AsJson(new { @class = "page-wrapper" }),
                Children = [
                     new WireFrame{
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
                            }
                        ]
                    },

                        new WireFrame{Name = "Banner Section", Segment = "eduplan.homekit.BannerSection", IsBlazorComponent = true},

                        new WireFrame{Name = "Features Section", Segment = "eduplan.homekit.FeaturesSection", IsBlazorComponent = true},

                        new WireFrame{Name = "Feedback Section", Segment = "eduplan.homekit.FeedbackSection", IsBlazorComponent = true},

                        new WireFrame{Name = "Destinations Area", Segment = "eduplan.homekit.DestinationsArea", IsBlazorComponent = true},

                        new WireFrame{Name = "About Section", Segment = "eduplan.homekit.AboutSection", IsBlazorComponent = true},

                        new WireFrame{Name = "Banner Section", Segment = "eduplan.homekit.BannerSection", IsBlazorComponent = true},

                        new WireFrame{Name = "Steps Section", Segment = "eduplan.homekit.StepsSection", IsBlazorComponent = true},

                        new WireFrame{Name = "News Section", Segment = "eduplan.homekit.NewsSection", IsBlazorComponent = true},

                        new WireFrame{Name = "Faq Section", Segment = "eduplan.homekit.FaqSection", IsBlazorComponent = true},

                        new WireFrame{Name = "Footer Section", Segment = "eduplan.homekit.FooterSection", IsBlazorComponent = true},
                ]
            },
        ]);

        Root.AddChild(RootBody);

        return Root;
    }
}