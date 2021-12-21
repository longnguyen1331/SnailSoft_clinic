//== Class definition

var Supplier = function () {
    let dtTableOrder = null, dtTableProduct = null, dtTableReturn = null, dtTableCashBook = null;


    let initComponent = () => {
        $('.card-toolbar ul li a').click(function () {
            let $this = $(this);
            var active = $(this).attr("href");
            switch (active) {
                case "#kt_customer_view_stockin":
                    $this.on("webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend",
                        function (event) {
                            dtTableOrder.columns.adjust();
                        }
                    );
                    break;
                case "#kt_customer_view_product":
                    break;
                case "#staffApprovedDefault":
                    tableDefaultApproved.columns.adjust();
                    break;
                case "#kt_customer_view_return":
                    $this.on("webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend",
                        function (event) {
                            dtTableReturn.columns.adjust();

                        }
                    );

                    break;
                case "#kt_customer_view_cashbook":

                    $this.on("webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend",
                        function (event) {
                            dtTableCashBook.columns.adjust();

                        }
                    );


                    break;
            }
        });


    }

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




        var datatableReturnOption = initialDatatableOption();
        datatableReturnOption.ajax.url = "/Customer/DataTableGetListInfomationByType";
        datatableReturnOption.ajax.data = {
            id: function () {
                return sup.id;
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


        var datatableCashBookOption = initialDatatableOption();
        datatableCashBookOption.ajax.url = "/Customer/DataTableGetListCashBook";
        datatableCashBookOption.ajax.data = {
            id: function () {
                return sup.id;
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



        //var datatableProductOption = initialDatatableOption();
        //datatableProductOption.ajax.url = "/Customer/DataTableGetListInfomationByType";
        //datatableProductOption.ajax.data = {
        //    type: function () {
        //        return -1;
        //    }
        //};
        //datatableProductOption.order = [[1, "desc"]];
        //datatableProductOption.columnDefs = [
        //    {
        //        "targets": [0],
        //        className: 'dt-body-center',
        //        "visible": false
        //    }
        //];
        //datatableProductOption.columns = [
        //    { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
        //    {
        //        "data": "code", "name": "code", "autoWidth": true, "title": "Mã", "render": function (data, type, full, meta) {
        //            return '<div class="d-flex justify-content-start flex-column">\
		      //          <a href="#!"  class="fw-bolder text-hover-primary fs-6">' + data + '</a>\
	       //         </div>';
        //        }
        //    },
        //    { "data": "dateString", "name": "dateString", "autoWidth": true, "title": "Ngày" },
        //    {
        //        "data": "totalMoney", "name": "totalMoney", "autoWidth": true, "title": "Tổng tiền", "render": $.fn.dataTable.render.number(',', '.', 0),
        //        "mRender": function (data, type, row, meta) {
        //            return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
        //        }
        //    }
        //]
        //dtTableProduct = $('#kt_customer_view_table_product').DataTable(datatableProductOption);


    };


    return {
        // public functions
        init: function () {
            initialDatatable();
            initComponent();
        }
    };
}();

jQuery(document).ready(function () {
    Customer.init();
});

