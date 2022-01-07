//== Class definition

var Home = function () {
    
    let initialComponents = () => {
        refreshData();
        $('#fromToDate').change(function (e) {
            e.preventDefault();
            refreshData();
        });

    };


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
            
            initialComponents();
        }
    };
}();


