	// vertical slider
	$(document).ready(function(){

		$('.news-slide-top').css('display','block');

		$('.vertical-slider-header').slick({

			vertical: true,

						slidesToShow: 1,

						slidesToScroll: 1,

						autoplay: true,

						autoplaySpeed: 2000,

						arrows: true,

						dots: false,

						pauseOnHover: true,

						verticalSwiping: true,

						responsive: [{

										breakpoint: 768,

										settings: {

														slidesToShow: 1

										}

						}, {

										breakpoint: 520,

										settings: {

														slidesToShow: 1

										}

						}]

		});

	});