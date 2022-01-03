﻿//== Class definition

var Testimonial = function () {
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_code: { validators: { notEmpty: { message: "vui lòng nhập tên" } } },
            edit_form_name: { validators: { notEmpty: { message: "vui lòng nhập tiêu đề" } } },
            edit_form_description: { validators: { notEmpty: { message: "vui lòng nhập nội dung" } } }
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();

            window.location.href = "/Testimonial/Edit";
        });

        $('#edit_form_submit').click(function (e) {
            e.preventDefault();
            
            if (validator) {
                validator.validate().then(function (e) {
                    let formData = new FormData();
                    if (editingData != null) {
                        formData.append("id", (editingData != null ? editingData.id : null));
                    }

                    edit_form.find("select, textarea, input").each((index, el) => {
                        let fieldName = $(el).data("field");

                        if (fieldName) {
                            switch (fieldName) {
                                case "Image":
                                    let files = $(el).prop('files');
                                    if (files.length > 0) {
                                        formData.append("Image", files[0]);
                                    }

                                    break;
                                default:
                                    if ($(el).data("field")) {
                                        formData.append($(el).data("field"), $(el).val());
                                    }
                            }
                        }
                    });

                    "Valid" == e ?
                        (
                            edit_form_buttonSubmit.attr("data-kt-indicator", "on"), (edit_form_buttonSubmit.disabled = !0),
                            App.sendDataFileToURL("/Testimonial/Save", formData, "POST")
                                .then(function (res) {

                                    edit_form_buttonSubmit.removeAttr("data-kt-indicator");
                                    if (!res.isSuccessed) {
                                        Swal.fire(App.swalFireErrorDefaultOption(res.message))
                                    }
                                    else {
                                        showNotificationAndAskAddNewModal();
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
            $('input[name="edit_form_code"]').focus();
        });

        $('[name="btnDelete"]').click(function (e) {
            e.preventDefault();
         
            if (editingData != null) {
                deleteDataRows(editingData.id);
            }
        });

        $('[name="btnBackToList"]').click(function (e) {
            e.preventDefault();

            window.location.href = "/Testimonial/Index";
        });

        $('#btnDeleteImage').click(function (e) {
            e.preventDefault();

            $("#edit_form_image").val('');
            $("#edit_form_ShowImage").attr("src", "");

            if (editingData != null && editingData.id != null) {
                App.sendDataToURL("/Testimonial/DeleteImageByTestimonialId?testimonialId=" + editingData.id, null, "GET")
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            Swal.fire(App.swalFireErrorDefaultOption(res.message));
                        }
                        else {
                            $("#edit_form_ShowImage").attr("src", res.resultObj);
                        }
                    });
            }
        });
    };

    let previewImage = (event) => {
        var reader = new FileReader();
        reader.onload = function () {
            var output = document.getElementById('edit_form_ShowImage');
            output.src = reader.result;
        };
        reader.readAsDataURL(event.target.files[0]);
    }

    function deleteDataRows(id) {
        App.deleteDataConfirm({ ids: [id] }, "/Testimonial/DeleteByIds", null, "/Testimonial/Index")
            .then(function () {
                App.showHideButtonDelete(false);
            });
    }

    return {
        // public functions
        init: function () {
            initialComponents();
        },
        previewImage: previewImage
    };
}();
