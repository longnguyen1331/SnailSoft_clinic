//== Class definition

var ProfitReport = function () {
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
        datatableOption.ajax.url = "/ProfitReport/DataTableGetList";
        datatableOption.ajax.data = {
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

        datatableOption.drawCallback = function (settings) {
            var response = settings.json;

            var sumBuyingPrice = response.data.reduce(function (total, currentValue) {
                return total + currentValue.buyingPrice;
            }, 0);

            var sumRevenue = response.data.reduce(function (total, currentValue) {
                return total + currentValue.revenue;
            }, 0);

            $('.totalBuyingPrice').text(Util.dinhDangTien(sumBuyingPrice))
            $('.grossProfit').text(Util.dinhDangTien(sumRevenue) + "đ")
        }

        datatableOption.order = [[1, "desc"]];
        datatableOption.columnDefs = [
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
            { "data": "date", "name": "date", "autoWidth": true, "title": "Ngày" },
            {
                "data": "buyingPrice", "name": "buyingPrice", "autoWidth": true, "title": "Doanh số", "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-dark">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            {
                "data": "price", "name": "price", "autoWidth": true, "title": "Tiền vốn", "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-info">' + Util.dinhDangTien(data) + '</span>';
                }
            },
            {
                "data": "revenue", "name": "revenue", "autoWidth": true, "title": "Lãi gộp",
                "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-success">' + Util.dinhDangTien(row.revenue) + '</span>';
                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);
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
