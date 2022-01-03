//== Class definition

var ProfitAndLoss = function () {

    let initialComponents = () => {

        refreshData();

        $('#fromToDate').change(function (e) {
            e.preventDefault();
            refreshData();
        });
        
        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            refreshData
        });
    };

    let refreshData = function () {
        //call ajax get thuộc tính

        App.sendDataToURL("/ProfitAndLossReport/GetReport", { DateType: $('#fromToDate').val()}, "POST")
            .then(function (res) {
                console.log(res);
                if (res.data.length > 0) {
                    $('#doanhSoKyNay').text(Util.dinhDangTien(res.data[0].doanhSoKyNay) + "đ");
                    $('#doanhSoKyTruoc').text(Util.dinhDangTien(res.data[0].doanhSoKyTruoc) + "đ");

                    if (res.data[0].doanhSoKyTruoc != 0) {
                        if (res.data[0].doanhSoKyNay / res.data[0].doanhSoKyTruoc > 1) {
                            if ($('#doanhSoThayDoi').hasClass("badge-danger")) $('#doanhSoThayDoi').removeClass("badge-danger");
                            if (!$('#doanhSoThayDoi').hasClass("badge-success")) $('#doanhSoThayDoi').addClass("badge-success");

                            $('#doanhSoThayDoi').text((parseFloat(res.data[0].doanhSoKyNay / res.data[0].doanhSoKyTruoc) * 100).toFixed(2) + "%");
                        } else {

                            if ($('#doanhSoThayDoi').hasClass("badge-success")) $('#doanhSoThayDoi').removeClass("badge-success");
                            if (!$('#doanhSoThayDoi').hasClass("badge-danger")) $('#doanhSoThayDoi').addClass("badge-danger");

                            $('#doanhSoThayDoi').text((1 - (parseFloat(res.data[0].doanhSoKyNay / res.data[0].doanhSoKyTruoc)) * 100).toFixed(2) + "%");
                        }
                    } else {
                        $('#doanhSoThayDoi').text("");
                    }




                    $('#doanhThuThuanKyNay').text(Util.dinhDangTien(res.data[0].doanhSoKyNay) + "đ");
                    $('#doanhThuThuanKyTruoc').text(Util.dinhDangTien(res.data[0].doanhSoKyTruoc) + "đ");

                    if (res.data[0].doanhSoKyTruoc != 0) {
                        if (res.data[0].doanhSoKyNay / res.data[0].doanhSoKyTruoc > 1) {
                            if ($('#doanhThuThuanThayDoi').hasClass("badge-danger")) $('#doanhThuThuanThayDoi').removeClass("badge-danger");
                            if (!$('#doanhThuThuanThayDoi').hasClass("badge-success")) $('#doanhThuThuanThayDoi').addClass("badge-success");

                            $('#doanhThuThuanThayDoi').text((parseFloat(res.data[0].doanhSoKyNay / res.data[0].doanhSoKyTruoc) * 100).toFixed(2) + "%");
                        } else {

                            if ($('#doanhThuThuanThayDoi').hasClass("badge-success")) $('#doanhThuThuanThayDoi').removeClass("badge-success");
                            if (!$('#doanhThuThuanThayDoi').hasClass("badge-danger")) $('#doanhThuThuanThayDoi').addClass("badge-danger");

                            $('#doanhThuThuanThayDoi').text((1 - (parseFloat(res.data[0].doanhSoKyNay / res.data[0].doanhSoKyTruoc)) * 100).toFixed(2) + "%");
                        }
                    } else {
                        $('#doanhThuThuanThayDoi').text("");
                    }


                    $('#laiGopKyNay').text(Util.dinhDangTien(res.data[0].laiGopKyNay) + "đ");
                    $('#laiGopKyTruoc').text(Util.dinhDangTien(res.data[0].laiGopKyTruoc) + "đ");

                    if (res.data[0].laiGopKyTruoc != 0) {
                        if (res.data[0].laiGopKyNay / res.data[0].laiGopKyTruoc > 1) {
                            if ($('#laiGopThayDoi').hasClass("badge-danger")) $('#laiGopThayDoi').removeClass("badge-danger");
                            if (!$('#laiGopThayDoi').hasClass("badge-success")) $('#laiGopThayDoi').addClass("badge-success");

                            $('#laiGopThayDoi').text((parseFloat(res.data[0].laiGopKyNay / res.data[0].laiGopKyTruoc) * 100).toFixed(2) + "%");
                        } else {

                            if ($('#laiGopThayDoi').hasClass("badge-success")) $('#laiGopThayDoi').removeClass("badge-success");
                            if (!$('#laiGopThayDoi').hasClass("badge-danger")) $('#laiGopThayDoi').addClass("badge-danger");

                            $('#laiGopThayDoi').text((1 - (parseFloat(res.data[0].laiGopKyNay / res.data[0].laiGopKyTruoc)) * 100).toFixed(2) + "%");
                        }
                    } else {
                        $('#laiGopThayDoi').text("");
                    }


                    $('#tienVonKyNay').text(Util.dinhDangTien(res.data[0].tienVonKyNay) + "đ");
                    $('#tienVonKyTruoc').text(Util.dinhDangTien(res.data[0].tienVonKyTruoc) + "đ");
                    if (res.data[0].tienVonKyTruoc != 0) {
                        if (res.data[0].tienVonKyNay / res.data[0].tienVonKyTruoc > 1) {
                            if ($('#tienVonThayDoi').hasClass("badge-danger")) $('#tienVonThayDoi').removeClass("badge-danger");
                            if (!$('#tienVonThayDoi').hasClass("badge-success")) $('#tienVonThayDoi').addClass("badge-success");

                            $('#tienVonThayDoi').text((parseFloat(res.data[0].tienVonKyNay / res.data[0].tienVonKyTruoc) * 100).toFixed(2) + "%");
                        } else {

                            if ($('#tienVonThayDoi').hasClass("badge-success")) $('#tienVonThayDoi').removeClass("badge-success");
                            if (!$('#tienVonThayDoi').hasClass("badge-danger")) $('#tienVonThayDoi').addClass("badge-danger");

                            $('#tienVonThayDoi').text((1 - (parseFloat(res.data[0].tienVonKyNay / res.data[0].tienVonKyTruoc)) * 100).toFixed(2) + "%");
                        }
                    } else {
                        $('#tienVonThayDoi').text("");
                    }
                    
                    $('#laiRongKyNay').text(Util.dinhDangTien(res.data[0].laiGopKyNay) + "đ");
                    $('#laiRongKyTruoc').text(Util.dinhDangTien(res.data[0].laiGopKyTruoc) + "đ");

                    if (res.data[0].laiGopKyTruoc != 0) {
                        if (res.data[0].laiGopKyNay / res.data[0].laiGopKyTruoc > 1) {
                            if ($('#laiRongThayDoi').hasClass("badge-danger")) $('#laiRongThayDoi').removeClass("badge-danger");
                            if (!$('#laiRongThayDoi').hasClass("badge-success")) $('#laiRongThayDoi').addClass("badge-success");

                            $('#laiRongThayDoi').text((parseFloat(res.data[0].laiGopKyNay / res.data[0].laiGopKyTruoc) * 100).toFixed(2) + "%");
                        } else {

                            if ($('#laiRongThayDoi').hasClass("badge-success")) $('#laiRongThayDoi').removeClass("badge-success");
                            if (!$('#laiRongThayDoi').hasClass("badge-danger")) $('#laiRongThayDoi').addClass("badge-danger");

                            $('#laiRongThayDoi').text((1 - (parseFloat(res.data[0].laiGopKyNay / res.data[0].laiGopKyTruoc)) * 100).toFixed(2) + "%");
                        }
                    } else {
                        $('#laiRongThayDoi').text("");
                    }




                    if (res.data[0].doanhSoKyNay != 0) $('#laiGopPhanTramKyNay').text((parseFloat(res.data[0].laiGopKyNay / res.data[0].doanhSoKyNay) * 100).toFixed(2) + "%");
                    if (res.data[0].doanhSoKyTruoc != 0) $('#laiGopPhanTramKyTruoc').text((parseFloat(res.data[0].laiGopKyTruoc / res.data[0].doanhSoKyTruoc) * 100).toFixed(2) + "%");


                    if (res.data[0].doanhSoKyNay != 0) $('#laiRongPhanTramKyNay').text((parseFloat(res.data[0].laiGopKyNay / res.data[0].doanhSoKyNay) * 100).toFixed(2) + "%");
                    if (res.data[0].doanhSoKyTruoc != 0) $('#laiRongPhanTramKyTruoc').text((parseFloat(res.data[0].laiGopKyTruoc / res.data[0].doanhSoKyTruoc) * 100).toFixed(2) + "%");

                }
            }
        )
    };

    return {
        // public functions
        init: function () {
            //initialDatatable();
            initialComponents();
            
        }
    };
}();
