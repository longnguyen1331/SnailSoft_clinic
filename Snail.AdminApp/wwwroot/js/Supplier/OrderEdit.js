//== Class definition

var Supplier = function () {

    let initialComponents = () => {

        $.each($("a.nav-link"), (i, item) => {

            if ($(item).hasClass("active")) {
                $(item).removeClass("active");
            }
        });

        $("#navOrderEdit").addClass("active");
    };

    let initialDatatable = function () {
        var datatableOrderOption = initialDatatableOption();
        datatableOrderOption.ajax.url = "/Customer/DataTableGetListInfomationByType";
        datatableOrderOption.ajax.data = {
            id: function () {
                return sup.id;
            },
            type: function () {
                return 2;
            }
        };
        datatableOrderOption.order = [[1, "desc"]];
        datatableOrderOption.columnDefs = [
            {
                "targets": "_all",
                "className": "dt-head-center"
            },
            {
                "targets": [0],
                className: 'dt-body-center',
                "visible": false
            }
        ];
        datatableOrderOption.columns = [
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
        dtTableOrder = $('#kt_customer_view_table_order').DataTable(datatableOrderOption);
    };

    return {
        init: function () {
            initialComponents();
            initialDatatable();
        }
    };
}();