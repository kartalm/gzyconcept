/**
 *  1.  top Menu
    2.  Main Menu
    3.  Search box
    4.  Accordion
    5.  Toggle
    6.  Owl Carousel
    7.  Validate Form
    8.  Google Map
    9.  Search Box
    10. Sync owl carousel
    11. Portfolio Wookmark
    12. Magnific Popup
    13. Masonry
    14. Pie chart
    15. Flickr
    16. Single-author-Filter
    17. Fraction Slider
    18. Match height
    19. Fix css ie8

 *-----------------------------------------------------------------
 **/
 

"use strict";


$(document).ready(function(){

var kopa_variable = {
    "contact": {
        "address": "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
        "marker": "/url image"
    },
    "i18n": {
        "VIEW": "View",
        "VIEWS": "Views",
        "validate": {
            "form": {
                "SUBMIT": "Submit",
                "SENDING": "Sending..."
            },
            "name": {
                "REQUIRED": "Please enter your name",
                "MINLENGTH": "At least {0} characters required"
            },
            "email": {
                "REQUIRED": "Please enter your email",
                "EMAIL": "Please enter a valid email"
            },
            "url": {
                "REQUIRED": "Please enter your url",
                "URL": "Please enter a valid url"
            },
            "message": {
                "REQUIRED": "Please enter a message",
                "MINLENGTH": "At least {0} characters required"
            }
        },
        "tweets": {
            "failed": "Sorry, twitter is currently unavailable for this user.",
            "loading": "Loading tweets..."
        }
    },
    "url": {
        "template_directory_uri":""
    }
};

var map;



/* =========================================================
1. top Menu
============================================================ */

Modernizr.load([
  {
    load: kopa_variable.url.template_directory_uri + 'js/superfish.min.js',
    complete: function () {

        //Main menu
        $('.top-menu').superfish({
        });
    }
  }
]);


/* =========================================================
2. Main Menu
============================================================ */

Modernizr.load([
  {
    load: kopa_variable.url.template_directory_uri + 'js/superfish.min.js',
    complete: function () {
        
        var r_ul = $('.kopa-main-nav .sf-menu');
        r_ul.superfish({
            speed: "fast",
            delay: "100"
        });

        
    }
  }
]);


/* ============================================
3. Mobile-menu
=============================================== */

    Modernizr.load([{
        load: [kopa_variable.url.template_directory_uri + 'js/jquery.navgoco.min.js'],
        complete: function () {

            $(".top-menu-mobile").navgoco({
                accordion: true
            });
            $(".top-nav-mobile > .pull").click(function () {
                $(this).closest(".top-nav-mobile").find(".top-menu-mobile").slideToggle("slow");
            });
            
            
            
            $(".main-nav-mobile > .pull").click(function (e) {
                var mm_ul = $(this).closest(".main-nav-mobile").find(".main-menu-mobile");
                mm_ul.slideToggle("slow");
            });
            $(".main-menu-mobile").navgoco({
                accordion: true
            });

            $(".main-menu-mobile").find(".sf-mega").removeClass("sf-mega").addClass("sf-mega-mobile");
            $(".main-menu-mobile").find(".sf-mega-section").removeClass("sf-mega-section").addClass("sf-mega-section-mobile");
            $(".caret").removeClass("caret");

            $(".bottom-nav-mobile > .pull").click(function () {
                $(this).closest(".bottom-nav-mobile").find(".main-menu-mobile").slideToggle("slow");
            });

        }
    }]);




/* =========================================================
4. Accordion
============================================================ */

    var panel_titles = $('.kopa-accordion .panel-title a');
    panel_titles.addClass("collapsed");
    $('.panel-heading.active').find(panel_titles).removeClass("collapsed");
    panel_titles.click(function(){
        $(this).closest('.kopa-accordion').find('.panel-heading').removeClass('active');
        var pn_heading = $(this).parents('.panel-heading');
        if ($(this).hasClass('collapsed')) {
            pn_heading.addClass('active');
        } else {
            pn_heading.removeClass('active');
        }
    });



 /* =========================================================
5. Toggle
============================================================ */
 
    $('.kopa-toggle .panel-group .collapse').collapse({
        toggle: false
    });  
    var panel_titles_2 = $('.kopa-toggle .panel-title a');
    panel_titles_2.click(function(){
        var parent = $(this).closest('.panel-heading');
        if (parent.hasClass('active')) {
            parent.removeClass('active');
        } else {
            parent.addClass('active');
        }
    });


 /* =========================================================
6. Owl Carousel
============================================================ */

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/owl.carousel.min.js'],
        complete: function () {

            var owl1 = $(".owl-carousel-1");
            owl1.owlCarousel({
                items: 3,
                itemsDesktop: [1160,3],
                itemsTablet: [799,3],
                itemsTabletSmall: [719,1],
                pagination: false,
                slideSpeed: 600,
                navigationText: false,
                navigation: true,
                addClassActive: true,
                afterAction: function(){
                    $(".big-thumb").removeClass("big-thumb");
                    owl1.find(".active").eq(1).addClass("big-thumb");
                },
                afterInit: function(){
                   $(".kopa-slider-1-widget .loading").hide();    
                }
            });
            owl1.find(".owl-controls").addClass("style1");


            var owl2 = $(".owl-carousel-2");
            owl2.owlCarousel({
                items: 4,
                itemsTablet : [799,3],
                itemsTabletSmall: [639,1],
                pagination: false,
                slideSpeed: 600,
                navigationText: false,
                navigation: true,
                addClassActive: true,
                afterAction: function(){
                    $(".owl2-first").removeClass("owl2-first");
                    $(".owl2-last").removeClass("owl2-last");
                    $(".owl2-at-last").removeClass("owl2-at-last");
                    owl2.find(".active").eq(0).addClass("owl2-first");
                    owl2.find(".active").last().addClass("owl2-last");
                    $(".owl2-last").next().addClass("owl2-at-last");
                }
            });
            owl2.find(".owl-controls").addClass("style1");

            var owl3 = $(".owl-carousel-3");
            owl3.owlCarousel({
                items: 2,
                itemsDesktop: [1160,2],
                itemsDesktopSmall : [979,2],
                itemsTabletSmall: [719,1],
                pagination: false,
                slideSpeed: 600,
                navigationText: false,
                navigation: true,
                addClassActive: true,
                afterAction: function(){
                    $(".owl3-right").removeClass("owl3-right");
                    owl3.find(".active").eq(1).addClass("owl3-right");
                },
                afterInit: function(){
                   $(".article-list-1 .loading").hide();    
                }
            });
            owl3.find(".owl-controls").addClass("style2");

            var owl4 = $(".owl-carousel-4");
            owl4.owlCarousel({
                items: 5,
                pagination: false,
                navigationText: false,
                navigation: false,
                slideSpeed: 600,
                autoPlay: true
            });

            var owl5 = $(".owl-carousel-5");
            owl5.owlCarousel({
                singleItem: true,
                pagination: true,
                slideSpeed: 600,
                navigationText: false,
                navigation: true,
                autoPlay: true,
                afterAction: function(){
                    var h_51 = owl5.find(".entry-item").height();
                    owl5.find(".entry-item").find('.wrapper').height(h_51);
                    var h_5 = owl5.find(".entry-content").height();
                    var m_5 = -(h_5/2 + 30);
                    owl5.find(".entry-content").css({
                        "margin-top": m_5
                    });
                },
                afterInit: function(){
                   $(".kopa-slider-2-widget .loading").hide();    
                }
            });
            owl5.find(".owl-controls").addClass("style4");

            var owl6 = $(".owl-carousel-6");
            owl6.owlCarousel({
                items: 3,
                itemsDesktop: [1160,3],
                pagination: true,
                navigationText: false,
                navigation: false,
                slideSpeed: 600
            });

            var owl7 = $(".owl-carousel-7");
            owl7.owlCarousel({
                singleItem: true,
                pagination: false,
                navigationText: false,
                navigation: true,
                autoPlay: true,
                slideSpeed: 600
            });
            owl7.find(".owl-controls").addClass("style5");

            var owl8 = $(".owl-carousel-8");
            owl8.owlCarousel({
                items: 4,
                pagination: true,
                navigationText: false,
                navigation: false,
                slideSpeed: 600
            });

            var owl9 = $(".owl-carousel-9");
            owl9.owlCarousel({
                singleItem: true,
                pagination: false,
                navigationText: false,
                navigation: true,
                slideSpeed: 600
            });
            owl9.find(".owl-controls").addClass("style6");

            var owl10 = $(".owl-carousel-10");
            owl10.owlCarousel({
                singleItem: true,
                pagination: true,
                navigationText: false,
                navigation: true,
                slideSpeed: 600
            });
            owl10.find(".owl-controls").addClass("style7");

            var owl11 = $(".owl-carousel-11");
            owl11.owlCarousel({
                items: 3,
                pagination: false,
                navigationText: false,
                navigation: true,
                slideSpeed: 600
            });
            owl11.find(".owl-controls").addClass("style6");

            var owl12 = $(".owl-carousel-12");
            owl12.owlCarousel({
                items: 4,
                pagination: false,
                navigationText: false,
                navigation: true,
                slideSpeed: 600
            });
            owl12.find(".owl-controls").addClass("style6");

            var owl13 = $(".owl-carousel-13");
            owl13.owlCarousel({
                items: 4,
                pagination: false,
                navigationText: false,
                navigation: true,
                slideSpeed: 600
            });
            owl13.find(".owl-controls").addClass("style6");

            var owl14 = $(".owl-carousel-14");
            owl14.owlCarousel({
                items: 4,
                pagination: true,
                navigationText: false,
                navigation: false,
                slideSpeed: 600
            });

        }   
    }]);


