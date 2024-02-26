window.app = window.app || {};
window.app.execMainJS = () => {
    // odometer.js function
(function(){var a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G=[].slice;q='<span class="odometer-value"></span>',n='<span class="odometer-ribbon"><span class="odometer-ribbon-inner">'+q+"</span></span>",d='<span class="odometer-digit"><span class="odometer-digit-spacer">8</span><span class="odometer-digit-inner">'+n+"</span></span>",g='<span class="odometer-formatting-mark"></span>',c="(,ddd).dd",h=/^\(?([^)]*)\)?(?:(.)(d+))?$/,i=30,f=2e3,a=20,j=2,e=.5,k=1e3/i,b=1e3/a,o="transitionend webkitTransitionEnd oTransitionEnd otransitionend MSTransitionEnd",y=document.createElement("div").style,p=null!=y.transition||null!=y.webkitTransition||null!=y.mozTransition||null!=y.oTransition,w=window.requestAnimationFrame||window.mozRequestAnimationFrame||window.webkitRequestAnimationFrame||window.msRequestAnimationFrame,l=window.MutationObserver||window.WebKitMutationObserver||window.MozMutationObserver,s=function(a){var b;return b=document.createElement("div"),b.innerHTML=a,b.children[0]},v=function(a,b){return a.className=a.className.replace(new RegExp("(^| )"+b.split(" ").join("|")+"( |$)","gi")," ")},r=function(a,b){return v(a,b),a.className+=" "+b},z=function(a,b){var c;return null!=document.createEvent?(c=document.createEvent("HTMLEvents"),c.initEvent(b,!0,!0),a.dispatchEvent(c)):void 0},u=function(){var a,b;return null!=(a=null!=(b=window.performance)&&"function"==typeof b.now?b.now():void 0)?a:+new Date},x=function(a,b){return null==b&&(b=0),b?(a*=Math.pow(10,b),a+=.5,a=Math.floor(a),a/=Math.pow(10,b)):Math.round(a)},A=function(a){return 0>a?Math.ceil(a):Math.floor(a)},t=function(a){return a-x(a)},C=!1,(B=function(){var a,b,c,d,e;if(!C&&null!=window.jQuery){for(C=!0,d=["html","text"],e=[],b=0,c=d.length;c>b;b++)a=d[b],e.push(function(a){var b;return b=window.jQuery.fn[a],window.jQuery.fn[a]=function(a){var c;return null==a||null==(null!=(c=this[0])?c.odometer:void 0)?b.apply(this,arguments):this[0].odometer.update(a)}}(a));return e}})(),setTimeout(B,0),m=function(){function a(b){var c,d,e,g,h,i,l,m,n,o,p=this;if(this.options=b,this.el=this.options.el,null!=this.el.odometer)return this.el.odometer;this.el.odometer=this,m=a.options;for(d in m)g=m[d],null==this.options[d]&&(this.options[d]=g);null==(h=this.options).duration&&(h.duration=f),this.MAX_VALUES=this.options.duration/k/j|0,this.resetFormat(),this.value=this.cleanValue(null!=(n=this.options.value)?n:""),this.renderInside(),this.render();try{for(o=["innerHTML","innerText","textContent"],i=0,l=o.length;l>i;i++)e=o[i],null!=this.el[e]&&!function(a){return Object.defineProperty(p.el,a,{get:function(){var b;return"innerHTML"===a?p.inside.outerHTML:null!=(b=p.inside.innerText)?b:p.inside.textContent},set:function(a){return p.update(a)}})}(e)}catch(q){c=q,this.watchForMutations()}}return a.prototype.renderInside=function(){return this.inside=document.createElement("div"),this.inside.className="odometer-inside",this.el.innerHTML="",this.el.appendChild(this.inside)},a.prototype.watchForMutations=function(){var a,b=this;if(null!=l)try{return null==this.observer&&(this.observer=new l(function(a){var c;return c=b.el.innerText,b.renderInside(),b.render(b.value),b.update(c)})),this.watchMutations=!0,this.startWatchingMutations()}catch(c){a=c}},a.prototype.startWatchingMutations=function(){return this.watchMutations?this.observer.observe(this.el,{childList:!0}):void 0},a.prototype.stopWatchingMutations=function(){var a;return null!=(a=this.observer)?a.disconnect():void 0},a.prototype.cleanValue=function(a){var b;return"string"==typeof a&&(a=a.replace(null!=(b=this.format.radix)?b:".","<radix>"),a=a.replace(/[.,]/g,""),a=a.replace("<radix>","."),a=parseFloat(a,10)||0),x(a,this.format.precision)},a.prototype.bindTransitionEnd=function(){var a,b,c,d,e,f,g=this;if(!this.transitionEndBound){for(this.transitionEndBound=!0,b=!1,e=o.split(" "),f=[],c=0,d=e.length;d>c;c++)a=e[c],f.push(this.el.addEventListener(a,function(){return b?!0:(b=!0,setTimeout(function(){return g.render(),b=!1,z(g.el,"odometerdone")},0),!0)},!1));return f}},a.prototype.resetFormat=function(){var a,b,d,e,f,g,i,j;if(a=null!=(i=this.options.format)?i:c,a||(a="d"),d=h.exec(a),!d)throw new Error("Odometer: Unparsable digit format");return j=d.slice(1,4),g=j[0],f=j[1],b=j[2],e=(null!=b?b.length:void 0)||0,this.format={repeating:g,radix:f,precision:e}},a.prototype.render=function(a){var b,c,d,e,f,g,h;for(null==a&&(a=this.value),this.stopWatchingMutations(),this.resetFormat(),this.inside.innerHTML="",f=this.options.theme,b=this.el.className.split(" "),e=[],g=0,h=b.length;h>g;g++)c=b[g],c.length&&((d=/^odometer-theme-(.+)$/.exec(c))?f=d[1]:/^odometer(-|$)/.test(c)||e.push(c));return e.push("odometer"),p||e.push("odometer-no-transitions"),f?e.push("odometer-theme-"+f):e.push("odometer-auto-theme"),this.el.className=e.join(" "),this.ribbons={},this.formatDigits(a),this.startWatchingMutations()},a.prototype.formatDigits=function(a){var b,c,d,e,f,g,h,i,j,k;if(this.digits=[],this.options.formatFunction)for(d=this.options.formatFunction(a),j=d.split("").reverse(),f=0,h=j.length;h>f;f++)c=j[f],c.match(/0-9/)?(b=this.renderDigit(),b.querySelector(".odometer-value").innerHTML=c,this.digits.push(b),this.insertDigit(b)):this.addSpacer(c);else for(e=!this.format.precision||!t(a)||!1,k=a.toString().split("").reverse(),g=0,i=k.length;i>g;g++)b=k[g],"."===b&&(e=!0),this.addDigit(b,e)},a.prototype.update=function(a){var b,c=this;return a=this.cleanValue(a),(b=a-this.value)?(v(this.el,"odometer-animating-up odometer-animating-down odometer-animating"),b>0?r(this.el,"odometer-animating-up"):r(this.el,"odometer-animating-down"),this.stopWatchingMutations(),this.animate(a),this.startWatchingMutations(),setTimeout(function(){return c.el.offsetHeight,r(c.el,"odometer-animating")},0),this.value=a):void 0},a.prototype.renderDigit=function(){return s(d)},a.prototype.insertDigit=function(a,b){return null!=b?this.inside.insertBefore(a,b):this.inside.children.length?this.inside.insertBefore(a,this.inside.children[0]):this.inside.appendChild(a)},a.prototype.addSpacer=function(a,b,c){var d;return d=s(g),d.innerHTML=a,c&&r(d,c),this.insertDigit(d,b)},a.prototype.addDigit=function(a,b){var c,d,e,f;if(null==b&&(b=!0),"-"===a)return this.addSpacer(a,null,"odometer-negation-mark");if("."===a)return this.addSpacer(null!=(f=this.format.radix)?f:".",null,"odometer-radix-mark");if(b)for(e=!1;;){if(!this.format.repeating.length){if(e)throw new Error("Bad odometer format without digits");this.resetFormat(),e=!0}if(c=this.format.repeating[this.format.repeating.length-1],this.format.repeating=this.format.repeating.substring(0,this.format.repeating.length-1),"d"===c)break;this.addSpacer(c)}return d=this.renderDigit(),d.querySelector(".odometer-value").innerHTML=a,this.digits.push(d),this.insertDigit(d)},a.prototype.animate=function(a){return p&&"count"!==this.options.animation?this.animateSlide(a):this.animateCount(a)},a.prototype.animateCount=function(a){var c,d,e,f,g,h=this;if(d=+a-this.value)return f=e=u(),c=this.value,(g=function(){var i,j,k;return u()-f>h.options.duration?(h.value=a,h.render(),void z(h.el,"odometerdone")):(i=u()-e,i>b&&(e=u(),k=i/h.options.duration,j=d*k,c+=j,h.render(Math.round(c))),null!=w?w(g):setTimeout(g,b))})()},a.prototype.getDigitCount=function(){var a,b,c,d,e,f;for(d=1<=arguments.length?G.call(arguments,0):[],a=e=0,f=d.length;f>e;a=++e)c=d[a],d[a]=Math.abs(c);return b=Math.max.apply(Math,d),Math.ceil(Math.log(b+1)/Math.log(10))},a.prototype.getFractionalDigitCount=function(){var a,b,c,d,e,f,g;for(e=1<=arguments.length?G.call(arguments,0):[],b=/^\-?\d*\.(\d*?)0*$/,a=f=0,g=e.length;g>f;a=++f)d=e[a],e[a]=d.toString(),c=b.exec(e[a]),null==c?e[a]=0:e[a]=c[1].length;return Math.max.apply(Math,e)},a.prototype.resetDigits=function(){return this.digits=[],this.ribbons=[],this.inside.innerHTML="",this.resetFormat()},a.prototype.animateSlide=function(a){var b,c,d,f,g,h,i,j,k,l,m,n,o,p,q,s,t,u,v,w,x,y,z,B,C,D,E;if(s=this.value,j=this.getFractionalDigitCount(s,a),j&&(a*=Math.pow(10,j),s*=Math.pow(10,j)),d=a-s){for(this.bindTransitionEnd(),f=this.getDigitCount(s,a),g=[],b=0,m=v=0;f>=0?f>v:v>f;m=f>=0?++v:--v){if(t=A(s/Math.pow(10,f-m-1)),i=A(a/Math.pow(10,f-m-1)),h=i-t,Math.abs(h)>this.MAX_VALUES){for(l=[],n=h/(this.MAX_VALUES+this.MAX_VALUES*b*e),c=t;h>0&&i>c||0>h&&c>i;)l.push(Math.round(c)),c+=n;l[l.length-1]!==i&&l.push(i),b++}else l=function(){E=[];for(var a=t;i>=t?i>=a:a>=i;i>=t?a++:a--)E.push(a);return E}.apply(this);for(m=w=0,y=l.length;y>w;m=++w)k=l[m],l[m]=Math.abs(k%10);g.push(l)}for(this.resetDigits(),D=g.reverse(),m=x=0,z=D.length;z>x;m=++x)for(l=D[m],this.digits[m]||this.addDigit(" ",m>=j),null==(u=this.ribbons)[m]&&(u[m]=this.digits[m].querySelector(".odometer-ribbon-inner")),this.ribbons[m].innerHTML="",0>d&&(l=l.reverse()),o=C=0,B=l.length;B>C;o=++C)k=l[o],q=document.createElement("div"),q.className="odometer-value",q.innerHTML=k,this.ribbons[m].appendChild(q),o===l.length-1&&r(q,"odometer-last-value"),0===o&&r(q,"odometer-first-value");return 0>t&&this.addDigit("-"),p=this.inside.querySelector(".odometer-radix-mark"),null!=p&&p.parent.removeChild(p),j?this.addSpacer(this.format.radix,this.digits[j-1],"odometer-radix-mark"):void 0}},a}(),m.options=null!=(E=window.odometerOptions)?E:{},setTimeout(function(){var a,b,c,d,e;if(window.odometerOptions){d=window.odometerOptions,e=[];for(a in d)b=d[a],e.push(null!=(c=m.options)[a]?(c=m.options)[a]:c[a]=b);return e}},0),m.init=function(){var a,b,c,d,e,f;if(null!=document.querySelectorAll){for(b=document.querySelectorAll(m.options.selector||".odometer"),f=[],c=0,d=b.length;d>c;c++)a=b[c],f.push(a.odometer=new m({el:a,value:null!=(e=a.innerText)?e:a.textContent}));return f}},null!=(null!=(F=document.documentElement)?F.doScroll:void 0)&&null!=document.createEventObject?(D=document.onreadystatechange,document.onreadystatechange=function(){return"complete"===document.readyState&&m.options.auto!==!1&&m.init(),null!=D?D.apply(this,arguments):void 0}):document.addEventListener("DOMContentLoaded",function(){return m.options.auto!==!1?m.init():void 0},!1),"function"==typeof define&&define.amd?define([],function(){return m}):"undefined"!=typeof exports&&null!==exports?module.exports=m:window.Odometer=m}).call(this);

    // viewport.jquery.js function
    (function ($) {
    'use strict'

    var Class = function (el, cb) {
        this.$el = $(el);
        this.cb = cb;
        this.watch();
        return this;
    };

    Class.prototype = {

        /**
         * Checks if the element is in.
         *
         * @returns {boolean}
         */
        isIn: function isIn() {
        var _self = this;
        var $win = $(window);
        var elementTop = _self.$el.offset().top;
        var elementBottom = elementTop + _self.$el.outerHeight();
        var viewportTop = $win.scrollTop();
        var viewportBottom = viewportTop + $win.height();
        return elementBottom > viewportTop && elementTop < viewportBottom;
        },

        /**
         * Launch a callback indicating when the element is in and when is out.
         */
        watch: function () {
        var _self = this;
        var _isIn = false;

        $(window).on('resize scroll', function () {

            if (_self.isIn() && _isIn === false) {
            _self.cb.call(_self.$el, 'entered');
            _isIn = true;
            }

            if (_isIn === true && !_self.isIn()) {
            _self.cb.call(_self.$el, 'leaved');
            _isIn = false;
            }

        })
        }


    };

    // jQuery plugin.
    //-----------------------------------------------------------
    $.fn.isInViewport = function (cb) {
        return this.each(function () {
        var $element = $(this);
        var data = $element.data('isInViewport');
        if (!data) {
            $element.data('isInViewport', (new Class(this, cb)));
        }
        })
    }

    })(window.jQuery);

    // main.js function
    (function ($) {
        "use strict";

        $(document).ready(function () {
            /*-----------------------------------------
                global slick slicer control
            ------------------------------------------*/

            var globalSlickInit = $('.global-slick-init');
            if (globalSlickInit.length > 0) {

                //todo have to check slider item
                $.each(globalSlickInit, function (index, value) {
                    if ($(this).children('div').length > 1) {

                        //todo configure slider settings object
                        var sliderSettings = {};
                        var allData = $(this).data();
                        var infinite = typeof allData.infinite == 'undefined' ? false : allData.infinite;
                        var arrows = typeof allData.arrows == 'undefined' ? false : allData.arrows;
                        var autoplay = typeof allData.autoplay == 'undefined' ? false : allData.autoplay;
                        var focusOnSelect = typeof allData.focusonselect == 'undefined' ? false : allData.focusonselect;
                        var swipeToSlide = typeof allData.swipetoslide == 'undefined' ? false : allData.swipetoslide;
                        var slidesToShow = typeof allData.slidestoshow == 'undefined' ? 1 : allData.slidestoshow;
                        var slidesToScroll = typeof allData.slidestoscroll == 'undefined' ? 1 : allData.slidestoscroll;
                        var speed = typeof allData.speed == 'undefined' ? '500' : allData.speed;
                        var dots = typeof allData.dots == 'undefined' ? false : allData.dots;
                        var cssEase = typeof allData.cssease == 'undefined' ? 'linear' : allData.cssease;
                        var prevArrow = typeof allData.prevarrow == 'undefined' ? '' : allData.prevarrow;
                        var nextArrow = typeof allData.nextarrow == 'undefined' ? '' : allData.nextarrow;
                        var centerMode = typeof allData.centermode == 'undefined' ? false : allData.centermode;
                        var centerPadding = typeof allData.centerpadding == 'undefined' ? '50px' : allData.centerpadding;
                        var rows = typeof allData.rows == 'undefined' ? 1 : parseInt(allData.rows);
                        var autoplay = typeof allData.autoplay == 'undefined' ? false : allData.autoplay;
                        var autoplaySpeed = typeof allData.autoplayspeed == 'undefined' ? 2000 : parseInt(allData.autoplayspeed);
                        var lazyLoad = typeof allData.lazyload == 'undefined' ? false : allData.lazyload; // have to remove it from settings object if it undefined
                        var appendDots = typeof allData.appenddots == 'undefined' ? false : allData.appenddots;
                        var appendArrows = typeof allData.appendarrows == 'undefined' ? false : allData.appendarrows;
                        var asNavFor = typeof allData.asnavfor == 'undefined' ? false : allData.asnavfor;
                        var verticalSwiping = typeof allData.verticalswiping == 'undefined' ? false : allData.verticalswiping;
                        var vertical = typeof allData.vertical == 'undefined' ? false : allData.vertical;
                        var fade = typeof allData.fade == 'undefined' ? false : allData.fade;
                        var rtl = typeof allData.rtl == 'undefined' ? false : allData.rtl;
                        var responsive = typeof $(this).data('responsive') == 'undefined' ? false : $(this).data('responsive');

                        //slider settings object setup
                        sliderSettings.infinite = infinite;
                        sliderSettings.arrows = arrows;
                        sliderSettings.autoplay = autoplay;
                        sliderSettings.focusOnSelect = focusOnSelect;
                        sliderSettings.swipeToSlide = swipeToSlide;
                        sliderSettings.slidesToShow = slidesToShow;
                        sliderSettings.slidesToScroll = slidesToScroll;
                        sliderSettings.speed = speed;
                        sliderSettings.dots = dots;
                        sliderSettings.cssEase = cssEase;
                        sliderSettings.prevArrow = prevArrow;
                        sliderSettings.nextArrow = nextArrow;
                        sliderSettings.rows = rows;
                        sliderSettings.autoplaySpeed = autoplaySpeed;
                        sliderSettings.autoplay = autoplay;
                        sliderSettings.verticalSwiping = verticalSwiping;
                        sliderSettings.vertical = vertical;
                        sliderSettings.rtl = rtl;
                        sliderSettings.centerPadding = centerPadding;

                        if (centerMode != false) {
                            sliderSettings.centerMode = centerMode;
                        }
                        if (centerPadding != false) {
                            sliderSettings.centerPadding = centerPadding;
                        }
                        if (lazyLoad != false) {
                            sliderSettings.lazyLoad = lazyLoad;
                        }
                        if (appendDots != false) {
                            sliderSettings.appendDots = appendDots;
                        }
                        if (appendArrows != false) {
                            sliderSettings.appendArrows = appendArrows;
                        }
                        if (asNavFor != false) {
                            sliderSettings.asNavFor = asNavFor;
                        }
                        if (fade != false) {
                            sliderSettings.fade = fade;
                        }
                        if (responsive != false) {
                            sliderSettings.responsive = responsive;
                        }
                        $(this).slick(sliderSettings);
                    }
                });
            }

            /*-------------------------------
                Navbar Fix
            ------------------------------*/
            if ($(window).width() < 991) {
                navbarFix()
            }

            $(".menu-item-has-children a").on("click", function () {
                var element = $(this).parent("li");
                if (element.hasClass("show")) {
                    element.removeClass("show");
                    element.children("ul").slideUp(500);
                } else {
                    element.siblings("li").removeClass('show');
                    element.addClass("show");
                    element.siblings("li").find("ul").slideUp(500);
                    element.children('ul').slideDown(500);
                }
            });

            //Odometer
            if ($(".single-counterup").length) {
                $(".single-counterup").each(function () {
                    $(this).isInViewport(function (status) {
                        if (status === "entered") {
                            for (var i = 0; i < document.querySelectorAll(".odometer").length; i++) {
                                var el = document.querySelectorAll('.odometer')[i];
                                el.innerHTML = el.getAttribute("data-odometer-final");
                            }
                        }
                    });
                });
            }

            // Title Shape Scroll animation
            $(window).on('scroll', function () {
                let shape = document.querySelectorAll('.title-shape');

                for (let i = 0; i < shape.length; i++) {
                    var windowHeight = window.innerHeight;
                    var elementTop = shape[i].getBoundingClientRect().top;
                    var elementVisible = 150;

                    if (elementTop < windowHeight - elementVisible) {
                        shape[i].classList.add("active");
                    } else {
                        shape[i].classList.remove("active");
                    }
                }
            });
            // Plane Shape Scroll animation
            $(window).on('scroll', function () {
                let shape = document.querySelectorAll('.plane-wrap');

                for (let i = 0; i < shape.length; i++) {
                    var windowHeight = window.innerHeight;
                    var elementTop = shape[i].getBoundingClientRect().top;
                    var elementVisible = 200;

                    if (elementTop < windowHeight - elementVisible) {
                        shape[i].classList.add("active");
                    } else {
                        shape[i].classList.remove("active");
                    }
                }
            });

            /*--------------------
            Remove cart item
            ---------------------*/
            $('.remove-cart').on('click', function (e) {
                e.preventDefault();
                $(this).parent().parent().hide(300);
            });

            /*-------------------------
                product + - start here
            -------------------------*/

            $(function () {
                $(".qtybutton").on("click", function () {
                    var $button = $(this);
                    var oldValue = $button.parent().find("input").val();
                    if ($button.text() === "+") {
                        var newVal = parseFloat(oldValue) + 1;
                    } else {
                        // Don't allow decrementing below zero
                        if (oldValue > 1) {
                            var newVal = parseFloat(oldValue) - 1;
                        } else {
                            newVal = 1;
                        }
                    }
                    $button.parent().find("input").val(newVal);
                });
            });

            /*--------------------
                wow js init
            ---------------------*/
            new WOW().init();

            /*-------------------------
                magnific popup activation
            -------------------------*/
            $('.video-play-btn,.video-popup,.small-vide-play-btn').magnificPopup({
                disableOn: 300,
                type: 'iframe',
                mainClass: 'mfp-fade',
                removalDelay: 160,
                preloader: false,
                fixedContentPos: false,
            });

            $('.image-popup').magnificPopup({
                type: 'image',
                removalDelay: 260,
                mainClass: 'mfp-zoom-in',
            });

            /*------------------
                back to top
            ------------------*/
            $(document).on('click', '.back-to-top', function () {
                $("html,body").animate({
                    scrollTop: 0
                }, 2000);
            });

            /*-------------------------------
            Nice Select initialize
            ------------------------------*/
            $("select").niceSelect();

            /*----------------------
                Cart Sidebar
            -----------------------*/
            $('.open-cart').on('click', function () {
                $('.cart-menu-wrap').addClass('cart-open');
                $('.cart-menu-overlay').addClass('cart-overlay-open');
            });

            $('.cart-menu-overlay').on('click', function () {
                $('.cart-menu-wrap').removeClass('cart-open');
                $('.cart-menu-overlay').removeClass('cart-overlay-open');
            });

            /*----------------------
                Sidebar
            -----------------------*/
            $('.open-sidebar').on('click', function () {
                $('.sidebar-menu-wrap').addClass('sidebar-open');
                $('.side-menu-overlay').addClass('overlay-open');
            });

            $('.side-menu-overlay,.close-btn-02').on('click', function () {
                $('.sidebar-menu-wrap').removeClass('sidebar-open');
                $('.side-menu-overlay').removeClass('overlay-open');
            });

            /*----------------------
                Search Popup
            -----------------------*/
            var bodyOvrelay = $('#body-overlay');
            var searchPopup = $('#search-popup');

            $(document).on('click', '#body-overlay', function (e) {
                e.preventDefault();
                bodyOvrelay.removeClass('active');
                searchPopup.removeClass('active');
            });
            $(document).on('click', '.border-none', function (e) {
                e.preventDefault();
                bodyOvrelay.removeClass('active');
                searchPopup.removeClass('active');
            });
            $(document).on('click', '#search', function (e) {
                e.preventDefault();
                searchPopup.addClass('active');
                bodyOvrelay.addClass('active');
            });

        });



        //define variable for store last scrolltop
        var lastScrollTop = '';

        $(window).on('scroll', function () {

            //back to top show/hide
            var ScrollTop = $('.back-to-top');
            if ($(window).scrollTop() > 1000) {
                ScrollTop.fadeIn(1000);
            } else {
                ScrollTop.fadeOut(1000);
            }

            // Sticky-Memu
            if ($(window).width() > 991) {
                StickyMenu();
            }
        });


        $(window).on('resize', function () {
            /*-------------------------------
                Navbar Fix
            ------------------------------*/
            if ($(window).width() < 991) {
                navbarFix()
            }
        });


        $(window).on('load', function () {

            /*-----------------
                preloader
            ------------------*/
            setInterval(function () {
                $("#preloader").fadeOut(300);
            }, 500);

            /*-----------------
                back to top
            ------------------*/
            var backtoTop = $('.back-to-top')
            backtoTop.fadeOut();

        });

        function navbarFix() {
            $(document).on('click', '.navbar-area .navbar-nav li.menu-item-has-children>a, .navbar-area .navbar-nav li.appside-megamenu>a', function (e) {
                e.preventDefault();
            })
        }

        function StickyMenu() {
            /*--------------------------
            sticky menu activation
            ---------------------------*/
            var st = $(this).scrollTop();
            var mainMenuTop = $('.navbar-area');
            if ($(window).scrollTop() > 500) {
                mainMenuTop.addClass('nav-fixed');
            } else {
                mainMenuTop.removeClass('nav-fixed');
            }
            lastScrollTop = st;
        }

        $(".recent").click(function () {
            let target_menu = $(this).siblings('.header-select-list');
            $(".header-select-list").slideUp();

            if (target_menu.is(':hidden')) {
                target_menu.slideDown()
            } else {
                target_menu.slideUp()
            }
        });

    })(jQuery);

};