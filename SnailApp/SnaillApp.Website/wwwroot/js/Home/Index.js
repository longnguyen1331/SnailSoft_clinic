(function ($) {
    //== Class definition
    var Home = function () {

        let initialComponents = () => {

            $('a[name="btnBooking"]').click(function (e) {
                e.preventDefault();

                App.scrollTo("#bookingSection", 1000);
            });
        };

        return {
            // public functions
            init: function () {
                initialComponents();
            }
        };
    }();

    $(document).ready(function () {
        Home.init();
    });
}(jQuery));

