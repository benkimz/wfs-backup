using MilesAhead.Components;

namespace MilesAhead.Web;

public class StepsSection : BaseBuilder
{
    public WireFrame Build()
    {
        WireFrame StepsFrame = new WireFrame
        {
            Name = "Steps Section",
            Segment = "section",
            Attributes = AsJson(new { @class = "destination-section style-01 margin-top-110 instruction" }),
        };

        StepsFrame.Children.AddRange([
            new WireFrame{
                Name = "Container",
                Segment = "div",
                Attributes = AsJson(new { @class = "container custom-container-01" }),
                Children = [
                    new WireFrame{
                        Name = "Row",
                        Segment = "div",
                        Attributes = AsJson(new { @class = "row justify-content-center" }),
                        Children = [
                            new WireFrame{
                                Name = "Column",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "col-lg-12" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Title",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "theme-section-title desktop-center text-center" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Subtitle",
                                                Segment = "span",
                                                Content = "STEPS"
                                            },
                                            new WireFrame{
                                                Name = "Title",
                                                Segment = "h4",
                                                Content = "Steps to Get your Destination"
                                            }
                                        ]
                                    }
                                ]
                            }
                        ]
                    },
                    new WireFrame{
                        Name = "Destination Items Wrap",
                        Segment = "div",
                        Attributes = AsJson(new { @class = "destination-items-wrap" }),
                        Children = [
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "destination-single-item style-02" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = AsJson(new { src = "assets/img/icon/step-01.png", alt = "" })
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = AsJson(new { @class = "name" }),
                                        Content = "Identify course <br> country & collage"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "destination-single-item style-02" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = AsJson(new { src = "assets/img/icon/step-02.png", alt = "" })
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = AsJson(new { @class = "name" }),
                                        Content = "science <br> & professional"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "destination-single-item style-02" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = AsJson(new { src = "assets/img/icon/step-03.png", alt = "" })
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = AsJson(new { @class = "name" }),
                                        Content = "Art, Design & <br> Culture"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "destination-single-item style-02" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = AsJson(new { src = "assets/img/icon/step-04.png", alt = "" })
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = AsJson(new { @class = "name" }),
                                        Content = "Business & <br> Management"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = AsJson(new { @class = "destination-single-item style-02" }),
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = AsJson(new { @class = "thumbnail" }),
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = AsJson(new { src = "assets/img/icon/step-05.png", alt = "" })
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = AsJson(new { @class = "name" }),
                                        Content = "Computer <br> Science & IT"
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ]);

        return StepsFrame;
    }
}