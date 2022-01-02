(function ($) {
    //== Class definition
    var Contact = function () {

        let initialComponents = () => {
            $("#contactNotification").hide();

            $("#btnSaveContact").click(function (e) {
                e.preventDefault();
                let result = {};

                $("#contactForm").find("select, textarea, input").each((index, el) => {
                    let fieldName = $(el).data("field");

                    if (fieldName) {

                        switch (fieldName) {

                            default:
                                result[$(el).data("field")] = $(el).val();
                        }
                    }
                });

                App.sendDataToURL("/Contact/Save", { Data: result }, "POST")
                    .then(function (res) {

                        if (!res.isSuccessed) {
                            $("#contactNotification").text("Nhắn tin không thành công.");
                            $("#contactNotification").show(500);
                        }
                        else {
                            $("#contactForm")[0].reset();
                            $("#contactNotification").text("Nhắn tin thành công.");
                            $("#contactNotification").show(500);
                        }
                    });
            })
        };

        return {
            // public functions
            init: function () {
                initialComponents();
            }
        };

        $(document).ready(function () {
            Contact.init();
        });
    }();
}(jQuery));
