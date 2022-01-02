//== Class definition

var Warehouse = function () {
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
        datatableOption.ajax.url = "/Warehouse/DataTableGetList";
        datatableOption.ajax.data = {
            tDate: function () {
                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    return $('#fromToDate').val().trim();
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
                "data": "code", "name": "code", "autoWidth": true, "title": "Mã HH", "render": function (data, type, full, meta) {
                    return '<div class="d-flex justify-content-start flex-column">\
		                <a href="#!" class="fw-bolder text-hover-primary fs-6">' + data + '</a>\
	                </div>';
                }
            },
            {
                "data": "name", "name": "name", "autoWidth": true, "title": "Tên HH",
                "render": function (data, type, full, meta) {
                    return '<div class="d-flex justify-content-start flex-column">\
		                <a href="#!" class="fw-bolder text-hover-primary fs-6">' + data + '</a>\
	                </div>';
                } },
            {
                "data": "qtyInStock", "name": "qtyInStock", "autoWidth": true, "title": "Số lượng", "render": function (data, type, full, meta) {
                    return '<span class="text-muted">' + data + '</span>';
                }
            },
            {
                "data": "price", "name": "price", "autoWidth": true, "title": "Vốn tồn kho","render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            {
                "data": "buyingPrice", "name": "buyingPrice", "autoWidth": true, "title": "Giá trị tồn", "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            }
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);
    };
 

    return {
        // public functions
        init: function () {
            initialDatatable();
            initialComponents();
            form__date_register();
        }
    };
}();
