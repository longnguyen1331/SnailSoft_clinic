//== Class definition

var AppointmentService = function () {
    let edit_form = $("#edit_form");
    let initialComponents = () => {
      
        $('[name="btnUpdate"]').click(function (e) {
            e.preventDefault();
            let formData = new FormData();
            if (checkDataUpdate()) {
                edit_form.find("select, textarea, input").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        
                        switch (fieldName) {
                            case "ServiceFile":
                                let files = $(el).prop('files');
                                if (files.length > 0) {
                                    formData.append("ServiceFile", files[0]);
                                }
                                break;

                            case "IsDefault":
                                formData.append($(el).data("field"), $(el).is(':checked'));
                                break;


                            default:
                                formData.append($(el).data("field"), $(el).val());
                        }
                    }
                }),
                formData.append("ServiceResult", editorValue.getData());

                App.sendDataFileToURL("/AppointmentService/Save", formData, "POST")
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
            window.location.href = "/AppointmentService/Index";
        })

        $('[name="btnDelete"]').click(function (e) {
            e.preventDefault();
            let data = { id: $('input[data-field="Id"]').val()};
            deleteDataRows([data]);
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
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/AppointmentService/DeleteByIds", null, window.location.href)
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




