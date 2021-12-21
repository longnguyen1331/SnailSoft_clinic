//== Class definition

var SaleReport = function () {
    let dtTable = null;
    let initialComponents = () => {


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
        datatableOption.ajax.url = "/SaleReport/DataTableGetList";
        datatableOption.ajax.data = {
            fDate: function () {
                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    return $('#fromToDate').val().split('-')[0] !== undefined ? $('#fromToDate').val().split('-')[0].trim() : '';
                }
                return '';
            },
            tDate: function () {
                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    return $('#fromToDate').val().split('-')[1] !== undefined ? $('#fromToDate').val().split('-')[1].trim() : '';
                }
                return '';
            },
            textSearch: function () {
                return $('#dtTableSearch').val();
            }
        };

        datatableOption.drawCallback = function (settings) {
            var response = settings.json;
            $('.revenue').text(Util.dinhDangTien(response.totolMoney) + "đ")
            $('.totalOrders').text(Util.dinhDangTien(response.recordsTotal))
        }

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
                width: "80px", "title": "", "render": function (data, type, full, meta) {
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
            }
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);

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
    };


    return {
        // public functions
        init: function () {
            initialDatatable();
            initialComponents();
            form__date_range_register();

        }
    };
}();