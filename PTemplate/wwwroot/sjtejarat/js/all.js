$(document).ready(function(){$(".special-sale").slick({slidesToShow:1,slidesToScroll:1,autoplay:!0,autoplaySpeed:3e3,arrows:!1,dots:!0,pauseOnHover:!1,responsive:[{breakpoint:768,settings:{slidesToShow:1}},{breakpoint:520,settings:{slidesToShow:1}}]})}),$(document).ready(function(){$(".customer-logos").slick({slidesToShow:6,slidesToScroll:2,autoplay:!0,autoplaySpeed:6e3,arrows:!1,dots:!0,pauseOnHover:!1,responsive:[{breakpoint:768,settings:{slidesToShow:4}},{breakpoint:520,settings:{slidesToShow:3}}]})}),$(document).ready(function(){$(".productPopular-slider").slick({slidesToShow:2,slidesToScroll:1,autoplay:!0,autoplaySpeed:3500,arrows:!1,dots:!1,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:1}},{breakpoint:520,settings:{slidesToShow:1}}]})}),$(document).ready(function(){$(".product-factory-slider").slick({slidesToShow:3,slidesToScroll:1,autoplay:!0,autoplaySpeed:3e3,arrows:!0,dots:!1,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:2}},{breakpoint:520,settings:{slidesToShow:1}}]})}),$(document).ready(function(){$(".certificate-factory-slider").slick({slidesToShow:6,slidesToScroll:2,autoplay:!0,autoplaySpeed:6e3,arrows:!0,dots:!1,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:3}},{breakpoint:520,settings:{slidesToShow:2}}]})}),$(document).ready(function(){$(".sarbarg-factory-slider").slick({slidesToShow:1,slidesToScroll:1,autoplay:!0,autoplaySpeed:2500,arrows:!0,dots:!0,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:1}},{breakpoint:520,settings:{slidesToShow:1}}]})}),$(document).ready(function(){$(".gallery-factory-slider").slick({slidesToShow:3,slidesToScroll:1,autoplay:!0,autoplaySpeed:6e3,arrows:!0,dots:!1,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:2}},{breakpoint:520,settings:{slidesToShow:2}}]})}),$(document).ready(function(){$(".factory-slider-side").slick({slidesToShow:1,slidesToScroll:1,autoplay:!0,autoplaySpeed:1e4,arrows:!1,dots:!1,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:1}},{breakpoint:520,settings:{slidesToShow:1}}]})}),$(document).ready(function(){$(".product-slide-about").slick({slidesToShow:1,slidesToScroll:1,autoplay:!0,autoplaySpeed:3e3,arrows:!1,dots:!0,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:1}},{breakpoint:520,settings:{slidesToShow:1}}]})}),$(document).ready(function(){$(".product-related-slider").slick({slidesToShow:3,slidesToScroll:1,autoplay:!0,autoplaySpeed:3e3,arrows:!0,dots:!1,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:1}},{breakpoint:520,settings:{slidesToShow:1}}]})});
$(document).ready(function(){$(".product-blog-milgerd-slider").slick({slidesToShow:2,slidesToScroll:1,autoplay:!0,autoplaySpeed:5e3,arrows:!0,dots:!1,pauseOnHover:!1,responsive:[{breakpoint:768,settings:{slidesToShow:2}},{breakpoint:520,settings:{slidesToShow:1}}]})})
$(document).ready(function(){$(".city-factory-slider").slick({slidesToShow:4,slidesToScroll:1,autoplay:!0,autoplaySpeed:5e3,arrows:!0,dots:!1,pauseOnHover:!1,responsive:[{breakpoint:768,settings:{slidesToShow:3}},{breakpoint:520,settings:{slidesToShow:1}}]})})
  /* add jquery button for checkbox in page-prices  */
    $(document).ready(function(){
        $('input[type="checkbox"]').click(function(){
            if($("#searchform input:checkbox:checked").length){
                $('.do-filter').css("display", "block");
            }
            else{
                $('.do-filter').css("display", "none");
            }
        });
    });
    
    /* add width-filter-page-prices && by scroll add button filter  */
    $(document).ready(function() {
	$(window).scroll(function() {
        
    	if ($(window).scrollTop() >= 400 && $(window).scrollTop() <= ($(document).height() - 600)) {
        	$('.openbtn').removeClass('hide');
        }
        else {
        	$('.openbtn').addClass('hide');
        }
    });

$('.openbtn').on('click', function() { 
     if($('.sidepanel').hasClass('hideContentfilter'))
    {
    	$('.sidepanel').addClass('showContentfilter');
    		$('.sidepanel').removeClass('hideContentfilter');
    } else{
 	$('.sidepanel').addClass('hideContentfilter');
    		$('.sidepanel').removeClass('showContentfilter');
    }
    
});
$('.closebtn').on('click', function() { 
    if($('.sidepanel').hasClass('showContentfilter')){
        	$('.sidepanel').addClass('hideContentfilter');
    		$('.sidepanel').removeClass('showContentfilter');
    }
});
});

 $(document).ready(function() {
var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].onclick = function(){
        this.classList.toggle("active");
        this.nextElementSibling.classList.toggle("show");
  }
}
});



$(document).ready(function(){$(".gallery-city-slider").slick({slidesToShow:5,slidesToScroll:1,autoplay:!0,autoplaySpeed:6e3,arrows:!0,dots:!1,pauseOnHover:!0,responsive:[{breakpoint:768,settings:{slidesToShow:3}},{breakpoint:520,settings:{slidesToShow:2}}]})})