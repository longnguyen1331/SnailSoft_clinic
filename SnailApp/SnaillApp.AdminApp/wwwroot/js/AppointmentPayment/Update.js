//== Class definition

var AppointmentPayment = function () {
    let edit_form = $("#edit_form");
    let initialComponents = () => {
        $('.vnd').autoNumeric('init', initialTienVNDOption());

        $('[name="btnUpdate"]').click(function (e) {
            e.preventDefault();
            let result = {};
            if (checkDataUpdate()) {
                edit_form.find("select, textarea, input").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        switch (fieldName) {
                            case "AmountDue":
                            case "Total":
                                result[$(el).data("field")] = $(el).autoNumeric('get');
                                break;
                            default:
                                result[$(el).data("field")] = $(el).val();
                        }
                    }
                }),
                 App.sendDataToURL("/AppointmentPayment/Save", result, "POST")
                .then(function (res) {
                    if (!res.isSuccessed) {
                        App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);
                    }
                    else {
                        window.location.reload();
                    }
                })
                }
            }
        )
        $('[name="btnBack"]').click(function (e) {
            e.preventDefault();
            window.location.href = "/AppointmentPayment/Index";
        })

        $('[name="btnDelete"]').click(function (e) {
            e.preventDefault();
            let data = { id: $('input[data-field="Id"]').val()};
            deleteDataRows([data]);
        })

        edit_form.find('input[data-field="Discount"]').change(function () {
            let discount = parseFloat($(this).val()),
                total = parseFloat(edit_form.find('input[data-field="Total"]').autoNumeric('get')),
                amountDue = 0;
            amountDue = total - (total * (discount / 100));
            edit_form.find('input[data-field="AmountDue"]').autoNumeric('set', amountDue);
        });

        $('.showPopupResultService').click(function (e) {
            e.preventDefault();
            App.sendDataToURL("/AppointmentService/GetById?id=" + $(this).data('id'), null, "GET")
                .then(function (res) {
                    console.log(res);
                    $('#serviceName').text(res.data.resultObj.serviceName);
                    $('#serviceCharges').text(App.dinhDangTien(res.data.resultObj.charges));
                    $('#serviceResult').html(res.data.resultObj.serviceResult);
                    $('#serviceDate').text(res.data.resultObj.date);
                    $('#serviceModal').modal('show');
                })
        })



        $('button[name="btnCheckOut"]').click(function (e) {
            e.preventDefault();
            App.sendDataToURL("/Appointment/UpdateStatusCheckout", { id: $('input[data-field="AppointmentId"]').val() }, "POST", true, 'body')
                .then(function (res) {
                    if (!res.isSuccessed) {
                        App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);
                    }
                    else {
                        window.location.reload();
                    }
                })
        })

    };

    function checkDataUpdate() {

        if ($('input[data-field="Date"]').val() == '') {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter date");
            return false;
        }
        return true;
    }

    function deleteDataRows(dataRows) {
        App.cancelDataConfirm({ ids: dataRows.map((item) => item.id) }, "/AppointmentPayment/DeleteByIds", null, window.location.href)
            .then(function () {
                App.showHideButtonDelete(false);
            });
    }


    return {
        // public functions
        init: function () {
            initialComponents();
        }
    };
}();




