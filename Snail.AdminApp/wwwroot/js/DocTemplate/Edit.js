//== Class definition

var DocTemplate = function () {
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_name: { validators: { notEmpty: { message: "vui lòng nhập tên mẫu in" } } },
            edit_form_docTemplateTypeId: { validators: { notEmpty: { message: "vui lòng chọn loại mẫu in" } } },
            edit_form_paperSize: { validators: { notEmpty: { message: "vui lòng chọn kích cỡ" } } }
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();

            window.location.href = "/DocTemplate/Edit";
        });

        $('#edit_form_submit').click(function (e) {
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
                                        case "IsDefault":
                                            result[$(el).data("field")] = $(el).is(":checked");
                                            break;

                                        case "Content":
                                            result[$(el).data("field")] = CKEDITOR.instances.edit_form_content.getData();
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
                            App.sendDataToURL("/DocTemplate/Save", data, "POST")
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

            window.location.href = "/DocTemplate/Index";
        });

        $('#edit_form_paperSize').change(function () {
            let content = CKEDITOR.instances.edit_form_content.getData();
            /*console.log("content: " + content);*/
            let i = 20;
            let check = false;
            let temp = "";
            while( i <= 25 && !check){
                if (content[i] == 'c') {
                    check = true;
                }
                else {
                    temp += content[i];
                    i++;
                }                
            }
            if (temp != "") {
                content = content.replace('<table style="width:' + temp + 'cm">', '<table style="width:' + $(this).find(':selected').data('value') + 'cm">');
                CKEDITOR.instances.edit_form_content.setData(content);
            }
        });

        App.initSelect2Base($('#edit_form_docTemplateTypeId'), '/DocTemplateType/Filter');
                
        if (editingData != null) {
            if (editingData.docTemplateType != null) {
                $('#edit_form_docTemplateTypeId').append("<option value='" + editingData.docTemplateType.id + "' selected>" + editingData.docTemplateType.name + "</option>").trigger('change');
            }
        }

        CKEDITOR.replace('edit_form_content', {
            filebrowserImageUploadUrl: '/DocTemplate/CKEditorUploadImage',
            height: '800px'
        });
    };

    let resetForm = () => {
        edit_form[0].reset();
        $('input[name="edit_form_name"]').focus();
    }

    function deleteDataRows(id) {
        App.deleteDataConfirm({ ids: [id] }, "/DocTemplate/DeleteByIds", null, "/DocTemplate/Index")
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

