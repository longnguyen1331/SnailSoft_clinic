//== Class definition

var Customer = function () {

    let initialComponents = () => {

        $.each($("a.nav-link"), (i, item) => {

            if ($(item).hasClass("active")) {
                $(item).removeClass("active");
            }
        });

        $("#navCashBookEdit").addClass("active");


        var datatableCashBookOption = initialDatatableOption();
        datatableCashBookOption.ajax.url = "/Customer/DataTableGetListCashBook";
        datatableCashBookOption.ajax.data = {
            id: function () {
                return (editingData != null ? editingData.id : null);
            },
            type: function () {
                return -1;
            }
        };
        datatableCashBookOption.order = [[1, "desc"]];
        datatableCashBookOption.columnDefs = [
            {
                "targets": [0],
                className: 'dt-body-center',
                "visible": false
            }
        ];
        datatableCashBookOption.columns = [
            { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
            {
                "data": "code", "name": "code", "autoWidth": true, "title": "Mã", "render": function (data, type, full, meta) {
                    return '<div class="d-flex justify-content-start flex-column">\
		                <a href="#!"  class="fw-bolder text-hover-primary fs-6">' + data + '</a>\
	                </div>';
                }
            },
            { "data": "dateString", "name": "dateString", "autoWidth": true, "title": "Ngày" },
            {
                "data": "totalMoney", "name": "totalMoney", "autoWidth": true, "title": "Tổng tiền", "render": $.fn.dataTable.render.number(',', '.', 0),
                "mRender": function (data, type, row, meta) {
                    return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                }
            }
        ]
        dtTableCashBook = $('#kt_customer_view_table_cashbook').DataTable(datatableCashBookOption);


    };

    return {
        init: function () {
            initialComponents();
        }
    };
}();