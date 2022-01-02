(function ($) {
    //== Class definition
    var Blog = function () {

        let initialComponents = () => {
            $("#newsletterNotification").hide();

            $('a[name="btnBooking"]').click(function (e) {
                e.preventDefault();
                console.log("test");
                App.scrollTo("#bookingSection", 1000);
            });

            $("#btnSaveNewsletter").click(function (e) {
                e.preventDefault();
                let result = {};

                $("#newsletterForm").find("select, textarea, input").each((index, el) => {
                    let fieldName = $(el).data("field");

                    if (fieldName) {

                        switch (fieldName) {

                            default:
                                result[$(el).data("field")] = $(el).val();
                        }
                    }
                });

                App.sendDataToURL("/Newsletter/Save", { Data: result }, "POST")
                    .then(function (res) {

                        if (!res.isSuccessed) {
                            $("#newsletterNotification").text("Đăng ký không thành công.");
                            $("#newsletterNotification").show(500);
                        }
                        else {
                            $("#newsletterForm")[0].reset();
                            $("#newsletterNotification").text("Đăng ký thành công.");
                            $("#newsletterNotification").show(500);
                        }
                    });
            })
        };

        return {
            // public functions
            init: function () {
                console.log("running...");
                initialComponents();
            }
        };
    }();

    $(document).ready(function () {
        Blog.init();
    })
}(jQuery))
