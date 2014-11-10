$(document).ready(function () {

    $(window).scroll(function (scroll) {
        var pxFromTop = $(document).scrollTop();
        var newSize;
        
        if (pxFromTop > 110) {
            pxFromTop = 110;
        }

        newSize = 200 - pxFromTop;
        //newMargin = 300 - pxFromTop*2.7272727272;


        $("#logo").css({
            width: newSize,
            height: newSize
        });

        //$("#pageTitle").css({
        //    marginLeft: newMargin
        //});
    });


});