//== Class definition

var MonthlyReport = function () {
    var charts = document.querySelectorAll('.mixed-widget-10-chart');
    var color;
    var height;
    var labelColor = KTUtil.getCssVariableValue('--bs-gray-500');
    var borderColor = KTUtil.getCssVariableValue('--bs-gray-200');
    var baseLightColor;
    var secondaryColor = KTUtil.getCssVariableValue('--bs-gray-300');
    var baseColor, successColor;
    var options;
    var chart;


    let initialComponents = () => {
        refreshData();
        $('select[name=kt_form_year]').change(function (e) {
            e.preventDefault();
            refreshData();
        });
    };


    let refreshData = function () {
        //call ajax get thuộc tính

        App.sendDataToURL("/MonthlyReport/GetReport", { Year: $('select[name=kt_form_year]').val()}, "POST")
            .then(function (res) {
                let loiNhuan1 = res.data != null ? res.data.items.filter(x => x.monthInYear == 1) : null,
                    loiNhuan2 = res.data != null ? res.data.items.filter(x => x.monthInYear == 2) : null,
                    loiNhuan3 = res.data != null ? res.data.items.filter(x => x.monthInYear == 3) : null,
                    loiNhuan4 = res.data != null ? res.data.items.filter(x => x.monthInYear == 4) : null,
                    loiNhuan5 = res.data != null ? res.data.items.filter(x => x.monthInYear == 5) : null,
                    loiNhuan6 = res.data != null ? res.data.items.filter(x => x.monthInYear == 6) : null,
                    loiNhuan7 = res.data != null ? res.data.items.filter(x => x.monthInYear == 7) : null,
                    loiNhuan8 = res.data != null ? res.data.items.filter(x => x.monthInYear == 8) : null,
                    loiNhuan9 = res.data != null ? res.data.items.filter(x => x.monthInYear == 9) : null,
                    loiNhuan10 = res.data != null ? res.data.items.filter(x => x.monthInYear == 10) : null,
                    loiNhuan11 = res.data != null ? res.data.items.filter(x => x.monthInYear == 11) : null,
                    loiNhuan12 = res.data != null ? res.data.items.filter(x => x.monthInYear == 12) : null,

                    tienVon1 = res.data != null ? res.data.items.filter(x => x.monthInYear == 1) : null,
                    tienVon2 = res.data != null ? res.data.items.filter(x => x.monthInYear == 2) : null,
                    tienVon3 = res.data != null ? res.data.items.filter(x => x.monthInYear == 3) : null,
                    tienVon4 = res.data != null ? res.data.items.filter(x => x.monthInYear == 4) : null,
                    tienVon5 = res.data != null ? res.data.items.filter(x => x.monthInYear == 5) : null,
                    tienVon6 = res.data != null ? res.data.items.filter(x => x.monthInYear == 6) : null,
                    tienVon7 = res.data != null ? res.data.items.filter(x => x.monthInYear == 7) : null,
                    tienVon8 = res.data != null ? res.data.items.filter(x => x.monthInYear == 8) : null,
                    tienVon9 = res.data != null ? res.data.items.filter(x => x.monthInYear == 9) : null,
                    tienVon10 = res.data != null ? res.data.items.filter(x => x.monthInYear == 10) : null,
                    tienVon11 = res.data != null ? res.data.items.filter(x => x.monthInYear == 11) : null,
                    tienVon12 = res.data != null ? res.data.items.filter(x => x.monthInYear == 12) : null,


                    donHang1 = res.data != null ? res.data.items.filter(x => x.monthInYear == 1) : null,
                    donHang2 = res.data != null ? res.data.items.filter(x => x.monthInYear == 2) : null,
                    donHang3 = res.data != null ? res.data.items.filter(x => x.monthInYear == 3) : null,
                    donHang4 = res.data != null ? res.data.items.filter(x => x.monthInYear == 4) : null,
                    donHang5 = res.data != null ? res.data.items.filter(x => x.monthInYear == 5) : null,
                    donHang6 = res.data != null ? res.data.items.filter(x => x.monthInYear == 6) : null,
                    donHang7 = res.data != null ? res.data.items.filter(x => x.monthInYear == 7) : null,
                    donHang8 = res.data != null ? res.data.items.filter(x => x.monthInYear == 8) : null,
                    donHang9 = res.data != null ? res.data.items.filter(x => x.monthInYear == 9) : null,
                    donHang10 = res.data != null ? res.data.items.filter(x => x.monthInYear == 10) : null,
                    donHang11 = res.data != null ? res.data.items.filter(x => x.monthInYear == 11) : null,
                    donHang12 = res.data != null ? res.data.items.filter(x => x.monthInYear == 12) : null;


                let dataDoanhSo = [
                    loiNhuan1.length > 0 ? loiNhuan1[0].buyingPrice : 0,
                    loiNhuan2.length > 0 ? loiNhuan2[0].buyingPrice : 0,
                    loiNhuan3.length > 0 ? loiNhuan3[0].buyingPrice : 0,
                    loiNhuan4.length > 0 ? loiNhuan4[0].buyingPrice : 0,
                    loiNhuan5.length > 0 ? loiNhuan5[0].buyingPrice : 0,
                    loiNhuan6.length > 0 ? loiNhuan6[0].buyingPrice : 0,
                    loiNhuan7.length > 0 ? loiNhuan7[0].buyingPrice : 0,
                    loiNhuan8.length > 0 ? loiNhuan8[0].buyingPrice : 0,
                    loiNhuan9.length > 0 ? loiNhuan9[0].buyingPrice : 0,
                    loiNhuan10.length > 0 ? loiNhuan10[0].buyingPrice : 0,
                    loiNhuan11.length > 0 ? loiNhuan11[0].buyingPrice : 0,
                    loiNhuan12.length > 0 ? loiNhuan12[0].buyingPrice : 0,
                ];
                let dataTienVon = [
                    tienVon1.length > 0 ? tienVon1[0].price : 0,
                    tienVon2.length > 0 ? tienVon2[0].price : 0,
                    tienVon3.length > 0 ? tienVon3[0].price : 0,
                    tienVon4.length > 0 ? tienVon4[0].price : 0,
                    tienVon5.length > 0 ? tienVon5[0].price : 0,
                    tienVon6.length > 0 ? tienVon6[0].price : 0,
                    tienVon7.length > 0 ? tienVon7[0].price : 0,
                    tienVon8.length > 0 ? tienVon8[0].price : 0,
                    tienVon9.length > 0 ? tienVon9[0].price : 0,
                    tienVon10.length > 0 ? tienVon10[0].price : 0,
                    tienVon11.length > 0 ? tienVon11[0].price : 0,
                    tienVon12.length > 0 ? tienVon12[0].price : 0,
                ];


                let dataDonHang = [
                    donHang1.length > 0 ? donHang1[0].totalOrders : 0,
                    donHang2.length > 0 ? donHang2[0].totalOrders : 0,
                    donHang3.length > 0 ? donHang3[0].totalOrders : 0,
                    donHang4.length > 0 ? donHang4[0].totalOrders : 0,
                    donHang5.length > 0 ? donHang5[0].totalOrders : 0,
                    donHang6.length > 0 ? donHang6[0].totalOrders : 0,
                    donHang7.length > 0 ? donHang7[0].totalOrders : 0,
                    donHang8.length > 0 ? donHang8[0].totalOrders : 0,
                    donHang9.length > 0 ? donHang9[0].totalOrders : 0,
                    donHang10.length > 0 ? donHang10[0].totalOrders : 0,
                    donHang11.length > 0 ? donHang11[0].totalOrders : 0,
                    donHang12.length > 0 ? donHang12[0].totalOrders : 0,
                ];

              
                [].slice.call(charts).map(function (element) {

                    color = element.getAttribute("data-kt-color");
                    height = parseInt(KTUtil.css(element, 'height'));
                    baseColor = KTUtil.getCssVariableValue('--bs-' + color);
                    successColor = KTUtil.getCssVariableValue('--bs-success');
                    dangerColor  = KTUtil.getCssVariableValue('--bs-danger');

                    options = {
                        series: [
                            {
                                name: 'Doanh số',
                                data: dataDoanhSo
                            }, {
                                name: 'Tiền vốn',
                                data: dataTienVon
                            }, {
                                name: 'Lãi gộp',
                                data: [
                                    dataDoanhSo[0] - dataTienVon[0],
                                    dataDoanhSo[1] - dataTienVon[1],
                                    dataDoanhSo[2] - dataTienVon[2],
                                    dataDoanhSo[3] - dataTienVon[3],
                                    dataDoanhSo[4] - dataTienVon[4],
                                    dataDoanhSo[5] - dataTienVon[5],
                                    dataDoanhSo[6] - dataTienVon[6],
                                    dataDoanhSo[7] - dataTienVon[7],
                                    dataDoanhSo[8] - dataTienVon[8],
                                    dataDoanhSo[9] - dataTienVon[9],
                                    dataDoanhSo[10] - dataTienVon[10],
                                    dataDoanhSo[11] - dataTienVon[11]
                                ]
                            }
                        ],
                        chart: {
                            fontFamily: 'inherit',
                            type: 'bar',
                            height: height,
                            toolbar: {
                                show: false
                            }
                        },
                        plotOptions: {
                            bar: {
                                horizontal: false,
                                columnWidth: ['70%'],
                                endingShape: 'rounded'
                            },
                        },
                        legend: {
                            show: false
                        },
                        dataLabels: {
                            enabled: false
                        },
                        stroke: {
                            show: true,
                            width: 1,
                            colors: ['transparent']
                        },
                        xaxis: {
                            categories: ['Tháng 1', 'Tháng 2', 'Tháng 3', 'Tháng 4', 'Tháng 5', 'Tháng 6',
                                'Tháng 7', 'Tháng 8', 'Tháng 9', 'Tháng 10', 'Tháng 11', 'Tháng 12'],
                            axisBorder: {
                                show: false,
                            },
                            axisTicks: {
                                show: false
                            },
                            labels: {
                                style: {
                                    colors: labelColor,
                                    fontSize: '12px'
                                }
                            }
                        },
                        yaxis: {
                            y: 0,
                            offsetX: 0,
                            offsetY: 0,
                            labels: {
                                formatter: function (value) {
                                    return Util.dinhDangTien(value) + " đ"
                                },
                                style: {
                                    colors: labelColor,
                                    fontSize: '12px'
                                }
                            }
                        },
                        fill: {
                            type: 'solid'
                        },
                        states: {
                            normal: {
                                filter: {
                                    type: 'none',
                                    value: 0
                                }
                            },
                            hover: {
                                filter: {
                                    type: 'none',
                                    value: 0
                                }
                            },
                            active: {
                                allowMultipleDataPointsSelection: false,
                                filter: {
                                    type: 'none',
                                    value: 0
                                }
                            }
                        },
                        tooltip: {
                            style: {
                                fontSize: '12px'
                            },
                            y: {
                                formatter: function (val) {
                                    return Util.dinhDangTien(val) + " đ"
                                }
                            }
                        },
                        colors: [baseColor, dangerColor, successColor],
                        grid: {
                            padding: {
                                top: 10
                            },
                            borderColor: borderColor,
                            strokeDashArray: 4,
                            yaxis: {
                                lines: {
                                    show: true
                                }
                            }
                        }
                    };
                    if (chart == null) {
                        chart = new ApexCharts(element, options);
                        chart.render();

                    } else {
                        chart.updateSeries([
                            {
                                name: 'Doanh số',
                                data: dataDoanhSo
                            }, {
                                name: 'Tiền vốn',
                                data: dataTienVon
                            }, {
                                name: 'Lãi gộp',
                                data: [
                                    dataDoanhSo[0] - dataTienVon[0],
                                    dataDoanhSo[1] - dataTienVon[1],
                                    dataDoanhSo[2] - dataTienVon[2],
                                    dataDoanhSo[3] - dataTienVon[3],
                                    dataDoanhSo[4] - dataTienVon[4],
                                    dataDoanhSo[5] - dataTienVon[5],
                                    dataDoanhSo[6] - dataTienVon[6],
                                    dataDoanhSo[7] - dataTienVon[7],
                                    dataDoanhSo[8] - dataTienVon[8],
                                    dataDoanhSo[9] - dataTienVon[9],
                                    dataDoanhSo[10] - dataTienVon[10],
                                    dataDoanhSo[11] - dataTienVon[11]
                                ]
                            }
                        ])
                    }
                });




                $('.grossProfit').text(Util.dinhDangTien((dataDoanhSo.reduce((a, b) => a + b, 0) - dataTienVon.reduce((a, b) => a + b, 0))) + "đ");

                $('.revenue').text(Util.dinhDangTien(dataDoanhSo.reduce((a, b) => a + b, 0)) + "đ");
                $('.totalOrders').text(Util.dinhDangTien(dataDonHang.reduce((a, b) => a + b, 0)));
                $('.ordeRaverageValue').text(Util.dinhDangTien(dataTienVon.reduce((a, b) => a + b, 0)) + "đ");

            }
        )
    };



    return {
        // public functions
        init: function () {
            form__year_register();
            initialComponents();
        }
    };
}();


