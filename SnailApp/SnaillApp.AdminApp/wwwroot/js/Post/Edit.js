//== Class definition

var Post = function () {
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_name: { validators: { notEmpty: { message: "vui lòng nhập tên bài viết" } } },
            edit_form_postTypeId: { validators: { notEmpty: { message: "vui lòng chọn chuyên mục" } } },
            edit_form_postStatusId: { validators: { notEmpty: { message: "vui lòng chọn trạng thái" } } }            
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {
        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();

            window.location.href = "/Post/Edit";
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
                                case "Content":
                                    formData.append($(el).data("field"), CKEDITOR.instances.edit_form_content.getData());
                                    break;
                                case "ThumbnailImage":
                                    let files = $(el).prop('files');
                                    if (files.length > 0) {
                                        formData.append("ThumbnailImage", files[0]);
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
                            App.sendDataFileToURL("/Post/Save", formData, "POST")
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

            window.location.href = "/Post/Index";
        });

        $('#btnDeleteThumnailImage').click(function (e) {
            e.preventDefault();

            $("#edit_form_thumbnailImage").val('');
            $("#edit_form_ShowThumbnailImage").attr("src", "");

            if (editingData != null && editingData.id != null) {
                App.sendDataToURL("/Post/DeleteThumbnailImageByPostId?postId=" + editingData.id, null, "GET")
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            Swal.fire(App.swalFireErrorDefaultOption(res.message));
                        }
                        else {
                            $("#edit_form_ShowThumbnailImage").attr("src", res.resultObj);
                        }
                    });
            }
        });
        
        App.initSelect2Base($('#edit_form_postTypeId'), '/PostType/Filter');
        App.initSelect2Base($('#edit_form_postStatusId'), '/PostStatus/Filter');
                
        if (editingData != null) {
            if (editingData.postType != null) {
                $('#edit_form_postTypeId').append("<option value='" + editingData.postType.id + "' selected>" + editingData.postType.name + "</option>").trigger('change');
            }
            if (editingData.postStatus != null) {
                $('#edit_form_postStatusId').append("<option value='" + editingData.postStatus.id + "' selected>" + editingData.postStatus.name + "</option>").trigger('change');
            }
        }

        CKEDITOR.replace('edit_form_content', {
            filebrowserImageUploadUrl: '/Post/CKEditorUploadImage',
            height: '300px'
        });
    };

    let previewImage = (event) => {
        var reader = new FileReader();
        reader.onload = function () {
            var output = document.getElementById('edit_form_ShowThumbnailImage');
            output.src = reader.result;
        };
        reader.readAsDataURL(event.target.files[0]);
    }

    function deleteDataRows(id) {
        App.deleteDataConfirm({ ids: [id] }, "/Post/DeleteByIds", null, "/Post/Index")
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

