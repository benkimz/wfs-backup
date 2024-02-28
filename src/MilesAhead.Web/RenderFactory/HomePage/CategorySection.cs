﻿using MilesAhead.Components;

namespace MilesAhead.Web;

public class CategorySection
{
    public WireFrame Build()
    {
        WireFrame CategoryFrame = new WireFrame
        {
            Name = "Category Section",
            Segment = "section",
            Attributes = [
                new WireFrameAttribute{
                    Name = "class",
                    Value = "category-section-area"
                }
            ],
        };

        CategoryFrame.Children.AddRange([
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
                                        Value = "col-lg-12"
                                    }
                                ],
                                Children = [
                                    new WireFrame{
                                        Name = "Section Title Wrapper",
                                        Segment = "div",
                                        Attributes = [
                                            new WireFrameAttribute{
                                                Name = "class",
                                                Value = "section-title-wrapper d-flex justify-content-between"
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
                                                        Content = "CATEGORIES"
                                                    },
                                                    new WireFrame{
                                                        Name = "Title",
                                                        Segment = "h4",
                                                        Content = "Popular Discipline & Collage"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Nav",
                                                Segment = "ul",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "nav nav-pills"
                                                    }
                                                ],
                                                Children = [
                                                    new WireFrame{
                                                        Name = "Nav Item",
                                                        Segment = "li",
                                                        Attributes = [
                                                            new WireFrameAttribute{
                                                                Name = "class",
                                                                Value = "nav-item"
                                                            }
                                                        ],
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Nav Link",
                                                                Segment = "a",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "href",
                                                                        Value = "#"
                                                                    },
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "nav-link active"
                                                                    },
                                                                    new WireFrameAttribute{
                                                                        Name = "data-bs-toggle",
                                                                        Value = "pill"
                                                                    },
                                                                    new WireFrameAttribute{
                                                                        Name = "data-bs-target",
                                                                        Value = "#discipline"
                                                                    }
                                                                ],
                                                                Content = "Discipline"
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame{
                                                        Name = "Nav Item",
                                                        Segment = "li",
                                                        Attributes = [
                                                            new WireFrameAttribute{
                                                                Name = "class",
                                                                Value = "nav-item"
                                                            }
                                                        ],
                                                        Children = [
                                                            new WireFrame{
                                                                Name = "Nav Link",
                                                                Segment = "a",
                                                                Attributes = [
                                                                    new WireFrameAttribute{
                                                                        Name = "href",
                                                                        Value = "#"
                                                                    },
                                                                    new WireFrameAttribute{
                                                                        Name = "class",
                                                                        Value = "nav-link"
                                                                    },
                                                                    new WireFrameAttribute{
                                                                        Name = "data-bs-toggle",
                                                                        Value = "pill"
                                                                    },
                                                                    new WireFrameAttribute{
                                                                        Name = "data-bs-target",
                                                                        Value = "#collage"
                                                                    }
                                                                ],
                                                                Content = "Collage"
                                                            }
                                                        ]
                                                    }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            }
                        ]
                    },
                    new WireFrame{
                        Name = "Tab Content",
                        Segment = "div",
                        Attributes = [
                            new WireFrameAttribute{
                                Name = "class",
                                Value = "tab-content"
                            }
                        ],
                        Children = [
                            new WireFrame{
                                Name = "Tab Pane",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "tab-pane fade show active"
                                    },
                                    new WireFrameAttribute{
                                        Name = "id",
                                        Value = "discipline"
                                    }
                                ],
                                Children = [
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
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/foresty.png"
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
                                                        Content = "Agriculture & Foresty"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/science.png"
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
                                                        Content = "Science & Professional"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/art.png"
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
                                                        Content = "Art, Design & Culture"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/business.png"
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
                                                        Content = "Business & Management"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/pc.png"
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
                                                        Content = "Computer Science & IT"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/book.png"
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
                                                        Content = "Education & Training"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/click.png"
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
                                                        Content = "Engeneering & Technology"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/french-fry.png"
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
                                                        Content = "Hopitality & Sports"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/news-paper.png"
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
                                                        Content = "Journalism & Media"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/first-aid-kit.png"
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
                                                        Content = "Medicine & Health"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/law.png"
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
                                                        Content = "Law"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/enverment.png"
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
                                                        Content = "Social Science"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/humanity.png"
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
                                                        Content = "Humanities"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/recicle.png"
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
                                                        Content = "Enviromental Studies"
                                                    }
                                                ]
                                            }
                                        ]
                                    }
                                ]
                            },
                            new WireFrame{
                                Name = "Tab Pane",
                                Segment = "div",
                                Attributes = [
                                    new WireFrameAttribute{
                                        Name = "class",
                                        Value = "tab-pane fade"
                                    },
                                    new WireFrameAttribute{
                                        Name = "id",
                                        Value = "collage"
                                    }
                                ],
                                Children = [
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
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/french-fry.png"
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
                                                        Content = "Hopitality & Sports"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/news-paper.png"
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
                                                        Content = "Journalism & Media"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/first-aid-kit.png"
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
                                                        Content = "Medicine & Health"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/law.png"
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
                                                        Content = "Law"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/enverment.png"
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
                                                        Content = "Social Science"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/humanity.png"
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
                                                        Content = "Humanities"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/recicle.png"
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
                                                        Content = "Enviromental Studies"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/foresty.png"
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
                                                        Content = "Agriculture & Foresty"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/science.png"
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
                                                        Content = "Science & Professional"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/art.png"
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
                                                        Content = "Art, Design & Culture"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/business.png"
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
                                                        Content = "Business & Management"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
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
                                                                        Value = "assets/img/sections/desipline/pc.png"
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
                                                        Content = "Computer Science & IT"
                                                    }
                                                ]
                                            },
                                            new WireFrame{
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute{
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
                                                    }
                                                ],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = [
                                                            new WireFrameAttribute
                                                            {
                                                                Name = "class",
                                                                Value = "thumbnail"
                                                            }
                                                        ],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = [
                                                                    new WireFrameAttribute
                                                                    {
                                                                        Name = "src",
                                                                        Value = "assets/img/sections/desipline/book.png"
                                                                    },
                                                                    new WireFrameAttribute
                                                                    {
                                                                        Name = "alt",
                                                                        Value = ""
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = [
                                                            new WireFrameAttribute
                                                            {
                                                                Name = "class",
                                                                Value = "name"
                                                            }
                                                        ],
                                                        Content = "Education & Training"
                                                    }
                                                ]
                                            },
                                            new WireFrame
                                            {
                                                Name = "Destination Single Item",
                                                Segment = "div",
                                                Attributes = [
                                                    new WireFrameAttribute
                                                    {
                                                        Name = "class",
                                                        Value = "destination-single-item style-01"
                                                    }
                                                ],
                                                Children = [
                                                    new WireFrame
                                                    {
                                                        Name = "Thumbnail",
                                                        Segment = "div",
                                                        Attributes = [
                                                            new WireFrameAttribute
                                                            {
                                                                Name = "class",
                                                                Value = "thumbnail"
                                                            }
                                                        ],
                                                        Children = [
                                                            new WireFrame
                                                            {
                                                                Name = "Image",
                                                                Segment = "img",
                                                                Attributes = [
                                                                    new WireFrameAttribute
                                                                    {
                                                                        Name = "src",
                                                                        Value = "assets/img/sections/desipline/click.png"
                                                                    },
                                                                    new WireFrameAttribute
                                                                    {
                                                                        Name = "alt",
                                                                        Value = ""
                                                                    }
                                                                ]
                                                            }
                                                        ]
                                                    },
                                                    new WireFrame
                                                    {
                                                        Name = "Name",
                                                        Segment = "h6",
                                                        Attributes = [
                                                            new WireFrameAttribute
                                                            {
                                                                Name = "class",
                                                                Value = "name"
                                                            }
                                                        ],
                                                        Content = "Engeneering & Technology"
                                                    }
                                                ]
                                            },
                                        ]
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ]);

        return CategoryFrame;
    }
}