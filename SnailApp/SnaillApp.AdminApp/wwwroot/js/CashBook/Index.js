//== Class definition

var CashBook = function () {
    let dtTable = null;

    let initialComponents = () => {
        $('.tien-VND').autoNumeric('init', initialTienVNDOption());

        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });
        
        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });


        $('#fromToDate').change(function (e) {
            e.preventDefault();
            dtTable.draw();
        });
    };


    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/CashBook/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTableSearch').val();
            },
            fDate: function () {


                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    return $('#fromToDate').val().split('-')[0].trim();
                }

                return '';
            },
            tDate: function () {
                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    return $('#fromToDate').val().split('-')[1] !== undefined ? $('#fromToDate').val().split('-')[1].trim(): '';
                }

                return '';
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
                "targets": [0],
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
                    console.log(full.loaiPhieuKeToan);
                    return '<div class="d-flex justify-content-start flex-column">\
		                <a href="#!" onClick="openModalDetail('+full.id+')" class="fw-bolder text-hover-primary fs-6">' + data + '</a>\
	                </div>';
                }
            },
            { "data": "dateString", "name": "dateString", "autoWidth": true, "title": "Ngày" },
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
                    let html = '<div class="d-flex justify-content-center flex-shrink-0"><a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1 print">\
					                <span class="svg-icon svg-icon-3">\
						    			<!--begin::Svg Icon | path:/var/www/preview.keenthemes.com/metronic/releases/2021-05-14-112058/theme/html/demo2/dist/../src/media/svg/icons/Devices/Printer.svg--><svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
                                        <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" >\
                                            <rect x="0" y="0" width="24" height="24"/>\
                                            <path d="M16,17 L16,21 C16,21.5522847 15.5522847,22 15,22 L9,22 C8.44771525,22 8,21.5522847 8,21 L8,17 L5,17 C3.8954305,17 3,16.1045695 3,15 L3,8 C3,6.8954305 3.8954305,6 5,6 L19,6 C20.1045695,6 21,6.8954305 21,8 L21,15 C21,16.1045695 20.1045695,17 19,17 L16,17 Z M17.5,11 C18.3284271,11 19,10.3284271 19,9.5 C19,8.67157288 18.3284271,8 17.5,8 C16.6715729,8 16,8.67157288 16,9.5 C16,10.3284271 16.6715729,11 17.5,11 Z M10,14 L10,20 L14,20 L14,14 L10,14 Z" fill="#000000"/>\
                                            <rect fill="#000000" opacity="0.3" x="8" y="2" width="8" height="2" rx="1"/>\
                                        </g>\
					                </span>\
				                </a></div>';
                    return html;
                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);

        $('#dtTable tbody').on('click', 'a.print', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            selectedDataRow.loaiPhieuKeToan == 0 ? printPT(selectedDataRow) : printPC(selectedDataRow);
        });
    };


    function printPT(data) {
        console.log(data);
        //Get template phiếu thu 
        App.sendDataToURL("/DocTemplate/GetContentByDocTemplateTypeCode", { Id: null, Data: { DocTemplateCode: "PT" } }, "POST")
            .then(function (res) {
                if (res.isSuccessed && res.resultObj != null) {
                    $("#page-print").empty();

                    var date = new Date();
                    res.resultObj.content = res.resultObj.content.replace('{{ten_cua_hang}}', res.resultObj.storeName);
                    res.resultObj.content = res.resultObj.content.replace('{{dia_chi_cua_hang}}', res.resultObj.storeAddress);
                    res.resultObj.content = res.resultObj.content.replace('{{dien_thoai_cua_hang}}', res.resultObj.storePhone);
                    res.resultObj.content = res.resultObj.content.replace('{{ngay_thu}}', data.dateString);
                    res.resultObj.content = res.resultObj.content.replace('{{so_phieu}}', data.code);
                    res.resultObj.content = res.resultObj.content.replace('{{nguoi_thu}}', data.saleStaffName);
                    res.resultObj.content = res.resultObj.content.replace('{{nguoi_tra}}', data.customerName);
                    res.resultObj.content = res.resultObj.content.replace('{{ghi_chu}}', data.description);
                    res.resultObj.content = res.resultObj.content.replace('{{ngay_in}}', date.getDate());
                    res.resultObj.content = res.resultObj.content.replace('{{thang_in}}', date.getMonth() + 1);
                    res.resultObj.content = res.resultObj.content.replace('{{nam_in}}', date.getFullYear());
                    res.resultObj.content = res.resultObj.content.replace('{{tong_tien}}', Util.dinhDangTien(data.totalMoney));
                    $("#page-print").html(res.resultObj.content).show();
                    $("#page-print").print();
                    $("#page-print").hide();

                }
            }
            )
    }

    function printPC(data) {

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

    return {
        // public functions
        init: function () {
            initialDatatable();
            initialComponents();
            form__date_range_register();
        }
    };
}();
