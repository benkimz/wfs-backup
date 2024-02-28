using MilesAhead.Components;

namespace MilesAhead.Web;

public class StepsSection
{
    public WireFrame Build()
    {
        WireFrame StepsFrame = new WireFrame
        {
            Name = "Steps Section",
            Segment = "section",
            Attributes = [
                new WireFrameAttribute{
                    Name = "class",
                    Value = "destination-section style-01 margin-top-110 instruction"
                }
            ],
        };

        StepsFrame.Children.AddRange([
            new WireFrame{
                Name = "Container",
                Segment = "div",
                Attributes = [
                    new WireFrameAttribute{
                        Name = "class",
                        Value = "container custom-container-01"
                    }
                ],
                Children = [
                    new WireFrame{
                        Name = "Row",
                        Segment = "div",
                        Attributes = [
                            new WireFrameAttribute{
                                Name = "class",
                                Value = "row justify-content-center"
                            }
                        ],
                        Children = [
                            new WireFrame{
                                Name = "Column",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "col-lg-12"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Title",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "theme-section-title desktop-center text-center"
                                            }
                                        ],
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
                        Attributes = [
                            new WireFrameAttribute{
                                Name = "class",
                                Value = "destination-items-wrap"
                            }
                        ],
                        Children = [
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "destination-single-item style-02"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "thumbnail"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "src",
                                                        Value = "assets/img/icon/step-01.png"
                                                    },
                                                    new WireFrameAttribute{
                                                        Name = "alt",
                                                        Value = ""
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "name"
                                            }
                                        ],
                                        Content = "Identify course <br> country & collage"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "destination-single-item style-02"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "thumbnail"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "src",
                                                        Value = "assets/img/icon/step-02.png"
                                                    },
                                                    new WireFrameAttribute{
                                                        Name = "alt",
                                                        Value = ""
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "name"
                                            }
                                        ],
                                        Content = "science <br> & professional"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "destination-single-item style-02"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "thumbnail"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "src",
                                                        Value = "assets/img/icon/step-03.png"
                                                    },
                                                    new WireFrameAttribute{
                                                        Name = "alt",
                                                        Value = ""
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "name"
                                            }
                                        ],
                                        Content = "Art, Design & <br> Culture"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "destination-single-item style-02"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "thumbnail"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "src",
                                                        Value = "assets/img/icon/step-04.png"
                                                    },
                                                    new WireFrameAttribute{
                                                        Name = "alt",
                                                        Value = ""
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "name"
                                            }
                                        ],
                                        Content = "Business & <br> Management"
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Destination Single Item",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "destination-single-item style-02"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Thumbnail",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "thumbnail"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Image",
                                                Segment = "img",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "src",
                                                        Value = "assets/img/icon/step-05.png"
                                                    },
                                                    new WireFrameAttribute{
                                                        Name = "alt",
                                                        Value = ""
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Name",
                                        Segment = "h6",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "name"
                                            }
                                        ],
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