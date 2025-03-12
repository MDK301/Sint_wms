
$(document).ready(function () {

    $('.dropdown-toggle').off('click.bs.dropdown');


    // --- Topbar: Submenu mở khi di chuột vào ---
    $("#accordionTopbar .nav-item").hover(
        function () {
            $(this).find("> .dropdown-menu").stop(true, true).fadeIn(200);
        },
        function () {
            $(this).find("> .dropdown-menu").stop(true, true).fadeOut(200);
        }
    );

    $("#accordionTopbar .dropdown-submenu").hover(
        function () {
            $(this).find("> .dropdown-menu").stop(true, true).fadeIn(200);
        },
        function () {
            $(this).find("> .dropdown-menu").stop(true, true).fadeOut(200);
        }
    );

    // Ngăn menu lớn ở topbar phản ứng khi click
    $('#accordionTopbar .nav-item ').on('click', function (e) {
        e.preventDefault();
    });





    // --- SIDEBAR: Menu lớn mở khi click, submenu mở khi hover ---
    $('#accordionSidebar .nav-item.dropdown > a').on('click', function (e) {
        e.preventDefault();

        const $parent = $(this).parent();

        // Nếu menu đang mở → Đóng menu
        if ($parent.hasClass('show')) {
            $parent.removeClass('show').find('.dropdown-menu').slideUp(200);
        }
        // Nếu menu đang đóng → Mở menu
        else {
            $('#accordionSidebar .nav-item').removeClass('show').find('.dropdown-menu').slideUp(900);

        }
        
    });

    $("#accordionSidebar .dropdown-submenu").hover(
       
    );

    // Ngăn submenu trong sidebar đóng khi click vào trong
    $('#accordionSidebar .dropdown-menu').on('click', function (e) {
       
    });
});

