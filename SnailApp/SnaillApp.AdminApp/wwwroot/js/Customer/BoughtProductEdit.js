//== Class definition

var Customer = function () {

    let initialComponents = () => {

        $.each($("a.nav-link"), (i, item) => {

            if ($(item).hasClass("active")) {
                $(item).removeClass("active");
            }
        });

        $("#navBoughtProductEdit").addClass("active");
    };

    return {
        init: function () {
            initialComponents();
        }
    };
}();