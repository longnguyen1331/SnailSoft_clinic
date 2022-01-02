(function ($) {

    $(document).ready(function () {
        $("#bookingNotification").hide();

        $("#btnSaveBooking").click(function (e) {
            e.preventDefault();
            let result = { };

            $("#bookingForm").find("select, textarea, input").each((index, el) => {
                let fieldName = $(el).data("field");

                if (fieldName) {

                    switch (fieldName) {

                        default:
                            result[$(el).data("field")] = $(el).val();
                    }
                }
            });

            App.sendDataToURL("/Booking/Save", {Data: result }, "POST")
                .then(function (res) {

                    if (!res.isSuccessed) {
                        $("#bookingNotification").text("Đặt lịch không thành công.");
                        $("#bookingNotification").show(500);
                    }
                    else {
                        $("#bookingForm")[0].reset();
                        $("#bookingNotification").text("Đặt lịch thành công.");
                        $("#bookingNotification").show(500);
                    }
                });
        })
    })
}(jQuery))