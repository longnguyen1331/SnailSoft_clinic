//== Class definition

var Customer = function () {
    
    let initialComponents = () => {

        $.each($("a.nav-link"), (i, item) => {

            if ($(item).hasClass("active")) {
                $(item).removeClass("active");
            }
        });

        $("#navProductReturnEdit").addClass("active");



        var datatableReturnOption = initialDatatableOption();
        datatableReturnOption.ajax.url = "/Customer/DataTableGetListInfomationByType";
        datatableReturnOption.ajax.data = {
            id: function () {
                return (editingData != null ? editingData.id : null);
            },
            type: function () {
                return 3;
            }
        };
        datatableReturnOption.order = [[1, "desc"]];
        datatableReturnOption.columnDefs = [
            {
                "targets": [0],
                className: 'dt-body-center',
                "visible": false
            }
        ];
        datatableReturnOption.columns = [
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
        dtTableReturn = $('#kt_customer_view_table_return').DataTable(datatableReturnOption);


    };

    return {
        init: function () {
            initialComponents();
        }
    };
}();