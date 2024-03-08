using WireFrames.Core;

namespace MilesAhead.Web;

public class Footer : RootBuildHelpers
{
    public WireFrame Build()
    {
        return new WireFrame
        {
            Name = "Footer Section",
            Segment = "eduplan.homekit.FooterSection",
            Children = [
                new WireFrame{
                    Name = "Subscribe Widget",
                    Segment = "eduplan.homekit.footer.widgets.SubscribeWidget",
                    Content = AsJson(new {
                        iconImage = "_content/Components.Repository/assets/eduplan/img/icon/newslater.png",
                        title = "Subscribe our newsletter",
                        prompt = "Enter your mail address to get our updates, offer and study abroad related all updates",
                        buttonText = "subscribe",
                        buttonLink = "service-single.html",
                        buttonIcon = "_content/Components.Repository/assets/eduplan/img/icon/bell.png"
                    }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Footer Links",
                    Segment = "eduplan.homekit.footer.widgets.FooterLinks",
                    Content = AsJson(new {
                        footerMenus = new[]{
                            new {
                                menuTitle = "Important Links",
                                @class = "col-lg-3 col-md-6 col-sm-6",
                                links = new []{
                                    new { title = "Terms and conditions", url = "#" },
                                    new { title = "Disclaimer and copyright", url = "#" },
                                    new { title = "Cookie policy", url = "#" },
                                    new { title = "Privacy policy", url = "#" },
                                    new { title = "Equality and diversity", url = "#" },
                                    new { title = "Complaints procedure", url = "#" }
                                }
                            },
                            new {
                                menuTitle = "Site Highlight",
                                @class = "col-lg-2 col-md-6 col-sm-6",
                                links = new []{
                                    new { title = "Student videos", url = "#" },
                                    new { title = "Photo gallery", url = "#" },
                                    new { title = "TSC prospectus", url = "#" },
                                    new { title = "Student newsletter", url = "#" },
                                    new { title = "Student portal", url = "#" }
                                }
                            },
                            new {
                                menuTitle = "Help Center",
                                @class = "col-lg-3 col-md-6 col-sm-6",
                                links = new []{
                                    new { title = "Courses", url = "#" },
                                    new { title = "How to apply for admission", url = "#" },
                                    new { title = "Admission Documents", url = "#" },
                                    new { title = "Frequently asked questions", url = "#" },
                                    new { title = "Student accommodation", url = "#" },
                                    new { title = "Student Jobs", url = "#" }
                                }
                            },
                            new {
                                menuTitle = "Services",
                                @class = "col-lg-2 col-md-6 col-sm-6",
                                links = new []{
                                    new { title = "Counselling", url = "#" },
                                    new { title = "Test Preparation", url = "#" },
                                    new { title = "Admission", url = "#" },
                                    new { title = "Education Loan", url = "#" },
                                    new { title = "Visa Processing", url = "#" }
                                }
                            }
                        },
                        location = new {
                            @class = "col-lg-2 col-md-6 col-sm-6",
                            address = "8502 Preston Rd. Inglewood, Maine Bangladesh",
                            icon = "_content/Components.Repository/assets/eduplan/img/icon/location-02.png",
                            logos = new[]{
                                new { src = "_content/Components.Repository/assets/eduplan/img/icon/edu-award.png", alt = "" },
                                new { src = "_content/Components.Repository/assets/eduplan/img/icon/iso.png", alt = "" }
                            }
                        }
                    }),
                    IsBlazorComponent = true
                },
                new WireFrame{
                    Name = "Copy Right Area",
                    Segment = "eduplan.homekit.footer.widgets.CopyRightArea",
                    Content = AsJson(new {
                        headline = "Eduplan. All rights reserved | Developed By",
                        developer = "Themeim",
                        socials = new Dictionary<string, string>{
                            { "fab fa-facebook-f", "#" },
                            { "fab fa-instagram", "#" },
                            { "fab fa-linkedin-in", "#" }
                        }
                    }),
                    IsBlazorComponent = true
                }
            ],
            IsBlazorComponent = true
        };
    }
}
