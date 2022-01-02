//== Class definition

var Slide = function () {
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_code: { validators: { notEmpty: { message: "vui lòng nhập Header" } } },
            edit_form_name: { validators: { notEmpty: { message: "vui lòng nhập tiêu đề" } } }
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();

            window.location.href = "/Slide/Edit";
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
                                case "Description":
                                    formData.append($(el).data("field"), CKEDITOR.instances.edit_form_description.getData());
                                    break;
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
                            App.sendDataFileToURL("/Slide/Save", formData, "POST")
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
            $('input[name="edit_form_name"]').focus();
        });

        $('[name="btnDelete"]').click(function (e) {
            e.preventDefault();
         
            if (editingData != null) {
                deleteDataRows(editingData.id);
            }
        });

        $('[name="btnBackToList"]').click(function (e) {
            e.preventDefault();

            window.location.href = "/Slide/Index";
        });

        $('#btnDeleteImage').click(function (e) {
            e.preventDefault();

            $("#edit_form_Image").val('');
            $("#edit_form_ShowImage").attr("src", "");

            if (editingData != null && editingData.id != null) {
                App.sendDataToURL("/Slide/DeleteImageBySlideId?slideId=" + editingData.id, null, "GET")
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
        
        CKEDITOR.replace('edit_form_description', {
            height: '800px'
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
        App.deleteDataConfirm({ ids: [id] }, "/Slide/DeleteByIds", null, "/Slide/Index")
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

