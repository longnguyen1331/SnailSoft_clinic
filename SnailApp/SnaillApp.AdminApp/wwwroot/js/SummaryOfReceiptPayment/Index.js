//== Class definition

var SummaryOfReceiptPayment = function () {
    
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

        App.sendDataToURL("/SummaryOfReceiptPayment/GetReport", { FromDate: fDate, ToDate: tDate }, "POST")
            .then(function (res) {
                $('.tongQuanDongTienTheoSo').text(Util.dinhDangTien(res.data.openingBalance + res.data.totalCollectMoney - res.data.totalPaymentMoney) + "đ")
                $('.thu').text(Util.dinhDangTien(res.data.totalCollectMoney) + "đ")
                $('.chi').text(Util.dinhDangTien(res.data.totalPaymentMoney) + "đ")
                $('#openingBalance').text(Util.dinhDangTien(res.data.openingBalance) + "đ")
            }
        )
    };



    return {
        // public functions
        init: function () {
            form__date_range_register();
            initialComponents();
        }
    };
}();

jQuery(document).ready(function () {
    SummaryOfReceiptPayment.init();
});