/* =========================================================
7. Validate Form
============================================================ */


    /*-- contact form --*/
    
    if ($('.contact-form').length > 0) {
        Modernizr.load([
          {
            load:[ kopa_variable.url.template_directory_uri + 'js/jquery.form.min.js', kopa_variable.url.template_directory_uri + 'js/jquery.validate.min.js'],
            complete: function () {
                $('.contact-form').validate({
                    // Add requirements to each of the fields
                    rules: {
                        name: {
                            required: true,
                            minlength: 10
                        },
                        email: {
                            required: true,
                            email: true
                        },
                        web: {
                            required: true,
                            minlength: 10
                        },
                        message: {
                            required: true,
                            minlength: 15
                        }
                    },
                    // Specify what error messages to display
                    // when the user does something horrid
                    messages: {
                        name: {
                            required: "Please enter your name.",
                            minlength: $.format("At least {0} characters required.")
                        },
                        email: {
                            required: "Please enter your email.",
                            email: "Please enter a valid email."
                        },
                        web: {
                            required: "Please enter your website.",
                            minlength: "Please enter a valid website url."
                        },
                        message: {
                            required: "Please enter a message.",
                            minlength: $.format("At least {0} characters required.")
                        }
                    },
                    // Use Ajax to send everything to processForm.php
                    submitHandler: function(form) {
                        $("#input-submit").attr("value", "Sending...");
                        $(form).ajaxSubmit({
                            success: function(responseText, statusText, xhr, $form) {
                                $("#response1").html(responseText).hide().slideDown("fast");
                                $("#input-submit").attr("value", "Submit");
                            }
                        });
                        return false;
                    }
                });
            }
          }
        ]);
    };

    /*-- contact form --*/
    
    if ($('.contact-form-1').length > 0) {
        Modernizr.load([
          {
            load:[ kopa_variable.url.template_directory_uri + 'js/jquery.form.min.js', kopa_variable.url.template_directory_uri + 'js/jquery.validate.min.js'],
            complete: function () {
                $('.contact-form-1').validate({
                    // Add requirements to each of the fields
                    rules: {
                        name: {
                            required: true,
                            minlength: 8
                        },
                        email: {
                            required: true,
                            email: true
                        },
                        web: {
                            required: true,
                            minlength: 10
                        },
                        message: {
                            required: true,
                            minlength: 10
                        }
                    },
                    // Specify what error messages to display
                    // when the user does something horrid
                    messages: {
                        name: {
                            required: "Please enter your name.",
                            minlength: $.format("At least {0} characters required.")
                        },
                        email: {
                            required: "Please enter your email.",
                            email: "Please enter a valid email."
                        },
                        web: {
                            required: "Please enter your website.",
                            minlength: "Please enter a valid website url."
                        },
                        message: {
                            required: "Please enter a message.",
                            minlength: $.format("At least {0} characters required.")
                        }
                    },
                    // Use Ajax to send everything to processForm.php
                    submitHandler: function(form) {
                        $("#.input-submit-1").attr("value", "Sending...");
                        $(form).ajaxSubmit({
                            success: function(responseText, statusText, xhr, $form) {
                                $("#response").html(responseText).hide().slideDown("fast");
                                $("#.input-submit-1").attr("value", "Submit");
                            }
                        });
                        return false;
                    }
                });
            }
          }
        ]);
    };

    /*-- comment form --*/

    if ($('#comments-form').length > 0) {
        Modernizr.load([
          {
            load:[ kopa_variable.url.template_directory_uri + 'js/jquery.form.min.js', kopa_variable.url.template_directory_uri + 'js/jquery.validate.min.js'],
            complete: function () {
                $('#comments-form').validate({
                    // Add requirements to each of the fields
                    rules: {
                        name: {
                            required: true,
                            minlength: 10
                        },
                        email: {
                            required: true,
                            email: true
                        },
                        phone: {
                            required: true,
                            phone: true
                        },
                        message: {
                            required: true,
                            minlength: 15
                        }
                    },
                    // Specify what error messages to display
                    // when the user does something horrid
                    messages: {
                        name: {
                            required: "Please enter your name.",
                            minlength: $.format("At least {0} characters required.")
                        },
                        email: {
                            required: "Please enter your email.",
                            email: "Please enter a valid email."
                        },
                        phone: {
                            required: "Please enter your phone.",
                            url: "Please enter a valid phone."
                        },
                        message: {
                            required: "Please enter a message.",
                            minlength: $.format("At least {0} characters required.")
                        }
                    },
                    // Use Ajax to send everything to processForm.php
                    submitHandler: function(form) {
                        $("#input-submit").attr("value", "Sending...");
                        $(form).ajaxSubmit({
                            success: function(responseText, statusText, xhr, $form) {
                                $("#response2").html(responseText).hide().slideDown("fast");
                                $("#input-submit").attr("value", "Submit");
                            }
                        });
                        return false;
                    }
                });
            }
          }
        ]);
    };
   

