//== Class definition

var Supplier = function () {
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_userName: { validators: { notEmpty: { message: "vui lòng nhập tên truy cập" } } }
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

        $("#navSecurityEdit").addClass("active");

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
                                        case "IsActive":
                                        case "IsStillInUse":
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
                            App.sendDataToURL("/Supplier/SaveSecurity", data, "POST")
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

        App.initSelect2Base($('[name="edit_form_appRoleIds"]'), '/AppRole/Filter', { selectedFields: ["code", "name"] });

        $('[name="edit_form_appRoleIds"]').val(null).trigger("change");
        if (editingData && editingData.appRoles && editingData.appRoles.length > 0) {
            let htmlOption = "";
            editingData.appRoles.forEach((item) => {
                htmlOption += "<option value=" + item.code + " selected>" + item.name + "</option>";
            });

            $('[name="edit_form_appRoleIds"]').append(htmlOption).trigger('change');
        }
    };

    return {
        init: function () {
            initialComponents();
        }
    };
}();