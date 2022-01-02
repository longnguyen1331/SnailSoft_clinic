//== Class definition

var Promotion = function () {
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_code: { validators: { notEmpty: { message: "vui lòng nhập mã chương trình khuyến mãi" } } },
            edit_form_name: { validators: { notEmpty: { message: "vui lòng nhập tiêu đề" } } }
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        }
    });

    let initialComponents = () => {

        $.each($("a.nav-link"), (i, item) => {

            if ($(item).hasClass("active")) {
                $(item).removeClass("active");
            }
        });

        $("#navBasicInfoEdit").addClass("active");

        edit_form_buttonSubmit.click(function (e) {
            e.preventDefault();
            let result = {};
            if (validator) {
                validator.validate().then(function (e) {

                    "Valid" == e ?
                        (
                            edit_form_buttonSubmit.attr("data-kt-indicator", "on"), (edit_form_buttonSubmit.disabled = !0),
                            edit_form.find("select, textarea, input").each((index, el) => {
                                let fieldName = $(el).data("field");

                                if (fieldName) {

                                    switch (fieldName) {
                                        case "IsApply":
                                            result[$(el).data("field")] = $(el).is(":checked");

                                            break;
                                        default:
                                            result[$(el).data("field")] = $(el).val();
                                    }
                                }
                            }),
                            data = {
                                Id: (editingData != null ? editingData.id : null),
                                Data: result
                            },
                            App.sendDataToURL("/Promotion/SaveBasicInfo", data, "POST")
                                .then(function (res) {

                                    edit_form_buttonSubmit.removeAttr("data-kt-indicator");
                                    if (!res.isSuccessed) {
                                        Swal.fire(App.swalFireErrorDefaultOption(res.message))
                                    }
                                    else {
                                        Swal.fire(App.swalFireSuccessDefaultOption());
                                        editingData = {
                                            id: res.resultObj
                                        };
                                        (edit_form_buttonSubmit.disabled = !1);
                                    }
                                }
                                )
                        )
                        : Swal.fire(App.swalFireErrorDefaultOption());
                });
            }
        });

        flatpickr('.flatpickr', flatpickrDateDefaultOption());
    };

    return {
        init: function () {
            initialComponents();
        }
    };
}();