/* =========================================================
8. Google Map
============================================================ */

var map;

if ($('.kopa-map').length > 0) {
    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/gmaps.js'],
            complete: function () {
          var id_map = $('.kopa-map').attr('id');
          var lat = parseFloat($('.kopa-map').attr('data-latitude'));
          var lng = parseFloat($('.kopa-map').attr('data-longitude'));
          var place = $('.kopa-map').attr('data-place');

      map = new GMaps({
          el: '#'+id_map,
          lat: lat,
          lng: lng,
          zoomControl : true,
          zoomControlOpt: {
              style : 'SMALL',
              position: 'TOP_LEFT'
          },
          panControl : false,
          streetViewControl : false,
          mapTypeControl: false,
          overviewMapControl: false
        });
        map.addMarker({
          lat: lat,
            lng: lng,
          title: place
        });
        }
    }]);
};



/* =========================================================
9. Search Box
============================================================ */

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/classie.js',  kopa_variable.url.template_directory_uri + 'js/uisearch.js'],
        complete: function () {
            new UISearch( document.getElementById( 'sb-search' ) );
        }
    }]);




/* =========================================================
10. Sync owl carousel
============================================================ */
 

if ($('.kopa-sync-carousel-widget').length > 0) {
    Modernizr.load([{
        load: kopa_variable.url.template_directory_uri + 'js/owl.carousel.min.js',
        complete: function() {
            var sync1 = $(".kopa-sync-carousel-widget .sync1");
            var sync2 = $(".kopa-sync-carousel-widget .sync2");

            sync1.owlCarousel({
                singleItem: true,
                slideSpeed: 1000,
                navigation: false,
                navigationText: false,
                pagination: false,
                afterAction: syncPosition,
                responsiveRefreshRate: 200,
                afterInit: function(){
                   $(".kopa-sync-carousel-widget .loading").hide();    
                }
            });

            sync2.owlCarousel({
                items: 5,
                itemsDesktop: [1160,5],
                itemsDesktopSmall : [979,5],
                itemsTablet : [799,5],
                itemsMobile: [479,3], 
                pagination: false,
                navigation: true,
                navigationText: true,
                responsiveRefreshRate: 100,
                addClassActive: true,
                afterAction: function(){
                    $(".sync2-center").removeClass("sync2-center");
                    sync2.find(".active").eq(2).addClass("sync2-center");
                },
                afterInit: function(el) {
                    el.find(".owl-item").eq(0).addClass("synced");
                }
            });
            sync2.find(".owl-controls").addClass("style3");

            function syncPosition(el) {
                var current = this.currentItem;
                $(".sync2").find(".owl-item").removeClass("synced").eq(current).addClass("synced")
                if ($(".sync2").data("owlCarousel") !== undefined) {
                    center(current)
                }
            }

            $(".sync2").on("click", ".owl-item", function(e) {
                e.preventDefault();
                var number = $(this).data("owlItem");
                sync1.trigger("owl.goTo", number);
            });

            function center(number){
                
                var sync2visible = sync2.data("owlCarousel").owl.visibleItems;
                var num = number;
                var found = false;
                for(var i in sync2visible){
                  if(num === sync2visible[i]){
                    var found = true;
                  }
                }
             
                if(found===false){
                    if (undefined != sync2visible){
                        if(num > sync2visible[sync2visible.length-1]){
                            sync2.trigger("owl.goTo", num - sync2visible.length+2)
                        }else{
                            if(num - 1 === -1){
                                num = 0;
                            }
                            sync2.trigger("owl.goTo", num);
                        } 
                    }
                } else if(num === sync2visible[sync2visible.length-1]){
                    sync2.trigger("owl.goTo", sync2visible[1])
                } else if(num === sync2visible[0]){
                    sync2.trigger("owl.goTo", num-1)
                }
                
            }
        }
    }]);
    
};

