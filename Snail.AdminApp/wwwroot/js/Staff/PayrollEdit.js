//== Class definition

var Staff = function () {
    let dtTableBasicSalary = null,
        dtTablePayroll = null;

    let modal_basicSalary = $("#kt_modal_edit_basicSalary"),
        modal_basicSalary_form = $("#kt_modal_edit_basicSalary_form"),
        modal_basicSalary_form_buttonSubmit = $('#kt_modal_edit_basicSalary_submit'),
        modal_basicSalary_header_text = $("#kt_modal_edit_basicSalary_header_text"),
        modal_basicSalary_form_submit_text = $("#kt_modal_edit_basicSalary_submit_text");

    let editingDataRow = null;

    let validator = FormValidation.formValidation(modal_basicSalary_form[0], {
        fields: {
            kt_modal_edit_basicSalary_form_basicSalaryId: { validators: { notEmpty: { message: "vui lòng nhập lương căn bản" } } }
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {
        $.each($("a.nav-link"), (i, item) => {

            if ($(item).hasClass("active")) {
                $(item).removeClass("active");
            }
        });

        $("#navPayRollEdit").addClass("active");

        $('#dtTableBasicSalarySearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTableBasicSalary.draw();
            }
        });

        $('[name="btnCreateBasicSalary"]').click(function (e) {
            e.preventDefault();

            editingDataRow = null;
            modal_basicSalary_header_text.text("Thêm mới");
            modal_basicSalary_form_submit_text.text("Thêm");
            resetBasicSalaryForm();
            modal_basicSalary.modal("show");
        });

        $('#btnRefreshDataBasicSalary').click(function (e) {
            e.preventDefault();
            dtTableBasicSalary.draw();
        });

        $('[name="kt_modal_edit_basicSalary_form_basicSalaryId"]').on("change", function () {
            validator.revalidateField("kt_modal_edit_basicSalary_form_basicSalaryId");
        });

        $('#kt_modal_edit_basicSalary_submit').click(function (e) {
            e.preventDefault();
            let result = { appUserId: (editingData ? editingData.id: '') };
            if (validator) {
                validator.validate().then(function (e) {
                    "Valid" == e ?
                        (
                            modal_basicSalary_form_buttonSubmit.attr("data-kt-indicator", "on"), (modal_basicSalary_form_buttonSubmit.disabled = !0),

                            modal_basicSalary_form.find("select, textarea, input").each((index, el) => {
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
                                Id: (editingDataRow != null ? editingDataRow.id : null),
                                Data: result
                            },
                            App.sendDataToURL("/AppUser_BasicSalary/Save", data, "POST")

                                .then(function (res) {
                                    modal_basicSalary_form_buttonSubmit.removeAttr("data-kt-indicator");
                                    if (!res.isSuccessed) {
                                        Swal.fire(App.swalFireErrorDefaultOption(res.message))
                                    }
                                    else {
                                        Swal.fire(App.swalFireSuccessDefaultOption())
                                        editingDataRow = null;
                                        dtTableBasicSalary.draw();
                                        resetBasicSalaryForm();
                                        (modal_basicSalary_form_buttonSubmit.disabled = !1);

                                    }
                                }
                                )
                        )
                        : Swal.fire(App.swalFireErrorDefaultOption());
                });
            }
        });

        $('#btnDeleteBasicSalary').click(function (e) {
            e.preventDefault();
            let arr = [];

            $('#dtTableBasicSalary tbody input[type="checkbox"]:checked').each(function () {
                let selectedDataRow = dtTableBasicSalary.row($(this).parents('tr')).data();
                arr.push({ id: selectedDataRow.id });
            });

            if (arr.length > 0) {
                deleteBasicSalaryDataRows(arr);
            }
        });

        flatpickr('.flatpickr', flatpickrDateDefaultOption());

        App.initSelect2Base($('[name="kt_modal_edit_basicSalary_form_basicSalaryId"]'), '/BasicSalary/Filter');
    };

    let initialDatatableBasicSalary = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/AppUser_BasicSalary/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTableBasicSalarySearch').val();
            },
            filterByAppUserId: (editingData != null ? editingData.id : '')
        };
        datatableOption.order = [[1, "desc"]];
        datatableOption.columnDefs = [
            {
                "targets": [1, 2],
                "visible": false
            },
            {
                "targets": [0],
                "orderable": false
            },
            {
                "targets": [6, 7, 8, 9],
                "className": 'dt-center'
            }
        ];

        datatableOption.initComplete = function () {
            var datatablesColumnsApi = this.api().columns();

            new Promise(function (resolve, reject) {
                datatablesColumnsApi.every(function (index) {
                    var column = this;

                    if (index == 0) {
                        $(column.header()).html('<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input id="checkbox-select-all"  class="form-check-input" type ="checkbox"  value ="" >\
                                    </div>');
                    }
                });

                $('#checkbox-select-all').on('change', function (e) {
                    e.preventDefault();

                    $('#dtTableBasicSalary tbody input[type="checkbox"]').prop('checked', this.checked);

                    if (this.checked) {
                        App.showHideButtonDelete(true);
                    } else {
                        App.showHideButtonDelete(false);
                    }
                });

                resolve();
            }).then(function (res) {
                dtTableBasicSalary.columns.adjust();
            });
        };
        datatableOption.columns = [
            {
                "autoWidth": true, "title": "", "render": function (data, type, full, meta) {
                    let html = '<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input class="form-check-input" onchange="App.initevencheckbox()"  type ="checkbox" value ="" >\
                                    </div>';
                    return html;
                }
            },
            { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
            { "data": "basicSalaryId", "name": "basicSalaryId", "autoWidth": true, "title": "Id" },
            { "data": "basicSalaryCode", "name": "basicSalaryCode", "autoWidth": true, "title": "Mã" },
            { "data": "basicSalaryName", "name": "basicSalaryName", "autoWidth": true, "title": "Tên" },
            {
                "data": "basicSalaryValue", "name": "basicSalaryValue", "autoWidth": true, "title": "Số tiền",
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            },

            { "data": "strFromDate", "name": "strFromDate", "autoWidth": true, "title": "Từ ngày" },
            { "data": "strToDate", "name": "strToDate", "autoWidth": true, "title": "Đến ngày" },
            {
                "data": "isApply", "name": "isApply", "autoWidth": true, "title": "Áp dụng",
                "render": function (data, type, full, meta) {
                    let html = '<div class="form-check form-check-sm form-check-custom form-check-solid">\
                                    <input class="form-check-input" type ="checkbox" '+ (data == true ? 'checked' : '') + ' value ="" >\
                                </div>';
                    return html;
                }
            },
            {
                width: "120px", "title": "Hành động", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex justify-content-center flex-shrink-0">';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1 edit">\
					                <span class="svg-icon svg-icon-3">\
						                <svg xmlns="http://www.w3.org/2000/svg" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
							                <path d="M12.2674799,18.2323597 L12.0084872,5.45852451 C12.0004303,5.06114792 12.1504154,4.6768183 12.4255037,4.38993949 L15.0030167,1.70195304 L17.5910752,4.40093695 C17.8599071,4.6812911 18.0095067,5.05499603 18.0083938,5.44341307 L17.9718262,18.2062508 C17.9694575,19.0329966 17.2985816,19.701953 16.4718324,19.701953 L13.7671717,19.701953 C12.9505952,19.701953 12.2840328,19.0487684 12.2674799,18.2323597 Z" fill="#000000" fill-rule="nonzero" transform="translate(14.701953, 10.701953) rotate(-135.000000) translate(-14.701953, -10.701953)"></path>\
							                <path d="M12.9,2 C13.4522847,2 13.9,2.44771525 13.9,3 C13.9,3.55228475 13.4522847,4 12.9,4 L6,4 C4.8954305,4 4,4.8954305 4,6 L4,18 C4,19.1045695 4.8954305,20 6,20 L18,20 C19.1045695,20 20,19.1045695 20,18 L20,13 C20,12.4477153 20.4477153,12 21,12 C21.5522847,12 22,12.4477153 22,13 L22,18 C22,20.209139 20.209139,22 18,22 L6,22 C3.790861,22 2,20.209139 2,18 L2,6 C2,3.790861 3.790861,2 6,2 L12.9,2 Z" fill="#000000" fill-rule="nonzero" opacity="0.3"></path>\
						                </svg>\
					                </span>\
				                </a>';
                    }
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm delete">\
					                <span class="svg-icon svg-icon-3">\
						                <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
							                <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">\
								                <rect x="0" y="0" width="24" height="24"></rect>\
								                <path d="M6,8 L6,20.5 C6,21.3284271 6.67157288,22 7.5,22 L16.5,22 C17.3284271,22 18,21.3284271 18,20.5 L18,8 L6,8 Z" fill="#000000" fill-rule="nonzero"></path>\
								                <path d="M14,4.5 L14,4 C14,3.44771525 13.5522847,3 13,3 L11,3 C10.4477153,3 10,3.44771525 10,4 L10,4.5 L5.5,4.5 C5.22385763,4.5 5,4.72385763 5,5 L5,5.5 C5,5.77614237 5.22385763,6 5.5,6 L18.5,6 C18.7761424,6 19,5.77614237 19,5.5 L19,5 C19,4.72385763 18.7761424,4.5 18.5,4.5 L14,4.5 Z" fill="#000000" opacity="0.3"></path>\
							                </g>\
						                </svg>\
					                </span>\
				                </a>';
                    }
                    html += '</div> ';

                    return html;

                }
            },
        ]
        dtTableBasicSalary = $('#dtTableBasicSalary').DataTable(datatableOption);

        $('#dtTableBasicSalary tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTableBasicSalary.row($(this).parents('tr')).data();
            editingDataRow = selectedDataRow;

            $('[name="kt_modal_edit_basicSalary_form_basicSalaryId"]').append("<option value=" + selectedDataRow.basicSalaryId + " selected>" + selectedDataRow.basicSalaryName + "</option>").trigger('change');
            $('input[data-field="FromDate"]').val(selectedDataRow.strFromDate);
            $('input[data-field="ToDate"]').val(selectedDataRow.strToDate);
            $('input[data-field="IsApply"]').prop("checked", selectedDataRow.isApply);
            
            modal_basicSalary_header_text.text("Cập nhật");
            modal_basicSalary_form_submit_text.text("Cập nhật");
            modal_basicSalary.modal('show');
        });

        $('#dtTableBasicSalary tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTableBasicSalary.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteBasicSalaryDataRows([selectedDataRow]);
            }
        });
    };

    let resetBasicSalaryForm = () => {
        modal_basicSalary_form[0].reset();
        $('[name="kt_modal_edit_basicSalary_form_basicSalaryId"]').val(null).trigger('change');
    }

    function deleteBasicSalaryDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/AppUser_BasicSalary/DeleteByIds", dtTableBasicSalary, null)
            .then(function () {
                dtTableBasicSalary.draw();
                App.showHideButtonDelete(false);
            });
    }

    let initialDatatablePayroll = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/Staff/DataTableGetListSalary";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTablePayroll').val();
            },
            filterByAppUserId: (editingData != null ? editingData.id : '')
        };
        datatableOption.order = [[1, "desc"]];
        datatableOption.columnDefs = [
            {
                "targets": [1],
                "visible": false
            },
            {
                "targets": [0, 3, 4, 5, 6, 7, 8],
                "orderable": false
            },
            {
                "targets": [3, 4],
                "className": 'dt-center'
            }
        ];

        datatableOption.initComplete = function () {
            var datatablesColumnsApi = this.api().columns();

            new Promise(function (resolve, reject) {
                datatablesColumnsApi.every(function (index) {
                    var column = this;

                    if (index == 0) {
                        $(column.header()).html('<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input id="checkbox-select-all"  class="form-check-input" type ="checkbox"  value ="" >\
                                    </div>');
                    }
                });

                $('#checkbox-select-all').on('change', function (e) {
                    e.preventDefault();

                    $('#dtTablePayroll tbody input[type="checkbox"]').prop('checked', this.checked);

                    if (this.checked) {
                        App.showHideButtonDelete(true);
                    } else {
                        App.showHideButtonDelete(false);
                    }
                });

                resolve();
            }).then(function (res) {
                dtTableBasicSalary.columns.adjust();
            });
        };
        datatableOption.columns = [
            {
                "autoWidth": true, "title": "", "render": function (data, type, full, meta) {
                    let html = '<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input class="form-check-input" onchange="App.initevencheckbox()"  type ="checkbox" value ="" >\
                                    </div>';
                    return html;
                }
            },
            { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
            { "data": "name", "name": "name", "autoWidth": true, "title": "Tên" },
            { "data": "strFromDate", "name": "strFromDate", "autoWidth": true, "title": "Từ ngày" },
            { "data": "strToDate", "name": "strToDate", "autoWidth": true, "title": "Đến ngày" },

            {
                "data": "basicSalary", "name": "basicSalary", "autoWidth": true, "title": "Lương căn bản",
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            },
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
                "data": "total", "name": "total", "autoWidth": true, "title": "Tổng cộng",
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            }
        ]
        dtTablePayroll = $('#dtTablePayroll').DataTable(datatableOption);
    };

    return {
        // public functions
        init: function () {
            initialDatatableBasicSalary();
            initialDatatablePayroll();
            initialComponents();
        }
    };
}();