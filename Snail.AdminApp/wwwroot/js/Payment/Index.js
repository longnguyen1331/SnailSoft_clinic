﻿//== Class definition

var Payment = function () {
    let dtTable = null;
    let modal = $("#kt_modal_edit"),
        modal_form = $("#kt_modal_edit_form"),
        modal_form_buttonSubmit = $('#kt_modal_edit_submit'),
        modal_header_text = $("#kt_modal_edit_header_text"),
        modal_form_submit_text = $("#kt_modal_edit_submit_text")
    let editingDataRow = null;
    
    let validator = FormValidation.formValidation(modal_form[0], {
        fields: {
            kt_modal_edit_form_total: { validators: { notEmpty: { message: "vui lòng nhập số tiền" } } },
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {
        $('.tien-VND').autoNumeric('init', initialTienVNDOption());

        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();

            editingDataRow = null;
            modal_header_text.text("Thêm một phiếu chi");
            modal_form_submit_text.text("Thêm");
            resetForm();
            modal.modal("show");
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

   
        $('#kt_modal_edit_submit').click(function (e) {
            e.preventDefault();
            let result = {};
            if (validator) {
                validator.validate().then(function (e) {
                    "Valid" == e ?
                        (
                            modal_form_buttonSubmit.attr("data-kt-indicator", "on"), (modal_form_buttonSubmit.disabled = !0),

                            modal_form.find("select, input").each((index, el) => {
                                let type = $(el).attr('type');
                                let isVNDFormat = $(el).hasClass('tien-VND');
                                let colName = $(el).data("field");

                                if (!App.isNullOrEmpty(colName)) {
                                    switch (colName) {
                                        case "CustomerId":
                                            if (!App.isNullOrEmpty($(el).val())) {
                                                result[colName] = $(el).val();
                                            }
                                            break;

                                        default:
                                            result[colName] = (type == 'checkbox' ? $(el).is(':checked') : (isVNDFormat ? $(el).autoNumeric('get') : $(el).val()));
                                            break;
                                    }
                                }
                            }),

                            data = {
                                Id: (editingDataRow != null ? editingDataRow.id : null),
                                Data: result
                            },
                            console.log(data),
                            App.sendDataToURL("/Payment/Save", data, "POST")

                            .then(function (res)
                            {
                                modal_form_buttonSubmit.removeAttr("data-kt-indicator");
                                if (!res.isSuccessed) {
                                    Swal.fire({
                                        text: res.message,
                                        icon: "error",
                                        buttonsStyling: !1,
                                        confirmButtonText: "Đóng !",
                                        customClass: { confirmButton: "btn btn-primary" },
                                    })
                                }
                                else {
                                    Swal.fire({
                                        title: 'Thông báo',
                                        text: 'Cập nhật thành công.',
                                        type: 'success',
                                        confirmButtonText: 'Đóng!',
                                        customClass: { confirmButton: "btn btn-primary" },
                                        icon: 'success',
                                        timer: 1000
                                    })
                                    editingDataRow = null;
                                    dtTable.draw();
                                    resetForm();
                                }
                            }
                        )
                        )
                    : Swal.fire({
                        text: "Có lỗi xảy ra vui lòng kiểm tra lại.",
                        icon: "error",
                        buttonsStyling: !1,
                        confirmButtonText: "Đóng !",
                        customClass: { confirmButton: "btn btn-primary" },
                    });
                });
            }
            $('input[name="kt_modal_edit_form_code"]').focus();
        });

        $('#btnDelete').click(function (e) {
            e.preventDefault();
            let arr = [];

            $('#dtTable tbody input[type="checkbox"]:checked').each(function () {
                let selectedDataRow = dtTable.row($(this).parents('tr')).data();
                arr.push({ id: selectedDataRow.id });
            });

            if (arr.length > 0) {
                deleteDataRows(arr);
            }
        });

    };



    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/Payment/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTableSearch').val();
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
                "targets": [0,8],
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

                    $('#dtTable tbody input[type="checkbox"]').prop('checked', this.checked);

                    if (this.checked) {
                        App.showHideButtonDelete(true);
                    } else {
                        App.showHideButtonDelete(false);
                    }
                });

                resolve();
            }).then(function (res) {
                dtTable.columns.adjust();
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
            {
                "data": "code", "name": "code", "autoWidth": true, "title": "Mã", "render": function (data, type, full, meta) {
                    return '<div class="d-flex justify-content-start flex-column">\
		                <a href="#!" onClick="openModalDetail('+full.id+')" class="fw-bolder text-hover-primary fs-6">' + data + '</a>\
	                </div>';
                }
            },
            { "data": "dateString", "name": "dateString", "autoWidth": true, "title": "Ngày" },
            {
                "data": "customerName", "name": "customerName", "autoWidth": true, "title": "Khách hàng", "render": function (data, type, full, meta) {
                    return '<div class="d-flex justify-content-start flex-column">\
		                <a href=" '+(full.customerId > 0 ?  "/Customer/Edit?id=" + full.customerId  : "#!")+'" class="fw-bolder text-hover-primary fs-6">'+data+'</a>\
	                </div>';
                }
            },
            {
                "data": "saleStaffName", "name": "saleStaffName", "autoWidth": true, "title": "Nhân viên bán hàng", "render": function (data, type, full, meta) {
                    return '<span class="text-muted">' + data + '</span>';
                }
            },
            {
                "data": "totalMoney", "name": "totalMoney", "autoWidth": true, "title": "Tổng tiền","render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            { "data": "description", "name": "description", "autoWidth": true, "title": "Nội dung" },
            {
                width: "120px", "title": "Hành động", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex justify-content-center flex-shrink-0">';
                    if (user.roles.isAllowEdit == true) {

                        html += '<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1 print">\
					                <span class="svg-icon svg-icon-3">\
						    			<!--begin::Svg Icon | path:/var/www/preview.keenthemes.com/metronic/releases/2021-05-14-112058/theme/html/demo2/dist/../src/media/svg/icons/Devices/Printer.svg--><svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
                                        <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" >\
                                            <rect x="0" y="0" width="24" height="24"/>\
                                            <path d="M16,17 L16,21 C16,21.5522847 15.5522847,22 15,22 L9,22 C8.44771525,22 8,21.5522847 8,21 L8,17 L5,17 C3.8954305,17 3,16.1045695 3,15 L3,8 C3,6.8954305 3.8954305,6 5,6 L19,6 C20.1045695,6 21,6.8954305 21,8 L21,15 C21,16.1045695 20.1045695,17 19,17 L16,17 Z M17.5,11 C18.3284271,11 19,10.3284271 19,9.5 C19,8.67157288 18.3284271,8 17.5,8 C16.6715729,8 16,8.67157288 16,9.5 C16,10.3284271 16.6715729,11 17.5,11 Z M10,14 L10,20 L14,20 L14,14 L10,14 Z" fill="#000000"/>\
                                            <rect fill="#000000" opacity="0.3" x="8" y="2" width="8" height="2" rx="1"/>\
                                        </g>\
					                </span>\
				                </a>\
                                <a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1 edit">\
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
                    html += '</div>';

                    return html;

                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);


        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            console.log(selectedDataRow);
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });

        $('#dtTable tbody').on('click', 'a.print', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                print(selectedDataRow);
            }
        });
    };


    function print(data) {

        //Get template phiếu thu 
        App.sendDataToURL("/DocTemplate/GetContentByDocTemplateTypeCode", { Id: null, Data: { DocTemplateCode: "PC" } }, "POST")
            .then(function (res) {

                if (res.isSuccessed && res.resultObj != null) {
                    $("#page-print").empty();

                    var date = new Date();
                    res.resultObj.content = res.resultObj.content.replace('{{ten_cua_hang}}', res.resultObj.storeName);
                    res.resultObj.content = res.resultObj.content.replace('{{dia_chi_cua_hang}}', res.resultObj.storeAddress);
                    res.resultObj.content = res.resultObj.content.replace('{{dien_thoai_cua_hang}}', res.resultObj.storePhone);
                    res.resultObj.content = res.resultObj.content.replace('{{ngay_chi}}', data.dateString);
                    res.resultObj.content = res.resultObj.content.replace('{{so_phieu}}', data.code);
                    res.resultObj.content = res.resultObj.content.replace('{{nguoi_chi}}', data.saleStaffName);
                    res.resultObj.content = res.resultObj.content.replace('{{nguoi_nhan}}', data.customerName);
                    res.resultObj.content = res.resultObj.content.replace('{{ghi_chu}}', data.description);
                    res.resultObj.content = res.resultObj.content.replace('{{ngay_in}}', date.getDate());
                    res.resultObj.content = res.resultObj.content.replace('{{thang_in}}', date.getMonth() + 1);
                    res.resultObj.content = res.resultObj.content.replace('{{nam_in}}', date.getFullYear());
                    res.resultObj.content = res.resultObj.content.replace('{{tong_tien}}', Util.dinhDangTien(data.totalMoney));
                    res.resultObj.content = res.resultObj.content.replace('{{noi_dung_chi}}', "Chi tiền theo phiếu " + data.code);
                    $("#page-print").html(res.resultObj.content).show();
                    $("#page-print").print();
                    $("#page-print").hide();

                }
            }
            )
    }


    function initSelect2() {
        App.initSelect2Base($('[name="kt_form_edit_customer"]'), '/Customer/Filter', { append0 : true});
    }

    let resetForm = () => {
        modal_form[0].reset();
        $('[name="kt_form_edit_customer"]').val(null).trigger('change');
        setTimeout(function () { $('input[name="kt_form_edit_customer"]').focus() }, 500);
    }

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Payment/DeleteByIds", dtTable, null)
        .then(function () {
            dtTable.draw();
            App.showHideButtonDelete(false);
        });
    }

    return {
        // public functions
        init: function () {
            initialDatatable();
            initialComponents();
            initSelect2()
        }
    };
}();