if ($('.kopa-sync-portfolio-widget').length > 0) {
    Modernizr.load([{
        load: kopa_variable.url.template_directory_uri + 'js/owl.carousel.min.js',
        complete: function() {
            var sync3 = $(".kopa-sync-portfolio-widget .sync3");
            var sync4 = $(".kopa-sync-portfolio-widget .sync4");

            sync3.owlCarousel({
                singleItem: true,
                slideSpeed: 1000,
                navigation: true,
                navigationText: false,
                pagination: false,
                afterAction: syncPosition,
                responsiveRefreshRate: 200,
                afterInit: function(){
                   $(".kopa-sync-portfolio-widget .loading").hide();    
                }
            });
            sync3.find(".owl-controls").addClass("style7");


            sync4.owlCarousel({
                items: 6,
                itemsDesktop: [1160,6],
                itemsDesktopSmall : [979,6],
                itemsTablet : [799,6],
                itemsMobile : [479,3],
                pagination: false,
                navigation: true,
                navigationText: false,
                responsiveRefreshRate: 100,
                addClassActive: true,
                afterAction: function(){
                    $(".sync4-center").removeClass("sync4-center");
                    sync4.find(".active").eq(2).addClass("sync4-center");
                },
                afterInit: function(el) {
                    el.find(".owl-item").eq(0).addClass("synced");
                }
            });

            function syncPosition(el) {
                var current = this.currentItem;
                $(".sync4").find(".owl-item").removeClass("synced").eq(current).addClass("synced")
                if ($(".sync4").data("owlCarousel") !== undefined) {
                    center(current)
                }
            }

            $(".sync4").on("click", ".owl-item", function(e) {
                e.preventDefault();
                var number = $(this).data("owlItem");
                sync3.trigger("owl.goTo", number);
            });

            function center(number){
                
                var sync4visible = sync4.data("owlCarousel").owl.visibleItems;
                var num = number;
                var found = false;
                for(var i in sync4visible){
                  if(num === sync4visible[i]){
                    var found = true;
                  }
                }
             
                if(found===false){
                    if (undefined != sync4visible){
                        if(num > sync4visible[sync4visible.length-1]){
                            sync4.trigger("owl.goTo", num - sync4visible.length+2)
                        }else{
                            if(num - 1 === -1){
                                num = 0;
                            }
                            sync4.trigger("owl.goTo", num);
                        } 
                    }
                } else if(num === sync4visible[sync4visible.length-1]){
                    sync4.trigger("owl.goTo", sync4visible[1])
                } else if(num === sync4visible[0]){
                    sync4.trigger("owl.goTo", num-1)
                }
                
            }
        }
    }]);
    
};
    

   /* =========================================================
11. Portfolio Wookmark
============================================================ */
    
