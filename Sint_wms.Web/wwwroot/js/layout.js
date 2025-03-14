
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
    //$('#accordionTopbar .nav-item ').on('click', function (e) {
    //    e.preventDefault();
   // });





    // --- SIDEBAR: Menu lớn mở khi click, submenu mở khi hover ---
    $('#accordionSidebar .nav-item .dropdown > a').on('click', function (e) {
        e.preventDefault();

        const $parent = $(this).parent();

        // Nếu menu đang mở → Đóng menu
        if ($parent.hasClass('show')) {
            $parent.removeClass('show');
        }
        // Nếu menu đang đóng → Mở menu
        else {
            $('#accordionSidebar .nav-item').removeClass('show');

        }
        
    });

    $('a[data-load]').on('click', function (e) {
        e.preventDefault();
        let url = $(this).attr('href');
        loadContent(url);
        window.history.pushState(null, '', url); // Cập nhật URL mà không tải lại trang
    });

    // Quay lại trang trước trong lịch sử trình duyệt
    window.onpopstate = function () {
        loadContent(location.pathname);
    };
    function loadContent(url) {
        $('#content-container').fadeOut(200, function () {
            $.get(url).done(function (data) {
                $('#content-container').html(data).fadeIn(200);
            })
                .fail(function () {
                    $('#content-container').html('<div class="alert alert-danger">Page not found!</div>').fadeIn(200);
                });
        });
    }
    // --- AJAX loading ---
    $(document).on('click', '.ajax-link', function (e) {
        e.preventDefault();
        let url = $(this).attr('href');

        // Kiểm tra nếu URL có chứa "/#", thì loại bỏ nó
        if (url.includes('/#')) {
            url = url.replace('/#', '');
        }

        loadContent(url);
        window.history.pushState(null, '', url); // Cập nhật URL mà không tải lại trang
    });

    window.onpopstate = function () {
        loadContent(location.pathname);
    };

});


