using MilesAhead.Components;

namespace MilesAhead.Web;

public class BodyMain
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Body Main: page-wrapper",
            Segment = "main",
            Attributes = [new WireFrameAttribute { Name = "class", Value = "page-wrapper" }],
            Children = [
                new TopNavigationBar().Build(),
                new BannerSection().Build(),

                new FeaturesSection().Build(),
                new FeedBackSection().Build(),
                new DestinationsSection().Build(),
                new AboutSection().Build(),
                new CategorySection().Build(),
                new StepsSection().Build(),
                new NewsSection().Build(),
                new FaqSection().Build(),
                new FooterSection().Build()
            ]
        };
    }
}

