$(document).ready(function () {

    $('.burger').click(function () {
        $('#burger-menu,.burger').toggleClass('is-active');
        $('.navbar-link').addClass('has-text-black');
    });

    $('.burger-profile').click(function () {
        $('#profile-burger-menu,.burger-profile').toggleClass('is-active');
        $('.navbar-link').addClass('has-text-black');
        $('#profile-burger-menu').css('margin-top', '50px');
    });

    $('.burger-profile').click(function () {
        $('#edit-burger-menu,.burger-profile').toggleClass('is-active');
        $('.navbar-link').addClass('has-text-black');
        $('#edit-burger-menu').css('margin-top', '50px');
    });

    if ($(window).width() > 600) {
        $('.navbar-link').addClass('has-text-white');
    }

    $("#main-gallery").justifiedGallery({
        rowHeight: 200,
        maxRowsCount: 23,
        cssAnimation: true,
        captions: true,
        margins: 3,
        imagesAnimationDuration: 1000,
        lastRow: 'hide'
    });

    $('#profile-gallery').justifiedGallery({
        rowHeight: 175,
        lastRow: 'nojustify',
        fixedHeight: true,
        margins: 3,
        captions: true
    });

    $('#user-gallery').justifiedGallery({
        rowHeight: 200,
        lastRow: 'nojustify',
        fixedHeight: true,
        margins: 5,
        captions: true
    });

    $('#pending-gallery').justifiedGallery({
        rowHeight: 175,
        lastRow: 'nojustify',
        fixedHeight: true,
        margins: 5,
        captions: true
    });

    $('#home-photo-gallery').justifiedGallery({
        rowHeight: 128,
        lastRow: 'nojustify',
        fixedHeight: true,
        margins: 3,
        captions: true
    });
    $('#category-gallery').justifiedGallery({
        rowHeight: 225,
        lastRow:'nojustify',
        margins: 3,
        captions: true
    });

    $('#search-gallery').justifiedGallery({
        rowHeight: 175,
        lastRow: 'nojustify',
        fixedHeight: true,
        margins: 3,
        captions: true
    });

    $("#adm-gallery").justifiedGallery({
        rowHeight: 170,
        lastRow: 'nojustify',
        fixedHeight: true,
        margins: 3,
        captions: true
    });
    $("#adminsearchgallery").justifiedGallery({
        rowHeight: 170,
        lastRow: 'nojustify',
        fixedHeight: true,
        margins: 3,
        captions: true
    });

    $("#m-search").autocomplete({
        highlightItem: true,
        multiple: true,
        multipleSeperator: " ",
        source: function (request, response) {
            $.ajax({
                url: "/Home/Search",
                type: "GET",
                dataType: "json",
                data: { "term": request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item.ImageWithoutSeoTitle,
                            value: item.ImageTitle
                        };
                    }))

                }
            })
        },
        minLength: 3,
        select: function (ev, ul) {
            var items = ul.item.value;
            $('#searchbutton').click(function () {
                window.location.href = 'Search/Image/' + items;
            });
        },
        messages: {
            noResults: "",
            results: function (count) {
                return count + (count > 1 ? ' results' : ' result ') + ' found';
            }
        }
    });

    $("#adm-search").autocomplete({
        highlightItem: true,
        multiple: true,
        multipleSeperator: " ",
        source: function (request, response) {
            $.ajax({
                url: '/Admin/AdminPhotoSearchMove',
                type: "GET",
                dataType: "json",
                data: { "term": request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item.ImageWithoutSeoTitle,
                            value: item.ImageTitle
                        };
                    }))

                }
            })
        },
        minLength: 3,
        select: function (ev, ul) {
            var items = ul.item.value;
            $('#admsearch').click(function () {
                window.location.href = 'AdminPhotoSearchList/Index/' + items;
            });
        },
        messages: {
            noResults: "",
            results: function (count) {
                return count + (count > 1 ? ' results' : ' result ') + ' found';
            }
        }
    });

    $('.backTop').backTop({
        'position': 400,
        'speed': 500,
        'color':'black',
    });

});
