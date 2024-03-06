using WireFrames.Core;

namespace MilesAhead.Web;

public class Banner : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Banner Section",
            Segment = "eduplan.homekit.BannerSection",
            Children = [
                            new WireFrame{
                                Name = "Banner Text",
                                Segment = "eduplan.homekit.banner.widgets.BannerText",
                                Attributes = AsJson(new { title = "Your <span>success</span> journey start with us!", subtitle = "SPECIAL OFFER FIRST CUSTOMER", text = "Eduplan Education Can Fulfil Your International Education Dream <br> As Per Your Best Fit with world top universities and collages." }),
                                IsBlazorComponent = true
                            },
                            new WireFrame{
                                Name = "Banner Buttons",
                                Segment = "eduplan.homekit.banner.widgets.BannerButtons",
                                Attributes = AsJson(new Dictionary<string, string>{
                                    {"apply online", "#0"},
                                    {"Discover", "contact.html"}
                                 }),
                                IsBlazorComponent = true
                            },
                            new WireFrame{
                                Name="Banner Thumbnail",
                                Segment = "eduplan.homekit.banner.widgets.BannerThumbnail",
                                Attributes = AsJson(new List<object>{
                                    new {@class = "element-01", src = "_content/Components.Repository/assets/eduplan/img/shapes/Ellipse-01.png", alt = "Ellipse"},
                                    new {@class = "element-02", src = "_content/Components.Repository/assets/eduplan/img/shapes/Ellipse-02.png", alt = "Ellipse"},
                                    new {@class = "element-03", src = "_content/Components.Repository/assets/eduplan/img/shapes/Vector-15.png", alt = "vector"},
                                    new {@class = "element-04", src = "_content/Components.Repository/assets/eduplan/img/header/plane.png", alt = "plane"},
                                    new {@class = "element-05", src = "_content/Components.Repository/assets/eduplan/img/icon/location.png", alt = "location"},
                                    new {@class = "banner-img", src = "_content/Components.Repository/assets/eduplan/img/header/header-img.png", alt = "Student"}
                                }),
                                IsBlazorComponent = true
                            }
                        ],
            IsBlazorComponent = true
        };
    }
}
