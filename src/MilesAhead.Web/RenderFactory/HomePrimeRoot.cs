using MilesAhead.Components;

namespace MilesAhead.Web;

public class HomePrimeRoot
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

        Root.MetaData = new WireFrame
        {
            Name = "Head Content",
            Segment = "head",
            Children = [
                new WireFrame { Name = "X-UA-Compatible", Segment = "meta", Attributes = [new WireFrameAttribute{
                    Name = "http-equiv",
                    Value = "X-UA-Compatible"
                }, new WireFrameAttribute{
                    Name = "content",
                    Value = "IE=edge"
                }]},
                new WireFrame { Name = "X-UA-Compatible", Segment = "meta", Attributes = [new WireFrameAttribute{
                    Name = "http-equiv",
                    Value = "X-UA-Compatible"
                }, new WireFrameAttribute{
                    Name = "content",
                    Value = "ie=edge"
                }]},
                new WireFrame { Name = "title", Segment = "title", Data = new RenderData{
                    FallbackRenderData = [
                        new RenderDataItem { Name = "Title", Value = "Eduplan HTML-5 Template" }
                    ]
                }},
                new WireFrame { Name = "favicon", Segment = "link", Attributes = [
                    new WireFrameAttribute{
                    Name = "rel",
                    Value = "icon"
                }, new WireFrameAttribute{
                    Name = "href",
                    Value = "assets/img/favicon.png"
                }, new WireFrameAttribute{
                    Name = "sizes",
                    Value = "20x20"
                }, new WireFrameAttribute{
                    Name = "type",
                    Value = "image/png"
                }]}
            ]
        };

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
                Attributes = [new WireFrameAttribute { Name = "class", Value = "back-to-top" }],
                Children = [
                    new WireFrame
                    {
                        Name = "Back Top",
                        Segment = "span",
                        Attributes = [new WireFrameAttribute { Name = "class", Value = "back-top" }],
                        Children = [
                            new WireFrame
                            {
                                Name = "Angle Up",
                                Segment = "i",
                                Attributes = [new WireFrameAttribute { Name = "class", Value = "fa fa-angle-up" }]
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