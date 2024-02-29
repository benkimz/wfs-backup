using MilesAhead.Components;

namespace MilesAhead.Web;

public class BodyMain : BaseBuilder
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Body Main: page-wrapper",
            Segment = "main",
            Attributes = AsJson(new { @class = "page-wrapper" }),
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

