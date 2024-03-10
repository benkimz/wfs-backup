using WireFrames.Core;

namespace MilesAhead.Web;

public class HomeRoot : RootBuildHelpers
{
    private PrimeRoot Root { get; set; } = new PrimeRoot
    {
        Name = $"Miles Ahead: {nameof(HomeRoot)}"
    };

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

        WireFrame RootBody = new WireFrame { Name = $"{nameof(HomeRoot)} Body", Segment = "body" };

        RootBody.Children.AddRange([
            new WireFrame{Name = "Page Preloader", Segment = "eduplan.shared.PreLoader", IsBlazorComponent = true},

            new WireFrame{ Name = "Body Overlay", Segment = "eduplan.shared.BodyOverLay", IsBlazorComponent = true},

            new WireFrame{Name = "Search PopUp", Segment = "eduplan.homekit.SearchPopUp", IsBlazorComponent = true},

            new WireFrame{
                Name = "Body Main",
                Segment = "main",
                Attributes = AsJson(new { @class = "page-wrapper" }),
                Children = [
                    new TopNav().Build(),

                    new Banner().Build(),

                    new Features().Build(),

                    new Feedback().Build(),

                    new Destinations().Build(),

                    new About().Build(),

                    new Categories().Build(),

                    new Steps().Build(),

                    new News().Build(),

                    new FAQs().Build(),

                    new Footer().Build()
                ]
            },
        ]);

        Root.AddChild(RootBody);

        return Root;
    }
}