if ($('.kopa-portfolio-widget').length > 0) {

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/imagesloaded.js',  kopa_variable.url.template_directory_uri + 'js/jquery.wookmark.js'],
        complete: function () {

            $('.kopa-portfolio-widget .portfolio-list-item').imagesLoaded(function() {
            // Prepare layout options.
                var options = {
                  autoResize: true, // This will auto-update the layout when the browser window is resized.
                  container: $('.kopa-portfolio-widget .portfolio-container'), // Optional, used for some extra CSS styling
                  offset: 0, // Optional, the distance between grid items
                  fillEmptySpace: true // Optional, fill the bottom of each column with widths of flexible height
                };

                // Get a reference to your grid items.
                var handler = $('.kopa-portfolio-widget .portfolio-list-item li'),
                    filters = $('.kopa-portfolio-widget .filters-options li');

                // Call the layout function.
                handler.wookmark(options);

                /**
                 * When a filter is clicked, toggle it's active state and refresh.
                 */
                var onClickFilter = function(event) {
                  var item = $(event.currentTarget),
                      activeFilters = [];

                  if (!item.hasClass('active')) {
                    filters.removeClass('active');
                  }
                  item.toggleClass('active');

                  // Filter by the currently selected filter
                  if (item.hasClass('active')) {
                    activeFilters.push(item.data('filter'));
                  }

                  handler.wookmarkInstance.filter(activeFilters);
                }

                // Capture filter click events.
                filters.click(onClickFilter);
            });

        }
    }]);

};

