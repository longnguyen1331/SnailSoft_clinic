//== Class definition

var ExaminationsResult = function () {
    let edit_form = $("#edit_form");
    let initialComponents = () => {
      
        $('[name="btnUpdate"]').click(function (e) {
            e.preventDefault();
            let result = {};
            if (checkDataUpdate()) {
                edit_form.find("select, textarea, input").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        switch (fieldName) {
                            default:
                                result[$(el).data("field")] = $(el).val();
                        }
                    }
                }),
                result["Results"] = editorValue.getData(),
                    App.sendDataToURL("/ExaminationsResult/Save", result, "POST")
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
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/ExaminationsResult/DeleteByIds", null, window.location.href)
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




