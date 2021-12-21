//== Class definition

var ProductReport = function () {
    let dtTable = null;
    var charts = document.querySelectorAll('.ReportProductPieChart');
    var options;
    var chart;


    let initialComponents = () => {
            refreshData();
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
            refreshData();
        });


        $('#fromToDate').change(function (e) {
            e.preventDefault();
            dtTable.draw();
            refreshData();
        });




    };


    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/ProductReport/DataTableGetList";
        datatableOption.ajax.data = {
            fDate: function () {


                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    return $('#fromToDate').val().split('-')[0].trim();
                }

                return '';
            },
            tDate: function () {
                if (!App.isNullOrEmpty($('#fromToDate').val())) {
                    return $('#fromToDate').val().split('-')[1] !== undefined ? $('#fromToDate').val().split('-')[1].trim() : '';
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
                width: "80px", "title": "", "render": function (data, type, full, meta) {
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
                }
            },
            {
                "data": "qtyInStock", "name": "qtyInStock", "autoWidth": true, "title": "Số lượng", "render": function (data, type, full, meta) {
                    return '<span class="text-muted">' + data + '</span>';
                }
            },
            {
                "data": "productTypeName", "name": "productTypeName", "autoWidth": true, "title": "Nhóm hàng", "render": function (data, type, full, meta) {
                    return '<span class="text-muted">' + data + '</span>';
                }
            },
            {
                "data": "buyingPrice", "name": "buyingPrice", "autoWidth": true, "title": "Doanh số", "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            }
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);
    };


    let refreshData = function () {
        //call ajax get thuộc tính

        let fDate = '', tDate = '';
        if (!App.isNullOrEmpty($('#fromToDate').val())) {
            fDate = $('#fromToDate').val().split('-')[0].trim();
        }

        if (!App.isNullOrEmpty($('#fromToDate').val())) {
            tDate = $('#fromToDate').val().split('-')[1] !== undefined ? $('#fromToDate').val().split('-')[1].trim() : '';
        }

        App.sendDataToURL("/ProductReport/GetTotalReport", { FromDate: fDate, ToDate: tDate }, "POST")
            .then(function (res) {
                if (res.data.items.length > 0) {


                    let data = [], label =[];
                    [].slice.call(charts).map(function (element) {
                        height = parseInt(KTUtil.css(element, 'height'));
                        $.each(res.data.items, function (index, item) {
                            data.push(item.buyingPrice);
                            label.push(item.productTypeName );
                        });
                        options = {
                            series: data,
                            chart: {
                                fontFamily: 'inherit',
                                type: 'pie',
                                height: height,
                                toolbar: {
                                    show: false
                                },
                            },
                            legend: {
                                fontSize: "15px"
                            },
                            labels: label,
                            responsive: [{
                                breakpoint: 480,
                                options: {
                                    chart: {
                                        width: 200
                                    },
                                    legend: {
                                        position: 'bottom'
                                    }
                                }
                            }],
                            tooltip: {
                                style: {
                                    fontSize: '14px'
                                },
                                y: {
                                    formatter: function (val) {
                                        return Util.dinhDangTien(val) + " đ"
                                    }
                                }
                            },
                        };
                        if (chart == null) {
                            chart = new ApexCharts(element, options);
                            chart.render();

                        } else {

                            chart.updateOptions({
                                series: data,
                                labels: label,
                            })

                        }
                    });

                }

            }
        )
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