if ($('.kopa-portfolio-2-widget').length > 0) {

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/imagesloaded.js',  kopa_variable.url.template_directory_uri + 'js/jquery.wookmark.js'],
        complete: function () {

            $('.kopa-portfolio-2-widget .portfolio-list-item').imagesLoaded(function() {
            // Prepare layout options.
                var options = {
                  autoResize: true, // This will auto-update the layout when the browser window is resized.
                  container: $('.kopa-portfolio-2-widget .portfolio-container'), // Optional, used for some extra CSS styling
                  offset: 0, // Optional, the distance between grid items
                  fillEmptySpace: true // Optional, fill the bottom of each column with widths of flexible height
                };

                // Get a reference to your grid items.
                var handler = $('.kopa-portfolio-2-widget .portfolio-list-item li'),
                    filters = $('.kopa-portfolio-2-widget .filters-options li');

                // Call the layout function.
                handler.wookmark(options);

                /**
                 * When a filter is clicked, toggle it's active state and refresh.
                 */
                var onClickFilter = function(event) {
                  var item = $(event.currentTarget),
                      activeFilters = [];

                  if (!item.hasClass('active')) {
                    filters.removeClass('active');
                  }
                  item.toggleClass('active');

                  // Filter by the currently selected filter
                  if (item.hasClass('active')) {
                    activeFilters.push(item.data('filter'));
                  }

                  handler.wookmarkInstance.filter(activeFilters);
                }

                // Capture filter click events.
                filters.click(onClickFilter);
            });

        }
    }]);

};

 /* =========================================================
12. Magnific Popup
============================================================ */

if ($('.kopa-portfolio-widget .portfolio-list-item').length > 0) {

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/jquery.magnific-popup.min.js'],
        complete: function () {

            $('.kopa-portfolio-widget .portfolio-list-item').magnificPopup({
                delegate: '.popup-icon',
                type: 'image',
                tLoading: 'Loading image #%curr%...',
                mainClass: 'mfp-img-mobile',
                gallery: {
                    enabled: true,
                    navigateByImgClick: true,
                    preload: [0,1]
                },
                image: {
                    tError: '<a href="%url%">The image #%curr%</a> could not be loaded.'
                }
            });
        }   
    }]);

};

if ($('.kopa-portfolio-2-widget .portfolio-list-item').length > 0) {

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/jquery.magnific-popup.min.js'],
        complete: function () {

            $('.kopa-portfolio-2-widget .portfolio-list-item').magnificPopup({
                delegate: '.popup-icon',
                type: 'image',
                tLoading: 'Loading image #%curr%...',
                mainClass: 'mfp-img-mobile',
                gallery: {
                    enabled: true,
                    navigateByImgClick: true,
                    preload: [0,1]
                },
                image: {
                    tError: '<a href="%url%">The image #%curr%</a> could not be loaded.'
                }
            });
        }   
    }]);

};

