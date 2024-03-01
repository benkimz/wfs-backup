using MilesAhead.WireFrames.Core;

namespace MilesAhead.Web;

public class HomePrimeRoot : BaseBuilder
{
    private PrimeRoot Root { get; set; } = new PrimeRoot { RootName = nameof(HomePrimeRoot) };
    public PrimeRoot Build()
    {
        Root.ExternalStyleSheets.AddRange([
            "assets/css/animate.css",
            "assets/css/bootstrap.min.css",
            "assets/css/magnific-popup.css",
            "assets/css/nice-select.css",
            "assets/css/odometer.css",
            "assets/css/font-awesome.min.css",
            "assets/css/slick.css",
            "assets/css/style.css",
            "assets/css/responsive.css"
        ]);

        Root.BodyScripts.AddRange([
            "assets/js/jquery-3.6.0.min.js",
            "assets/js/bootstrap.min.js",
            "assets/js/jquery.magnific-popup.js",
            "assets/js/wow.min.js",
            "assets/js/jquery.nice-select.js",
            "assets/js/jquery.countdown.min.js",
            "assets/js/odometer.min.js",
            "assets/js/viewport.jquery.js",
            "assets/js/slick.min.js",
            "assets/js/main.js"
        ]);

        Root.PageTitle = "Eduplan HTML-5 Template";
        Root.FaviconUrl = "assets/img/favicon.png";

        WireFrame RootBody = new WireFrame { Name = $"{Root.RootName} Body", Segment = "body" };

        RootBody.Children.AddRange([
            new PagePreloader().Build(),
            new BodyOverLay().Build(),
            new SearchPopUp().Build(),
            new BodyMain().Build(),
            new WireFrame
            {
                Name = "Back to Top",
                Segment = "div",
                Attributes = AsJson(new {@class = "back-to-top"}),
                Children = [
                    new WireFrame
                    {
                        Name = "Back Top",
                        Segment = "span",
                        Attributes = AsJson(new {@class = "back-to-top"}),
                        Children = [
                            new WireFrame
                            {
                                Name = "Angle Up",
                                Segment = "i",
                                Attributes = AsJson(new {@class = "fa fa-angle-up"})
                            }
                        ]
                    }
                ]
            }
        ]);

        Root.AddChild(RootBody);

        return Root;
    }

}