using WireFrames.Core;

namespace MilesAhead.Web;

public class Destinations : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Destinations Area",
            Segment = "eduplan.homekit.DestinationsArea",
            Children = [
                new WireFrame
                {
                    Name = "Plane Animation",
                    Segment = "eduplan.homekit.destinations.widgets.PlaneAnimation",
                    Content = AsJson(new { backgroundImage = "_content/Components.Repository/assets/eduplan/img/shapes/mountant.png", planeImageUrl = "_content/Components.Repository/assets/eduplan/img/shapes/plane.png" }),
                    IsBlazorComponent = true
                },
                new WireFrame
                {
                    Name = "Section Title",
                    Segment = "eduplan.homekit.destinations.widgets.SectionTitle",
                    Content = AsJson(new { title = "Top Destinations", description = "We have quality partners in variety of destinations around the globe." }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Destination Items",
                    Segment = "eduplan.homekit.destinations.widgets.DestinationItems",
                    Content = AsJson(new List<object>{
                        new { name = "Canada", image = "_content/Components.Repository/assets/eduplan/img/sections/destination/canda.png" },
                        new { name = "America", image = "_content/Components.Repository/assets/eduplan/img/sections/destination/usa.png" },
                        new { name = "London", image = "_content/Components.Repository/assets/eduplan/img/sections/destination/australia.png" },
                        new { name = "Spain", image = "_content/Components.Repository/assets/eduplan/img/sections/destination/span.png" },
                        new { name = "French", image = "_content/Components.Repository/assets/eduplan/img/sections/destination/franch.png" },
                        new { name = "Sweden", image = "_content/Components.Repository/assets/eduplan/img/sections/destination/swideen.png" },
                        new { name = "Italy", image = "_content/Components.Repository/assets/eduplan/img/sections/destination/italy.png" }
                    }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Section Button",
                    Segment = "eduplan.homekit.destinations.widgets.SectionButton",
                    Content = AsJson(new { targetUrl = "contact.html", buttonText = "apply online" }),
                    IsBlazorComponent = true
                }
            ],
            IsBlazorComponent = true
        };
    }
}