if ($('.kopa-related-post').length > 0) {

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/jquery.magnific-popup.min.js'],
        complete: function () {

            $('.kopa-related-post').magnificPopup({
                delegate: '.popup-icon',
                type: 'image',
                tLoading: 'Loading image #%curr%...',
                mainClass: 'mfp-img-mobile',
                gallery: {
                    enabled: true,
                    navigateByImgClick: true,
                    preload: [0,1]
                },
                image: {
                    tError: '<a href="%url%">The image #%curr%</a> could not be loaded.'
                }
            });
        }   
    }]);

};

if ($('.owl-carousel-13').length > 0) {

    Modernizr.load([{
        load: [ kopa_variable.url.template_directory_uri + 'js/jquery.magnific-popup.min.js'],
        complete: function () {

            $('.owl-carousel-13').magnificPopup({
                delegate: '.popup-icon',
                type: 'image',
                tLoading: 'Loading image #%curr%...',
                mainClass: 'mfp-img-mobile',
                gallery: {
                    enabled: true,
                    navigateByImgClick: true,
                    preload: [0,1]
                },
                image: {
                    tError: '<a href="%url%">The image #%curr%</a> could not be loaded.'
                }
            });
        }   
    }]);

};

 /* =========================================================
13. Masonry
============================================================ */

    Modernizr.load([{
        load: [kopa_variable.url.template_directory_uri + 'js/masonry.pkgd.min.js',   kopa_variable.url.template_directory_uri + 'js/imagesloaded.js'],
        complete: function () {

            var jQuerymasonry1 = $('.kopa-product-list-widget').find('.kopa-masonry-wrap');
            imagesLoaded(jQuerymasonry1, function () {
                jQuerymasonry1.masonry({
                    columnWidth: 1,
                    itemSelector: '.ms-item1'
                });
                jQuerymasonry1.masonry('bindResize')
            });
        }   
    }]);

/* =========================================================
14. Pie chart
============================================================ */

Modernizr.load([
  {
    load: [kopa_variable.url.template_directory_uri + 'js/excanvas.compiled.js', kopa_variable.url.template_directory_uri + 'js/excanvas.js', kopa_variable.url.template_directory_uri + 'js/jquery.easypiechart.js'],
    complete: function () {

        var jQuerychart = $('.chart');
        jQuerychart.easyPieChart({
            barColor: '#fff',
            trackColor: "rgba(255, 255, 255, 0.30)",
            lineWidth: '10',
            lineCap: "square",
            size: '165',
            scaleColor: false,
            animate: 1000,
            onStep: function(from, to, percent) {
                $(this.el).find('.percent').text(Math.round(percent));
            }
        });
        var chart = window.chart = jQuerychart.data('easyPieChart');

    }
  }
]);

/* =========================================================
15. Flickr
============================================================ */

    if ($('#flickr-feed-1').length > 0) {
        Modernizr.load([{
            load: [ kopa_variable.url.template_directory_uri + 'js/jflickrfeed.js',  kopa_variable.url.template_directory_uri + 'js/imgliquid.js'],
            complete: function () {

                $('#flickr-feed-1 ul').jflickrfeed({
                    limit: 6,
                    qstrings: {
                        id: '78715597@N07'
                    },
                    itemTemplate: 
                        '<li class="flickr-badge-image">' +
                        '<a target="blank" href="{{link-icon}}" title="{{title}}" class="imgLiquid">' +
                        '<img src="{{image_s}}" alt="{{title}}" />' +
                        '</a>' +
                        '</li>'
                }, function (data) {
                    $('#flickr-feed-1 .imgLiquid').imgLiquid();
                });
            }
        }]);
    }


/* ============================================
16. Single-author-Filter
=============================================== */

    jQuery('.social-filter > div span').click(function () {
        if (jQuery(".social-filter ul").is(":hidden")) {
            jQuery(".social-filter ul").slideDown("slow");
        } else {
            jQuery(".social-filter ul").slideUp();
        }
    });


/* ============================================
17. Fraction Slider
=============================================== */

if (jQuery('.kopa-slider-3-widget').length > 0) {

    Modernizr.load([{
        load: [kopa_variable.url.template_directory_uri + 'js/jquery.fractionslider.min.js'],
        complete: function () {
            var fr1 = jQuery('.kopa-slider-3-widget .slider');
            fr1.fractionSlider({
                'fullWidth':            true,
                'controls':             true, 
                'pager':                true,
                'responsive':           true, 
                'dimensions':           "1354,755",
                'increase':             false,
                'pauseOnHover':         true,
                'slideEndAnimation':    true,
                'slideTransitionSpeed' : 400,
                'backgroundSpeed' : 400,
                'timeout' : 400
            });
        }
    }]);
};

