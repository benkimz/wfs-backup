using MilesAhead.Components;

namespace MilesAhead.Web;

public class DestinationsSection
{
    public WireFrame Build()
    {
        WireFrame DestinationsFrame = new WireFrame
        {
            Name = "Destinations Section",
            Segment = "section",
            Attributes = [
                new WireFrameAttribute { Name = "class", Value = "margin-top-110 section-bottom-space" }
            ],
        };

        DestinationsFrame.Children.AddRange([
            new WireFrame
            {
                Name = "Destination Section",
                Segment = "div",
                Attributes = [
                    new WireFrameAttribute { Name = "class", Value = "destination-section" }
                ],
                Children = [
                    new WireFrame
                    {
                        Name = "Mountant",
                        Segment = "img",
                        Attributes = [
                            new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/mountant.png" },
                            new WireFrameAttribute { Name = "class", Value = "shape-01 wow animate__animated animate__delay-1s animate__fadeInUp" },
                            new WireFrameAttribute { Name = "alt", Value = "mountant" }
                        ]
                    },
                    new WireFrame
                    {
                        Name = "Plane Wrap",
                        Segment = "div",
                        Attributes = [
                            new WireFrameAttribute { Name = "class", Value = "plane-wrap" }
                        ],
                        Children = [
                            new WireFrame
                            {
                                Name = "Plane",
                                Segment = "img",
                                Attributes = [
                                    new WireFrameAttribute { Name = "src", Value = "assets/img/shapes/plane.png" },
                                    new WireFrameAttribute { Name = "class", Value = "shape-02" },
                                    new WireFrameAttribute { Name = "alt", Value = "mountant" }
                                ]
                            }
                        ]
                    },
                    new WireFrame
                    {
                        Name = "Container",
                        Segment = "div",
                        Attributes = [
                            new WireFrameAttribute { Name = "class", Value = "container custom-container-01" }
                        ],
                        Children = [
                            new WireFrame
                            {
                                Name = "Row",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "row justify-content-center" }
                                ],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "Column",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "col-lg-6" }
                                        ],
                                        Children = [
                                            new WireFrame
                                            {
                                                Name = "Theme Section Title",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "theme-section-title desktop-center text-center" }
                                                ],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "Title",
                                                        Segment = "h4",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "class", Value = "title" }
                                                        ],
                                                        Data = new RenderData {FallbackRenderData = [
                                                            new RenderDataItem{Name="text", Value="Top Destinations"}
                                                        ]
                                                        }

                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "Paragraph",
                                                        Segment = "p",
                                                        Data = new RenderData {FallbackRenderData = [
                                                            new RenderDataItem{Name="text", Value="We have quality partners in variety of destinations around the globe."}
                                                        ]
                                                        }
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
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "destination-items-wrap" }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "destination-single-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "thumbnail" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "src", Value = "assets/img/sections/destination/canda.png" },
                                                            new WireFrameAttribute { Name = "alt", Value = "" }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Data = new RenderData {FallbackRenderData = [
                                                    new RenderDataItem{Name="text", Value="Canada"}
                                                ]
                                                }
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "destination-single-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "thumbnail" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "src", Value = "assets/img/sections/destination/usa.png" },
                                                            new WireFrameAttribute { Name = "alt", Value = "" }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Data = new RenderData {FallbackRenderData = [
                                                    new RenderDataItem{Name="text", Value="America"}
                                                ]
                                                }
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "destination-single-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "thumbnail" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name = "src", Value = "assets/img/sections/destination/australia.png" },
                                                            new WireFrameAttribute { Name = "alt", Value = "" }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Data = new RenderData {FallbackRenderData = [
                                                    new RenderDataItem{Name="text", Value="London"}
                                                ]
                                                }
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "destination-single-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "thumbnail" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name="src",  Value = "assets/img/sections/destination/span.png" },
                                                            new WireFrameAttribute { Name="alt",Value = "" }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Data = new RenderData {FallbackRenderData = [
                                                    new RenderDataItem{Name="text", Value="Spain"}
                                                ]
                                                }
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "destination-single-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "thumbnail" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name="src",  Value = "assets/img/sections/destination/franch.png" },
                                                            new WireFrameAttribute { Name="alt",Value = "" }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Data = new RenderData {FallbackRenderData = [
                                                    new RenderDataItem{Name="text", Value="French"}
                                                ]
                                                }
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "destination-single-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "thumbnail" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name="src",  Value = "assets/img/sections/destination/swideen.png" },
                                                            new WireFrameAttribute { Name="alt",Value = "" }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Data = new RenderData {FallbackRenderData = [
                                                    new RenderDataItem{Name="text", Value="Sweden"}
                                                ]
                                                }
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Destination Single Item",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "class", Value = "destination-single-item" }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Thumbnail",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute { Name = "class", Value = "thumbnail" }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Image",
                                                        Segment = "img",
                                                        Attributes = [
                                                            new WireFrameAttribute { Name="src",  Value = "assets/img/sections/destination/italy.png" },
                                                            new WireFrameAttribute { Name="alt",Value = "" }
                                                        ]
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Name",
                                                Segment = "h6",
                                                Data = new RenderData {FallbackRenderData = [
                                                    new RenderDataItem{Name="text", Value="Italy"}
                                                ]
                                                }
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame
                            {
                                Name = "Button Wrap",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute { Name = "class", Value = "btn-wrap desktop-center margin-top-40 text-center" }
                                ],
                                Children = [
                                    new WireFrame
                                    {
                                        Name = "Button",
                                        Segment = "a",
                                        Attributes = [
                                            new WireFrameAttribute { Name = "href", Value = "contact.html" },
                                            new WireFrameAttribute { Name = "class", Value = "btn-common fill-btn style-01" }
                                        ],
                                        Data = new RenderData {FallbackRenderData = [
                                            new RenderDataItem{Name="text", Value="apply online"}
                                        ]
                                        }
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ]);

        return DestinationsFrame;
    }
}
