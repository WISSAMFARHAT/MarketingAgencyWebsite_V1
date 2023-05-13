var swiper_loop = true;
var autoplay = {
    delay: $('.gallery-top').data('autoplay-delay'),
    disableOnInteraction: false,
};
if ($('.gallery-top').data('loop') === 'disable') {
    swiper_loop = false;
    autoplay = false;
}


// SLIDER
var galleryTop = new Swiper('.gallery-top', {
    spaceBetween: 0,
    autoplay: {
        delay: 4500,
        disableOnInteraction: false,
    },
    loop: true,
    loopedSlides: 3,
    thumbs: {
        swiper: galleryThumbs
    }
});

// SLIDER CONTROL
var galleryThumbs = new Swiper('.gallery-thumbs', {
    spaceBetween: 10,
    centeredSlides: true,
    slidesPerView: 3,
    touchRatio: 0.2,
    slideToClickedSlide: true,
    direction: 'vertical',
    loop: true,
    loopedSlides: 3,
    breakpoints: {
        1024: {
            slidesPerView: 3
        },
        768: {
            slidesPerView: 3
        },
        640: {
            slidesPerView: 1
        },
        320: {
            slidesPerView: 1
        }
    }
});

if ($(".gallery-top")[0]) {
    galleryThumbs.controller.control = galleryTop;
    galleryTop.controller.control = galleryThumbs;
}

