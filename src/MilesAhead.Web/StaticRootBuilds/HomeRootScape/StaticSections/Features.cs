using WireFrames.Core;

namespace MilesAhead.Web;

public class Features : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Features Section",
            Segment = "eduplan.homekit.FeaturesSection",
            Children = [
                            new WireFrame{
                                Name = "Features Icon Box Items",
                                Segment = "eduplan.homekit.features.widgets.IconBoxItems",
                                Content = AsJson(new List<object>{
                                    new {
                                        icon = new {
                                            iconImageSrc = "_content/Components.Repository/assets/eduplan/img/icon/idea.png",
                                            iconImageAlt = "One Stop Study Solution",
                                        },
                                        content = new {
                                            title = "One Stop Study Solution",
                                            description = "Get a full view so you know where to save. Track spending, deta keep tab subscription lorem ipsum text"
                                        },
                                        moreButton = new {
                                            targetUrl = "#0",
                                            buttonText = "Learn More <i class=\"fa-solid fa-angle-right icon\"></i>",
                                        }
                                    },
                                    new {
                                        icon = new {
                                            iconImageSrc = "_content/Components.Repository/assets/eduplan/img/icon/coversation.png",
                                            iconImageAlt = "One To One Discussion",
                                        },
                                        content = new {
                                            title = "One To One Discussion",
                                            description = "Get a full view so you know where to save. Track spending, deta keep tab subscription lorem ipsum text"
                                        },
                                        moreButton = new {
                                            targetUrl = "#0",
                                            buttonText = "Learn More <i class=\"fa-solid fa-angle-right icon\"></i>",
                                        }
                                    },
                                    new {
                                        icon = new {
                                            iconImageSrc = "_content/Components.Repository/assets/eduplan/img/icon/emergency.png",
                                            iconImageAlt = "End To End Support",
                                        },
                                        content = new {
                                            title = "End To End Support",
                                            description = "Get a full view so you know where to save. Track spending, deta keep tab subscription lorem ipsum text"
                                        },
                                        moreButton = new {
                                            targetUrl = "#0",
                                            buttonText = "Learn More <i class=\"fa-solid fa-angle-right icon\"></i>",
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