if (jQuery('.kopa-slider-4-widget').length > 0) {

    Modernizr.load([{
        load: [kopa_variable.url.template_directory_uri + 'js/jquery.fractionslider.min.js'],
        complete: function () {
            var fr1 = jQuery('.kopa-slider-4-widget .slider');
            fr1.fractionSlider({
                'fullWidth':            true,
                'controls':             true, 
                'pager':                true,
                'responsive':           true, 
                'dimensions':           "1100,530",
                'increase':             false,
                'pauseOnHover':         true,
                'slideEndAnimation':    true,
                'slideTransitionSpeed' : 400,
                'backgroundSpeed' : 400,
                'timeout' : 400
            });
        }
    }]);
};


/* ============================================
18. Match height
=============================================== */

    if ($('.kopa-team-widget').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_1 = $('.kopa-team-widget').children("ul");
                
                post_1.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

    if ($('.kopa-service-2-widget').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_2 = $('.kopa-service-2-widget').children("ul");
                
                post_2.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

    if ($('.article-list-2').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_3 = $('.article-list-2').children("ul");
                
                post_3.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

    if ($('.kopa-service-4-widget').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_4 = $('.kopa-service-4-widget').children("ul");
                
                post_4.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

    if ($('.kopa-service-5-widget').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_5 = $('.kopa-service-5-widget').children("ul");
                
                post_5.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

    if ($('.kopa-service-6-widget').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_6 = $('.kopa-service-6-widget').children("ul");
                
                post_6.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

    if ($('.products').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_7 = $('.products');
                
                post_7.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

    if ($('.sv-list').length > 0) {
    
        Modernizr.load([{
            load: [kopa_variable.url.template_directory_uri + 'js/jquery.matchHeight-min.js'],
            complete: function () {

                var post_8 = $('.sv-list');
                
                post_8.each(function() {
                    $(this).children('li').matchHeight();
                });
            }
        }]);

    };

/* =========================================================
19. Fix css ie8
============================================================ */

    $("p:last-child, .e-heading p:last-child, .element-wrap blockquote:last-child, .kopa-area .widget:last-child.kopa-portfolio-widget, .kopa-area .widget:last-child.kopa-intro-4-widget, .kopa-area .widget:last-child.list-carousel, kopa-area .widget:last-child.kopa-service-widget, .kopa-area-16 .widget:last-child, .article-list-3 > ul > li:last-child").css("margin-bottom", "0");
    $(".kopa-header-bottom.style2 .kopa-main-nav .main-menu li:last-child, .main-menu.style2 > li:last-child").css("margin-right", "0");
    $(".kopa-area .widget:last-child.kopa-portfolio-widget.style2").css("margin-bottom", "90px");
    $(".kopa-team-widget > ul > li:last-child .line-right, .kopa-service-2-widget > ul > li:last-child .line-right").css("display", "none");
    $(".kopa-pagination.style1 ul li:last-child").css({
        "margin-top": "6px",
        "float": "right"
    });

/* =========================================================
20. Wow
============================================================ */
function mobilecheck() {
    if( /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent) ) {
        return false;
    }
    return true;
}
Modernizr.load([
{
  load: 'js/jquery.wow.js',
  complete: function () {
    if (mobilecheck()) {
        //Wow js animation
        new WOW().init();
        jQuery("wow").addClass("animated");
    }
  }
}
]);


/* =========================================================
21. Sticky menu
============================================================ */ 

    Modernizr.load([{
        load: [kopa_variable.url.template_directory_uri + 'js/waypoints.js', kopa_variable.url.template_directory_uri + 'js/waypoints-sticky.js'],
        complete: function () {
            jQuery('.kopa-sticky-menu').waypoint('sticky');
        }
    }]);

  /* =========================================================
10. Scroll to top
============================================================ */

    $(window).scroll(function(){
        if ($(this).scrollTop() > 200) {
            $('.scrollup').fadeIn();
        } else {
            $('.scrollup').fadeOut();
        }
    }); 

    $('.scrollup').click(function(){
        $("html, body").animate({ scrollTop: 0 }, 600);
        return false;
    });


});
