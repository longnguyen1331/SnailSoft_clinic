//== Class definition

var Home = function () {
    
    let initialComponents = () => {
        refreshData();
        $('#fromToDate').change(function (e) {
            e.preventDefault();
            refreshData();
        });




    };

    var initMixedWidget10 = function () {
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

        [].slice.call(charts).map(function (element) {

            color = element.getAttribute("data-kt-color");
            height = parseInt(KTUtil.css(element, 'height'));
            baseColor = KTUtil.getCssVariableValue('--bs-' + color);
            successColor = KTUtil.getCssVariableValue('--bs-success');

            options = {
                series: [
                {
                    name: 'Doanh số',
                    data: [600000, 2580000, 2383000, 5000000, 1800000, 6800000, 600000, 2580000, 2383000, 5000000, 1800000, 6800000]
                    }, {
                        name: 'Lợi nhuận',
                        data: [600000, 2580000, 2383000, 5000000, 1800000, 6800000, 600000, 2580000, 2383000, 5000000, 1800000, 6800000]
                    }],
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
                        columnWidth: ['30%'],
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
                colors: [baseColor, successColor],
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

            chart = new ApexCharts(element, options);
            chart.render();
        });
    }

    let refreshData = function () {
        //call ajax get thuộc tính

        let fDate = '', tDate = '';
        if (!App.isNullOrEmpty($('#fromToDate').val())) {
            fDate =  $('#fromToDate').val().split('-')[0].trim();
        }

        if (!App.isNullOrEmpty($('#fromToDate').val())) {
            tDate=  $('#fromToDate').val().split('-')[1] !== undefined ? $('#fromToDate').val().split('-')[1].trim() : '';
        }

        App.sendDataToURL("/Home/GetReport", { FromDate: fDate, ToDate: tDate }, "POST")
            .then(function (res) {
                console.log(res);
                $('.thu').text(Util.dinhDangTien(res.data.totalCollectMoney) + "đ")
                $('.chi').text(Util.dinhDangTien(res.data.totalPayment) + "đ")
                $('.thuMinusChi').text(Util.dinhDangTien(res.data.totalCollectMoney - res.data.totalPayment) + "đ")
                
                $('.grossProfit').text(Util.dinhDangTien(res.data.grossProfit) + "đ")
                $('.revenue').text(Util.dinhDangTien(res.data.revenue) + "đ")
                $('.totalOrders').text(Util.dinhDangTien(res.data.totalOrders))
                $('.ordeRaverageValue').text(Util.dinhDangTien(res.data.ordeRaverageValue) + "đ")
                $('.totalProductInStock').text(Util.dinhDangTien(res.data.totalProductInStock))
                $('.totalProductOutStock').text(Util.dinhDangTien(res.data.totalProductOutStock))
            }
        )
    };



    return {
        // public functions
        init: function () {
            form__date_range_register();
            initialComponents();
            initMixedWidget10();
        }
    };
}();


