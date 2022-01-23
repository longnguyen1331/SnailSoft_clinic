//== Class definition

var ExaminationsResult = function () {
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
                            case "Examination_File":
                                let files = $(el).prop('files');
                                if (files.length > 0) {
                                    formData.append("Examination_File", files[0]);
                                }
                                break;


                            default:
                                formData.append($(el).data("field"), $(el).val());
                        }
                    }
                }),
                formData.append("Results", editorValue.getData());
                formData.append("DoctorAdvice", editorDoctorValue.getData());

                App.sendDataFileToURL("/ExaminationsResult/Save", formData, "POST")
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
            window.location.href = "/ExaminationsResult/Index";
        })
        $('[name="btnDelete"]').click(function (e) {
            e.preventDefault();
            let data = { id: $('input[data-field="Id"]').val()};
            deleteDataRows([data]);
        })

        $('.showPopupResultService').click(function (e) {
            e.preventDefault();
            App.sendDataToURL("/AppointmentService/GetById?id=" + $(this).data('id') , null, "GET")
            .then(function (res) {
                console.log(res);
                $('#serviceName').text(res.data.resultObj.serviceName);
                $('#serviceCharges').text(App.dinhDangTien(res.data.resultObj.charges));
                $('#serviceResult').html(res.data.resultObj.serviceResult);
                $('#serviceDate').text(res.data.resultObj.date);
                $('#serviceModal').modal('show'); 
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
        console.log(dataRows);
        App.cancelDataConfirm({ ids: dataRows.map((item) => item.id) }, "/ExaminationsResult/DeleteByIds", null, window.location.href)
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




