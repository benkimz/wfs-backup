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
                new TopNavigationBar().Build(), // navigation bar
                new BannerSection().Build(), // banner section
                // not 100% approved by me: ~ benkimz
                new FeaturesSection().Build(), // features section
                new FeedBackSection().Build(), // feedback section
                new DestinationsSection().Build(), // destinations section
                new AboutSection().Build(), // about section
                new CategorySection().Build(), // category section
                new StepsSection().Build(), // steps section
                new NewsSection().Build(), // news section
            ]
        };
    }
}

/* body main section
---------------------------------------------------------
    <main class="page-wrapper">
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Faq Section Area Start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <section class="faq-section-area margin-top-90">
            <div class="container custom-container-01">
                <div class="row">
                    <div class="col-lg-6">
                        <div class="theme-section-title">
                            <span class="subtitle">FAQ</span>
                            <h4 class="title">Frequently asked question</h4>
                        </div>
                        <div class="faq-content">
                            <h6 class="subtitle">Still do you have any questions to know? <br> Feel free to ask our
                                experts here.</h6>
                            <div class="btn-wrap">
                                <a href="#0" class="btn-common flat-btn">ASK YOUR QUESTIONS</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="accordion-wrapper">
                            <!-- accordion wrapper -->
                            <div id="accordionOne">
                                <div class="card">
                                    <div class="card-header" id="headingOne">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseOne" aria-expanded="false"
                                                aria-controls="collapseOne">
                                                1. How is get admission in abroad university?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseOne" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingTwo">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseTwo" aria-expanded="false"
                                                aria-controls="collapseTwo">
                                                2. Do you offer complete solution for students?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseTwo" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingThree">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseThree" aria-expanded="false"
                                                aria-controls="collapseThree">
                                                3. Which country is safe and better for higher study?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseThree" class="collapse show" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingFour">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseFour" aria-expanded="false"
                                                aria-controls="collapseFour">
                                                4. Which country offer PR after study getting job?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseFour" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingFive">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseFive" aria-expanded="false"
                                                aria-controls="collapseFive">
                                                5. Can i get scholarship with my low cGPA?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseFive" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                                <div class="card">
                                    <div class="card-header" id="headingSix">
                                        <h5 class="mb-0">
                                            <a class="collapsed" role="button" data-bs-toggle="collapse"
                                                data-bs-target="#collapseSix" aria-expanded="false"
                                                aria-controls="collapseSix">
                                                6. Do you allow accomadation for students in abroad?
                                            </a>
                                        </h5>
                                    </div>
                                    <div id="collapseSix" class="collapse" data-bs-parent="#accordionOne">
                                        <div class="card-body">
                                            Norway, USA, UK, Germany & Italy is most safest country in the world for
                                            Bangladeshi students for higer study.
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Faq Section Area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->

        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            footer area start Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
        <footer class="footer-area style-01">
            <div class="footer-top">
                <div class="container custom-container-01">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <div class="footer-widget widget widget_subscribe">
                                <div class="subscibe-wrapper">
                                    <div class="content-wrap">
                                        <div class="icon">
                                            <img src="assets/img/icon/newslater.png" alt="">
                                        </div>
                                        <div class="content">
                                            <h4 class="title">Subscribe our newsletter</h4>
                                            <p>Enter your mail address to get our updates, offer and study abroad
                                                related all updates</p>
                                        </div>

                                    </div>
                                    <div class="subscribe-form">
                                        <div class="form-group">
                                            <input type="text" name="fname" placeholder="Enter your Email..."
                                                class="form-control" required="" aria-required="true">
                                            <div class="btn-wrap">
                                                <a href="service-single.html" class="subscribe-btn">
                                                    <img src="assets/img/icon/bell.png" alt="">subscribe</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="footer-middle">
                        <div class="row">
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Important Links</h4>
                                    <ul>
                                        <li><a href="#">Terms and conditions</a></li>
                                        <li><a href="#">Disclaimer and copyright</a></li>
                                        <li><a href="#">Cookie policy</a></li>
                                        <li><a href="#">Privacy policy</a></li>
                                        <li><a href="#">Equality and diversity</a></li>
                                        <li><a href="#">Complaints procedure</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Site Highlight</h4>
                                    <ul>
                                        <li><a href="#">Student videos</a></li>
                                        <li><a href="#">Photo gallery</a></li>
                                        <li><a href="#">TSC prospectus</a></li>
                                        <li><a href="#">Student newsletter</a></li>
                                        <li><a href="#">Student portal</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Help Center</h4>
                                    <ul>
                                        <li><a href="#">Courses</a></li>
                                        <li><a href="#">How to apply for admission</a></li>
                                        <li><a href="#">Admission Documents</a></li>
                                        <li><a href="#">Frequently asked questions</a></li>
                                        <li><a href="#">Student accommodation</a></li>
                                        <li><a href="#">Student Jobs</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Services</h4>
                                    <ul>
                                        <li><a href="#">Counselling</a></li>
                                        <li><a href="#">Test Preparation</a></li>
                                        <li><a href="#">Admission</a></li>
                                        <li><a href="#">Education Loan</a></li>
                                        <li><a href="#">Visa Processing</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-lg-2 col-md-6 col-sm-6">
                                <div class="footer-widget widget widget_nav_menu">
                                    <h4 class="widget-headline">Location</h4>
                                    <ul class="contact_info_list">
                                        <li class="single-info-item">
                                            <div class="icon">
                                                <img src="assets/img/icon/location-02.png" alt="">
                                            </div>
                                            <div class="details">
                                                8502 Preston Rd. Inglewood, Maine Bangladesh
                                            </div>
                                        </li>
                                        <li class="single-info-item">
                                            <div class="icon me-4">
                                                <img src="assets/img/icon/edu-award.png" alt="">
                                            </div>
                                            <div class="icon">
                                                <img src="assets/img/icon/iso.png" alt="">
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="copyright-area">
                <div class="container custom-container-01">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="copyright-area-inner">
                                <p>© 2022 Eduplan. All rights reserved | Developed By <span>Themeim</span></p>
                                <div class="footer-social-area">
                                    <ul class="social-icon-02">
                                        <li><a href="#0"><i class="fab fa-facebook-f"></i></a></li>
                                        <li><a href="#0"><i class="fab fa-instagram"></i></a></li>
                                        <li><a href="#0"><i class="fab fa-linkedin-in"></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <!--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            footer area End Here
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~-->
    </main>
*/

