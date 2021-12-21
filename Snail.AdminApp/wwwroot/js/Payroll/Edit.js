//== Class definition

var Payroll = function () {
    let dtTablePayrollDetail = null;
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_code: { validators: { notEmpty: { message: "vui lòng nhập mã" } } },
            edit_form_name: { validators: { notEmpty: { message: "vui lòng nhập tên" } } },
            edit_form_fromDate: { validators: { notEmpty: { message: "vui lòng nhập ngày bắt đầu" } } },
            edit_form_toDate: { validators: { notEmpty: { message: "vui lòng nhập ngày kết thúc" } } }
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();

            window.location.href = "/Payroll/Edit";
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
                                       
                                        default:
                                            result[$(el).data("field")] = $(el).val();
                                    }
                                }
                            }),
                            data = {
                                Id: (editingData != null ? editingData.id : null),
                                Data: result
                            },
                            App.sendDataToURL("/Payroll/Save", data, "POST")
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

                                        dtTablePayrollDetail.draw();

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

            window.location.href = "/Payroll/Index";
        });

        $('#btnCalculatePayroll').click(function (e) {
            e.preventDefault();

            if (editingData) {
                App.sendDataToURL("/Payroll/CalculatePayroll", { id: editingData ? editingData.id : "" }, "POST")
                    .then(function (res) {

                        edit_form_buttonSubmit.removeAttr("data-kt-indicator");
                        if (!res.isSuccessed) {
                            Swal.fire(App.swalFireErrorDefaultOption(res.message))
                        }
                        else {
                            dtTablePayrollDetail.draw();
                            Swal.fire(App.swalFireSuccessDefaultOption());                            
                            (edit_form_buttonSubmit.disabled = !1);
                        }
                    });
            }
            else {
                Swal.fire(App.swalFireErrorDefaultOption("Bạn phải lưu thông tin bảng lương trước khi tính toán tiền lương."))
            } 
        });

        flatpickr('.flatpickr', flatpickrDateDefaultOption());
    };

    let initialDatatablePayrollDetail = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/PayrollDetail/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTablePayrollDetailSearch').val();
            },
            filterByPayrollId: function () {
                return editingData ? editingData.id : 0;
            }
        };
        datatableOption.order = [[1, "desc"]];
        datatableOption.columnDefs = [
            {
                "targets": [1],
                className: 'dt-body-center',
                "visible": false
            },
            {
                "targets": [0, 4],
                className: 'dt-body-center',
                "orderable": false
            }
        ];

        datatableOption.initComplete = function () {
            var datatablesColumnsApi = this.api().columns();

            new Promise(function (resolve, reject) {
                datatablesColumnsApi.every(function (index) {
                    var column = this;

                    if (index == 0) {
                        $(column.header()).html('<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input id="checkbox-select-all" class="form-check-input" type ="checkbox"  value ="" >\
                                    </div>');
                    }
                });

                $('#checkbox-select-all').on('change', function (e) {
                    e.preventDefault();

                    $('#dtTablePayrollDetail tbody input[type="checkbox"]').prop('checked', this.checked);

                    if (this.checked) {
                        App.showHideButtonDelete(true);
                    } else {
                        App.showHideButtonDelete(false);
                    }
                });

                resolve();
            }).then(function (res) {
                dtTablePayrollDetail.columns.adjust();
            });
        };
        datatableOption.columns = [
            {
                "autoWidth": true, "title": "", "render": function (data, type, full, meta) {
                    let html = '<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input class="form-check-input" onchange="App.initevencheckbox()" type ="checkbox" value ="" >\
                                    </div>';
                    return html;
                }
            },
            { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
            { "data": "appUserLastName", "name": "appUserLastName", "autoWidth": true, "title": "Họ" },
            { "data": "appUserFirstName", "name": "appUserFirstName", "autoWidth": true, "title": "Tên" },

            {
                "data": "discount", "name": "discount", "autoWidth": true, "title": "Giảm giá",
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            },


            {
                "data": "commission", "name": "commission", "autoWidth": true, "title": "Hoa hồng",
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            {
                "data": "basicSalary", "name": "basicSalary", "autoWidth": true, "title": "Lương căn bản",
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            {
                "data": "total", "name": "total", "autoWidth": true, "title": "Tổng cộng",
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            }
        ]
        dtTablePayrollDetail = $('#dtTablePayrollDetail').DataTable(datatableOption);
    };

    function deleteDataRows(id) {
        App.deleteDataConfirm({ ids: [id] }, "/Payroll/DeleteByIds", null, "/Payroll/Index")
            .then(function () {
                App.showHideButtonDelete(false);
            });
    }

    return {
        // public functions
        init: function () {
            initialComponents();
            initialDatatablePayrollDetail();
        }
    };
}();

