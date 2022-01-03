//== Class definition

var Order = function () {
    let dtTable = null;
    let modal = $("#kt_modal_edit"),
        modal_form = $("#kt_modal_edit_form"),
        modal_form_buttonSubmit = $('#kt_modal_edit_submit'),
        modal_header_text = $("#kt_modal_edit_header_text"),
        modal_form_submit_text = $("#kt_modal_edit_submit_text"),
        select_customer = $('[name="kt_form_edit_customer"]'),
        select_product = $('#kt_form_edit_product'),
        table_product_details = $('#kt_create_new_product_details tbody');


    let editingDataRow = null;
    
    let validator = FormValidation.formValidation(modal_form[0], {
        fields: {
            kt_modal_edit_form_status: { validators: { notEmpty: { message: "vui lòng chọn trạng thái" } } },
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {

        $('#fromToDate').change(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();
            window.location.href = "/Order/Edit";
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        $('#kt_modal_edit_submit').click(function (e) {
            e.preventDefault();
            let result = {}, phieuKeToanChiTiets = [];
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

                            table_product_details.find('tr').each((index, el) => {

                                let obj = {};
                                $(el).find("td input").each((index, elTd) => {
                                    let isVNDFormat = $(elTd).hasClass('tien-VND');
                                    let colName = $(elTd).data("field");

                                    switch (colName) {

                                        case "ProductSKUId":
                                            obj[colName] = App.isNullOrEmpty($(elTd).val()) ? -1 : $(elTd).val();

                                            break;

                                        default:
                                            obj[colName] = (isVNDFormat ? $(elTd).autoNumeric('get') : $(elTd).val());
                                            break;
                                    }

                                });
                                phieuKeToanChiTiets.push(obj);
                            }),

                            result["PhieuKeToanChiTiets"] = phieuKeToanChiTiets,
                            console.log(result),
                            data = {
                                Id: (editingDataRow != null ? editingDataRow.id : null),
                                Data: result
                            },
                            console.log(data) ,
                            App.sendDataToURL("/Order/Save", data, "POST")

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


        select_product.autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: '/ProductSKU/Filter',
                    data: {
                        textSearch: request.term
                    },
                    success: function (data) {

                        response($.map(data.items, function (item) {
                            var data = {
                                value: item.id,
                                label: item.name,
                                price: item.price,
                                buyingPrice: item.buyingPrice,
                                code: item.code
                            };
                            console.log(data);
                            return data;
                        }));
                    },
                    error: function (data) {
                        console.log(data);
                    }
                });
            },
            minLength: 1,
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            },
            change: function (event, ui) {
                console.log('change :' + event, ui)
            },
            select: function (event, ui) {
                if (!ui.item) {
                    console.log('select !ui :' + event, ui)
                } else {
                    select_product.val('');
                    onAddProduct(ui.item);
                }
                return false;
            }
        });
    };

    // tag added callback
    let onAddProduct = (e) => {
        console.log(e.value);
        if ($('#product_' + e.value + '').length <= 0) {
            let html = '<tr id="product_' + e.value + '">\
                <td>\
                    <input hidden type="text" class="form-control form-control-solid tien-VND" data-field="BuyingPrice" value="'+ e.buyingPrice + '">\
                    <input hidden type="number" class="form-control" data-field="ProductSKUId" value="'+ e.value + '">\
                    <div class="d-flex justify-content-start flex-column">\
                    <a href="#" class="text-dark fw-bolder text-hover-primary fs-6">'+ e.label + '</a>\
                    <span class="text-muted fw-bold text-muted d-block fs-7">Mã : '+ e.code + '</span>\
                </div>\
                </td>\
                <td>\
                    <input type="number" class="form-control inputQtyProductDetail" min="1" form-control-solid" name="null-0" data-id="'+ e.value + '" data-field="Qty" value="1">\
                </td>\
                <td>\
                    <input type="text" class="form-control form-control-solid tien-VND inputPriceProductDetail" disabled name="null-0" data-field="Price" data-id="'+ e.value + '" value="' + e.buyingPrice + '">\
                </td>\
                <td>\
                    <input type="text" class="form-control form-control-solid tien-VND inputTotalProductDetail" disabled name="null-0" data-field="Total" data-id="'+ e.value + '" value="' + e.buyingPrice + '">\
                </td>\
                <td>\
                  <a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm delete_product_details" data-id="'+ e.value + '">\
					            <span class="svg-icon svg-icon-3">\
						            <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
							            <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">\
								            <rect x="0" y="0" width="24" height="24"></rect>\
								            <path d="M6,8 L6,20.5 C6,21.3284271 6.67157288,22 7.5,22 L16.5,22 C17.3284271,22 18,21.3284271 18,20.5 L18,8 L6,8 Z" fill="#000000" fill-rule="nonzero"></path>\
								            <path d="M14,4.5 L14,4 C14,3.44771525 13.5522847,3 13,3 L11,3 C10.4477153,3 10,3.44771525 10,4 L10,4.5 L5.5,4.5 C5.22385763,4.5 5,4.72385763 5,5 L5,5.5 C5,5.77614237 5.22385763,6 5.5,6 L18.5,6 C18.7761424,6 19,5.77614237 19,5.5 L19,5 C19,4.72385763 18.7761424,4.5 18.5,4.5 L14,4.5 Z" fill="#000000" opacity="0.3"></path>\
							            </g>\
						            </svg>\
					            </span>\
				            </a>\
                </td>\
            </tr>';

            table_product_details.append(html);

            $('.tien-VND').autoNumeric('init', initialTienVNDOption());
            initEnventChangeValueAndDeleteProductDetail();
            refreshTotal();
        }
    }

    let onDeleteProduct = (e) => {
        $('#kt_create_new_product_details tbody #product_' + e.value).remove();
        $('select[name="kt_form_edit_product"] option[value=' + e.value +']').remove();
    }

    let initEnventChangeValueAndDeleteProductDetail = () => {
        //ChangeValue
        let qty = 0, price = 0;

        $('.inputQtyProductDetail').change(function (e) {
            qty = parseFloat($(this).val());
            price = parseFloat($('.inputPriceProductDetail[data-id="' + $(this).data('id') + '"]').autoNumeric('get'));
            $('.inputTotalProductDetail[data-id="' + $(this).data('id') + '"]').autoNumeric('set', qty * price);
            refreshTotal();
        });

        //Delete 
        $('.delete_product_details').click(function (e) {
            $('#kt_create_new_product_details tbody #product_' + $(this).data('id')).remove();
            $('select[name="kt_form_edit_product"] option[value=' + $(this).data('id') +']').remove();
            refreshTotal();
        });
    }

    let refreshTotal = ()=>{

        let tongTien = 0;

        table_product_details.find('tr').each((index, el) => {
            $(el).find('td input').each((idx, elT) => {
                tongTien += $(elT).data('field') =="Total" ? parseFloat($(elT).autoNumeric('get')) : 0;
            });
        });

        $('#kt_modal_edit_form_total').autoNumeric('set', tongTien);
    }

    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/Order/DataTableGetList";
        datatableOption.ajax.data = {
            searchBy: function () {
                return $('#filterBy').val();
            },
            textSearch: function () {
                return $('#dtTableSearch').val();
            },
            fromDate: function () {
                let fDate = '';
                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    fDate = $('#fromToDate').val().split('-')[0].trim();
                }
                return fDate;
            },
            toDate: function () {
                let tDate = '';
                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    tDate = $('#fromToDate').val().split('-')[1] !== undefined ? $('#fromToDate').val().split('-')[1].trim() : '';
                }

                return tDate;
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
		                <a href="#!" class="detail fw-bolder text-hover-primary fs-6">' + data + '</a>\
	                </div>';
                }
            },
            { "data": "dateString", "name": "dateString", "autoWidth": true, "title": "Ngày" },
            {
                "data": "customerName", "name": "customerName", "autoWidth": true, "title": "Khách hàng", "render": function (data, type, full, meta) {
                    let html = '<div class="dropdown dropup"><a href="#" class="btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill" data-toggle="dropdown">';
                    html += '<i class="la la-ellipsis-h"></i> ' + data +'</a><div class="customer dropdown-menu dropdown-menu-right" style="position:static;">';
                    html += '<a class="menu-link px-3" href="#!"><i class="las la-phone-volume"></i> '+full.customerPhone+'</a><br/>';
                    html += '<a class="menu-link px-3" href="#!"><i class="las la-envelope"></i> ' + full.customerEmail +'</a><br/>';
                    html += '<a class="menu-link px-3" href="#!"><i class="las la-map-pin"></i> ' + full.customerAddress +'</a><br/>';
                    html += '<a class="menu-link px-3" href="#!"><i class="las la-birthday-cake"></i> ' + full.customerBirthDay +'</a><br/>';
                    html += '<a class="menu-link px-3" href="#!"><i class="las la-transgender"></i> ' + full.customerSex +'</a><br/>';
                    html += '</div></div>';
                    return html;
                }
            },
            {
                "data": "saleStaffName", "name": "saleStaffName", "autoWidth": true, "title": "Nhân viên bán hàng", "render": function (data, type, full, meta) {
                    return '<span class="text-muted">' + data + '</span>';
                }
            },
            {
                "data": "totalBuyingPrice", "name": "totalBuyingPrice", "autoWidth": true, "title": "Tổng tiền hàng","render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            {
                "data": "totalDiscount", "name": "totalDiscount", "autoWidth": true, "title": "Giảm giá", "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            {
                "data": "totalMoney", "name": "totalMoney", "autoWidth": true, "title": "Tổng tiền", "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            },
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
    </g >\
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

        $('#dtTable tbody').on('click', 'a.detail', function (e) {
            e.preventDefault();
            var tr = $(this).closest('tr');
            var row = dtTable.row(tr);

            if (row.child.isShown()) {
                // This row is already open - close it
                row.child.hide();
                tr.removeClass('shown');
            }
            else {
                let selectedDataRow = row.data();

                let html = '<div style="display:flex"><table cellpadding="5" cellspacing="0" border="0" style="width:60%;padding-left:50px;">\
                            <thead><tr><td><b>STT</b></td>\
                            <td><b>Mã Hàng hóa</b></td>\
                            <td><b>Tên Hàng hóa</b></td>\
                            <td><b>SL</b></td>\
                            <td><b>Tiền</b></td>\
                            </tr></thead><tbody>';
                App.sendDataToURL("/Order/GetManageListDetailPaging", { Id: selectedDataRow.id, Data: null }, "POST", true)
                    .then(function (order) {
                        if (order.isSuccessed && order.resultObj != null) {

                            $.each(order.resultObj, function (index, e) {
                                html += '<tr><td>' + (index +1 )+ '</td>' +
                                    '<td>' + e.productSKUCode + '</td>' +
                                    '<td>' + e.productSKUName + '</td>' +
                                    '<td>' + e.qty + '</td>' +
                                    '<td>' + Util.dinhDangTien(e.total) + '</td>' +
                                    '</tr>';
                            });

                            html += '</tbody></table>';
                            // Open this row
                            html += '<table style="width:40%;">\
                                        <tr style="background:#ccc;"><td>Số món<td> <td>'+ order.resultObj.length + '</td> <tr>\
                                        <tr style="background:#ccc;"><td>Tiền hàng<td> <td>'+ Util.dinhDangTien(selectedDataRow.totalBuyingPrice) +'</td> <tr>\
                                        <tr style="background:#ccc;"><td>Giảm giá<td> <td>'+ Util.dinhDangTien(selectedDataRow.totalDiscount) +'</td> <tr>\
                                        <tr style="background:#ccc;"><td>Tổng tiền<td> <td>'+ Util.dinhDangTien(selectedDataRow.totalMoney) +'</td> <tr>\
                                        <tr style="background:#ccc;"><td>Đã trả<td> <td>'+ Util.dinhDangTien(selectedDataRow.totalPaid) +'</td> <tr></table></div>'
                            row.child(html).show();
                            tr.addClass('shown');
                        }
                    }
                )
            }
        });

        $('#dtTable tbody').on('click', 'a.print', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                print(selectedDataRow);
            }
        });

        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                editingDataRow = selectedDataRow;
                //Get template phiếu thu 
                App.sendDataToURL("/Order/GetById", { Id: selectedDataRow.id, Data: null }, "POST", true)
                .then(function (res) {
                    if (res.isSuccessed && res.resultObj != null) {
                        table_product_details.html('');
                        console.log(res.resultObj); 
                            $('[name="kt_form_edit_customer"]').append('<option value="' + res.resultObj.customerId + '">' + res.resultObj.customerName+'</option>').trigger('change');

                            App.sendDataToURL("/Order/GetManageListDetailPaging", { Id: selectedDataRow.id, Data: null }, "POST", true)
                                .then(function (order) {
                                    if (order.isSuccessed && order.resultObj != null)
                                    {
                                        $.each(order.resultObj, function (index, e) {

                                            let html = '<tr id="product_' + e.productSKUId + '">\
                                        <td>\
                                            <input hidden type="text" class="form-control form-control-solid tien-VND" data-field="BuyingPrice" value="'+ e.buyingPrice + '">\
                                            <input hidden type="number" class="form-control" data-field="ProductSKUId" value="'+ e.productSKUId + '">\
                                            <div class="d-flex justify-content-start flex-column">\
                                            <a href="#" class="text-dark fw-bolder text-hover-primary fs-6">'+ e.productSKUName + '</a>\
                                            <span class="text-muted fw-bold text-muted d-block fs-7">Mã : '+ e.productSKUCode + '</span>\
                                        </div>\
                                        </td>\
                                        <td>\
                                            <input type="number" class="form-control inputQtyProductDetail" min="1" form-control-solid" name="null-0" data-id="'+ e.productSKUId + '" data-field="Qty" value="' + e.qty + '">\
                                        </td>\
                                        <td>\
                                            <input type="text" class="form-control form-control-solid tien-VND inputPriceProductDetail" disabled name="null-0" data-field="Price" data-id="'+ e.productSKUId + '" value="' + e.price + '">\
                                        </td>\
                                        <td>\
                                            <input type="text" class="form-control form-control-solid tien-VND inputTotalProductDetail" disabled name="null-0" data-field="Total" data-id="'+ e.productSKUId + '" value="' + e.total + '">\
                                        </td>\
                                        <td>\
                                          <a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm delete_product_details" data-id="'+ e.productSKUId + '">\
					                                    <span class="svg-icon svg-icon-3">\
						                                    <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
							                                    <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">\
								                                    <rect x="0" y="0" width="24" height="24"></rect>\
								                                    <path d="M6,8 L6,20.5 C6,21.3284271 6.67157288,22 7.5,22 L16.5,22 C17.3284271,22 18,21.3284271 18,20.5 L18,8 L6,8 Z" fill="#000000" fill-rule="nonzero"></path>\
								                                    <path d="M14,4.5 L14,4 C14,3.44771525 13.5522847,3 13,3 L11,3 C10.4477153,3 10,3.44771525 10,4 L10,4.5 L5.5,4.5 C5.22385763,4.5 5,4.72385763 5,5 L5,5.5 C5,5.77614237 5.22385763,6 5.5,6 L18.5,6 C18.7761424,6 19,5.77614237 19,5.5 L19,5 C19,4.72385763 18.7761424,4.5 18.5,4.5 L14,4.5 Z" fill="#000000" opacity="0.3"></path>\
							                                    </g>\
						                                    </svg>\
					                                    </span>\
				                                    </a>\
                                        </td>\
                                    </tr>';

                                        table_product_details.append(html);

                                        $('.tien-VND').autoNumeric('init', initialTienVNDOption());
                                        initEnventChangeValueAndDeleteProductDetail();
                                        refreshTotal();
                                    })
                                    }
                                }
                            )

                            modal_header_text.text("Chỉnh sửa hóa đơn");
                            modal_form_submit_text.text("Chỉnh sửa");
                            modal.modal("show");
                        }
                    }
                )
            }
        });

        $('#dtTable tbody').on('click', 'div.dropup', function (e) {
            e.preventDefault();
            $('.dropdown-menu.customer').not($(this).children(".dropdown-menu")).removeClass('show');
            $(this).children(".dropdown-menu").toggleClass("show");
        });
    };


    function format(selectedDataRow) {
       
    }

    function print(data) {

        //Get template phiếu thu 
        App.sendDataToURL("/DocTemplate/GetContentByDocTemplateTypeCode", { Id: null, Data: { DocTemplateCode: "PX" } }, "POST")
            .then(function (res) {

                if (res.isSuccessed && res.resultObj != null) {
                    $("#page-print").empty();

                    App.sendDataToURL("/Order/GetManageListDetailPaging", { Id: data.id, Data: null }, "POST")
                        .then(function (order) {
                            if (order.isSuccessed && order.resultObj != null) {
                                var date = new Date();
                                res.resultObj.content = res.resultObj.content.replace('{{ten_cua_hang}}', res.resultObj.storeName);
                                res.resultObj.content = res.resultObj.content.replace('{{dia_chi_cua_hang}}', res.resultObj.storeAddress);
                                res.resultObj.content = res.resultObj.content.replace('{{dien_thoai_cua_hang}}', res.resultObj.storePhone);
                                res.resultObj.content = res.resultObj.content.replace('{{ngay_xuat}}', data.dateString);
                                res.resultObj.content = res.resultObj.content.replace('{{so_phieu}}', data.code);
                                res.resultObj.content = res.resultObj.content.replace('{{nguoi_xuat}}', data.saleStaffName);
                                res.resultObj.content = res.resultObj.content.replace('{{khach_hang}}', data.customerName);
                                res.resultObj.content = res.resultObj.content.replace('{{so_dien_thoai_khach_hang}}', data.customerPhone);
                                res.resultObj.content = res.resultObj.content.replace('{{ghi_chu}}', data.description);
                                res.resultObj.content = res.resultObj.content.replace('{{ngay_in}}', date.getDate());
                                res.resultObj.content = res.resultObj.content.replace('{{thang_in}}', date.getMonth() + 1);
                                res.resultObj.content = res.resultObj.content.replace('{{nam_in}}', date.getFullYear());
                                res.resultObj.content = res.resultObj.content.replace('{{tong_tien}}', Util.dinhDangTien(data.totalMoney));
                                res.resultObj.content = res.resultObj.content.replace('{{tong_tien_thanh_toan}}', Util.dinhDangTien(data.totalMoney));

                                //table body
                                let body = '', qty = 0;
                                $.each(order.resultObj, function (index, item) {
                                    qty += item.qty;
                                    body += '<tr style="border:1px solid;">\
                                        <td class="text-center">'+ (index + 1) + '</td>\
                                        <td>\
                                            <span class="text-muted">' + item.productSKUName + '</span>\
                                        </td>\
                                        <td class="text-center">\
                                            <span class="text-muted">' + item.qty + '</span>\
                                        </td>\
                                        <td class="text-center">\
                                            <span class="text-muted">' + Util.dinhDangTien(item.price) + '</span>\
                                        </td>\
                                        <td class="text-center">\
                                            <span class="text-muted">' + Util.dinhDangTien(item.total) + '</span>\
                                        </td>\
                                    </tr>';
                                });

                                res.resultObj.content = res.resultObj.content.replace('{{data_content}}', body);
                                res.resultObj.content = res.resultObj.content.replace('{{tong_so_luong}}', qty);

                                $("#page-print").html(res.resultObj.content).show();

                                $("#page-print").print();
                                $("#page-print").hide();

                            }
                        }
                        )

                }
            }
        )
    }


    function initSelect2() {
       initSelect2Base(select_customer, '/Customer/Filter');
    }

    let initSelect2Base = (el, url, options) => {

        el.select2(
            {
                ajax: {
                    url: url,
                    data: function (params) {
                        var query = {
                            textSearch: params.term
                        }
                        return query
                    },
                    processResults: function (res) {

                        var data = $.map(res.items, function (item, i) {
                            return {
                                id: (options && options.selectedFields ? item[options.selectedFields[0]] : item.id),
                                text: (options && options.selectedFields ? item[options.selectedFields[1]] : (item.lastName + ' ' + item.firstName))
                            }
                        });
                        if (options && options.append0 != null && options.append0 == true) {
                            data.unshift({
                                id: 0,
                                text: "Không chọn"
                            })
                        }

                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');
    }


    function openDetail(id) {
        $('#kt_view_detail_fields tbody').html('');

        App.sendDataToURL("/Order/GetManageListDetailPaging", { Id: id, Data: null }, "POST")
            .then(function (res) {
                if (res.isSuccessed && res.resultObj != null && res.resultObj.length > 0) {
                    $.each(res.resultObj, function (index, item) {
                        $('#kt_view_detail_fields tbody').append('<tr id="tag_' + item.id + '">\
                            <td>\
                            <div class="d-flex align-items-left">\
                            <div class= "d-flex flex-column">\
                              <a href="#!" data-field="ProductSKUName">'+ item.productSKUName + '</a>\
                                <span data-field="ProductSKUCode">'+ item.productSKUCode + '</span>\
                            </div>\
                            </div>\
                            </td>\
                            <td>\
                                <span class="tien-VND" data-field="Qty">'+ item.qty + '</span>\
                            </td>\
                            <td>\
                                <span class="tien-VND" data-field="BuyingPrice">'+ item.buyingPrice + '</span>\
                            </td>\
                            <td>\
                                <span class="tien-VND" data-field="TotalDiscount">'+ item.totalDiscount + '</span>\
                            </td>\
                             <td>\
                                <span data-field="Description">'+ (App.isNullOrEmpty(item.description) ? '' : item.description) + '</span>\
                            </td>\
                            <td>\
                                <span class="tien-VND" data-field="TotalMoney">'+ (item.total - item.totalDiscount) + '</span>\
                            </td>\
                        </tr>');



                        $('.tien-VND').autoNumeric('init', initialTienVNDOption());

                        setTimeout(function () {

                            console.log(item);

                            $('#tag_' + item.id).find("td span").each((index, elTd) => {
                                if ($(elTd).data("field")) {

                                    switch ($(elTd).data("field")) {
                                        case "Total":
                                            $(elTd).autoNumeric('set', (item.total - item.totalDiscount).toString());
                                            break;

                                        case "Description":
                                            $(elTd).val(item.description);
                                            break;

                                        case "ProductSKUName":
                                            $(elTd).val(item.productSKUName);
                                            break;

                                        case "ProductSKUCode":
                                            $(elTd).val(item.productSKUCode);
                                            break;

                                        case "TotalDiscount":
                                            $(elTd).autoNumeric('set', item.totalDiscount.toString());
                                            break;

                                        case "BuyingPrice":
                                            $(elTd).autoNumeric('set', item.buyingPrice.toString());
                                            break;

                                        case "Qty":
                                            $(elTd).val(item.qty);
                                            break;
                                        default:

                                            break;
                                    }
                                }
                            });
                        }, 500);
                    });

                    $('#kt_modal_view_detail').modal('show');
                }
            }
        )
    }


    let resetForm = () => {
        modal_form[0].reset();
        table_product_details.html('');
        select_customer.val(null).trigger('change');
        setTimeout(function () { $('input[name="kt_form_edit_product"]').focus() }, 500);
    }

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Order/DeleteByIds", dtTable, null)
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