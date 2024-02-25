using MilesAhead.Components;

namespace MilesAhead.Web;

public class AboutSection
{
    public WireFrame Build()
    {
        WireFrame AboutFrame = new WireFrame
        {
            Name = "About Section",
            Segment = "section",
            Attributes = [
                new WireFrameAttribute{
                    Name = "class",
                    Value = "about-section-area section-top-space about-home-02"
                }
            ],
        };

        AboutFrame.Children.AddRange([
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
                                Value = "row"
                            }
                        ],
                        Children = [
                            new WireFrame{
                                Name = "Column",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "col-lg-6 col-md-12"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Theme Section Title",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "theme-section-title"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Subtitle",
                                                Segment = "span",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "subtitle"
                                                    }
                                                ],
                                                Data = new RenderData{
                                                    FallbackRenderData = [
                                                        new RenderDataItem{
                                                            Name = "text",
                                                            Value = "ABOUT US & EXPERIENCE"
                                                        }
                                                    ]
                                                }
                                            },
                                            new WireFrame{
                                                Name = "Title",
                                                Segment = "h4",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "title"
                                                    }
                                                ],
                                                Data = new RenderData{
                                                    FallbackRenderData = [
                                                        new RenderDataItem{
                                                            Name = "text",
                                                            Value = "Moving beyond product innovation to gain a competitive advantage"
                                                        }
                                                    ]
                                                }
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "About Content Wrap",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "about-content-wrap"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Paragraph",
                                                Segment = "p",
                                                Data = new RenderData{
                                                    FallbackRenderData = [
                                                        new RenderDataItem{
                                                            Name = "text",
                                                            Value = "Ouya Education, which is based in Victoria, British Columbia, Canada, frequently deals with issues of employment (recruitment and retention) for temporary foreign workers (TFW), as well as temporary and permanent residency applications and other general immigration matters with Canadian federal departments (IRCC and CBSA)."
                                                        }
                                                    ]
                                                }
                                            },
                                            new WireFrame{
                                                Name = "Paragraph",
                                                Segment = "p",
                                                Data = new RenderData{
                                                    FallbackRenderData = [
                                                        new RenderDataItem{
                                                            Name = "text",
                                                            Value = "Education also provides educational consulting services for student- clients who want to study in Canada, and require help with the application process."
                                                        }
                                                    ]
                                                }
                                            },
                                            new WireFrame{
                                                Name = "Core Strength",
                                                Segment = "span",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "core"
                                                    }
                                                ]
                                            }
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Counter Section",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "counter-section-inner style-a"
                                            }
                                        ],
                                        Children = [
                                            // start single-counterup color-01
                                            new WireFrame{
                                                Name = "Single Counterup",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "single-counterup color-01"
                                                    }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Content Wrap",
                                                        Segment = "div",
                                                        Attributes = [
                                                            new WireFrameAttribute{
                                                                Name = "class",
                                                                Value = "content-wrap"
                                                            }
                                                        ],
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Odo Area",
                                                                Segment = "div",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "odo-area"
                                                                    }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Odometer",
                                                                        Segment = "h3",
                                                                        Attributes = [
                                                                            new WireFrameAttribute{
                                                                                Name = "class",
                                                                                Value = "odometer odo-title"
                                                                            },
                                                                            new WireFrameAttribute{
                                                                                Name = "data-odometer-final",
                                                                                Value = "15"
                                                                            }
                                                                        ],
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem{
                                                                                    Name = "text",
                                                                                    Value = "0"
                                                                                }
                                                                            ]
                                                                        }
                                                                    },
                                                                ]
                                                            },
                                                            new WireFrame{
                                                                Name = "Content",
                                                                Segment = "div",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "content"
                                                                    }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Subtitle",
                                                                        Segment = "h6",
                                                                        Attributes = [
                                                                            new WireFrameAttribute{
                                                                                Name = "class",
                                                                                Value = "subtitle"
                                                                            }
                                                                        ],
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem{
                                                                                    Name = "text",
                                                                                    Value = "Years Experience"
                                                                                }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }, 
                                            // end single-counterup color-01

                                            // start single-counterup color-02
                                            new WireFrame{
                                                Name = "Single Counterup",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "single-counterup color-02"
                                                    }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Content Wrap",
                                                        Segment = "div",
                                                        Attributes = [
                                                            new WireFrameAttribute{
                                                                Name = "class",
                                                                Value = "content-wrap"
                                                            }
                                                        ],
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Odo Area",
                                                                Segment = "div",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "odo-area"
                                                                    }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Odometer",
                                                                        Segment = "h3",
                                                                        Attributes = [
                                                                            new WireFrameAttribute{
                                                                                Name = "class",
                                                                                Value = "odometer odo-title style-01"
                                                                            },
                                                                            new WireFrameAttribute{
                                                                                Name = "data-odometer-final",
                                                                                Value = "875"
                                                                            }
                                                                        ],
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem{
                                                                                    Name = "text",
                                                                                    Value = "0"
                                                                                }
                                                                            ]
                                                                        }
                                                                    },
                                                                ]
                                                            },
                                                            new WireFrame{
                                                                Name = "Content",
                                                                Segment = "div",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "content"
                                                                    }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Subtitle",
                                                                        Segment = "h6",
                                                                        Attributes = [
                                                                            new WireFrameAttribute{
                                                                                Name = "class",
                                                                                Value = "subtitle"
                                                                            },
                                                                        ],
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem{
                                                                                    Name = "text",
                                                                                    Value = "VISAs Approved"
                                                                                }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }, 
                                            // end single-counterup color-02
                                            
                                            // start single-counterup color-03
                                                                                        new WireFrame{
                                                Name = "Single Counterup",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "single-counterup color-02"
                                                    }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Content Wrap",
                                                        Segment = "div",
                                                        Attributes = [
                                                            new WireFrameAttribute{
                                                                Name = "class",
                                                                Value = "content-wrap"
                                                            }
                                                        ],
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Odo Area",
                                                                Segment = "div",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "odo-area"
                                                                    }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Odometer",
                                                                        Segment = "h3",
                                                                        Attributes = [
                                                                            new WireFrameAttribute{
                                                                                Name = "class",
                                                                                Value = "odometer odo-title style-02"
                                                                            },
                                                                            new WireFrameAttribute{
                                                                                Name = "data-odometer-final",
                                                                                Value = "96"
                                                                            }
                                                                        ],
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem{
                                                                                    Name = "text",
                                                                                    Value = "0"
                                                                                }
                                                                            ]
                                                                        }
                                                                    },
                                                                    new WireFrame{
                                                                        Name = "Title",
                                                                        Segment = "h3",
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem{
                                                                                    Name = "text",
                                                                                    Value = "%"
                                                                                }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            },
                                                            new WireFrame{
                                                                Name = "Content",
                                                                Segment = "div",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "content"
                                                                    }
                                                                ],
                                                                Children = [
                                                                    new WireFrame{
                                                                        Name = "Subtitle",
                                                                        Segment = "h6",
                                                                        Attributes = [
                                                                            new WireFrameAttribute{
                                                                                Name = "class",
                                                                                Value = "subtitle"
                                                                            },
                                                                        ],
                                                                        Data = new RenderData{
                                                                            FallbackRenderData = [
                                                                                new RenderDataItem{
                                                                                    Name = "text",
                                                                                    Value = "Admission success"
                                                                                }
                                                                            ]
                                                                        }
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }, 
                                            // end single-counterup color-03
                                        ]
                                    },
                                    new WireFrame{
                                        Name = "Button Wrap",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "btn-wrap"
                                            }
                                        ],
                                        Children = [
                                            new WireFrame{
                                                Name = "Button",
                                                Segment = "a",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "href",
                                                        Value = "#"
                                                    },
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "btn-common fill-btn"
                                                    }
                                                ],
                                                Data = new RenderData{
                                                    FallbackRenderData = [
                                                        new RenderDataItem{
                                                            Name = "text",
                                                            Value = "Get Free Consultation"
                                                        }
                                                    ]
                                                }
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Column",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "col-lg-6 col-md-12"
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
                                                        Value = "assets/img/sections/about/student-in-library.png"
                                                    },
                                                    new WireFrameAttribute{
                                                        Name = "alt",
                                                        Value = ""
                                                    }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            }
                            //
                        ]
                    }
                ]
            }
        ]);

        return AboutFrame;
    }
}
