//== Class definition
var Supplier = function () {
    let dtTableOrder, dtTableProduct, dtTableCashBook;
    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('#edit_form_submit');

    let validator = FormValidation.formValidation(edit_form[0], {
        fields: {
            edit_form_firstName: { validators: { notEmpty: { message: "vui lòng nhập tên" } } },
            edit_form_phoneNumber: { validators: { notEmpty: { message: "vui lòng nhập số điện thoại" } } }
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {

        $.each($("a.nav-link"), (i, item) => {

            if ($(item).hasClass("active")) {
                $(item).removeClass("active");
            }
        });

        $("#navProfileDetailEdit").addClass("active");
       
        edit_form_buttonSubmit.click(function (e) {
            e.preventDefault();
            
            if (validator) {
                validator.validate().then(function (e) {
                    let formData = new FormData();
                    if (editingData != null) {
                        formData.append("id", (editingData != null ? editingData.id : null));
                    }

                    edit_form.find("select, textarea, input").each((index, el) => {
                        let fieldName = $(el).data("field");

                        if (fieldName) {
                            switch (fieldName) {
                                case "Avatar":
                                    let files = $(el).prop('files');
                                    if (files.length > 0) {
                                        formData.append("Avatar", files[0]);
                                    }

                                case "StrAppUserTypeIds":
                                    formData.append($(el).data("field"), $(el).val());
                                    break;

                                default:
                                    if ($(el).data("field")) {
                                        formData.append($(el).data("field"), $(el).val());
                                    }
                            }
                        }
                    });

                    "Valid" == e ?
                        (
                            edit_form_buttonSubmit.attr("data-kt-indicator", "on"), (edit_form_buttonSubmit.disabled = !0),
                            App.sendDataFileToURL("/Supplier/SaveProfileDetail", formData, "POST")
                                .then(function (res) {

                                    edit_form_buttonSubmit.removeAttr("data-kt-indicator");
                                    if (!res.isSuccessed) {
                                        Swal.fire(App.swalFireErrorDefaultOption(res.message))
                                    }
                                    else {
                                        Swal.fire(App.swalFireSuccessDefaultOption());
                                        editingData = {
                                            id: res.resultObj
                                        };
                                        (edit_form_buttonSubmit.disabled = !1);
                                    }
                                }
                                )
                        )
                        : Swal.fire(App.swalFireErrorDefaultOption());
                });
            }
            $('input[name="edit_form_code"]').focus();
        });

        $('#btnDeleteAvatar').click(function (e) {
            
            if (editingData != null && editingData.id != null) {
                App.sendDataToURL("/Supplier/DeleteAvatarByUserId?userId=" + editingData.id, null, "GET")
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            Swal.fire(App.swalFireErrorDefaultOption(res.message));
                        }
                        else {
                            $("#edit_form_previewAvatar").attr("src", res.resultObj);
                        }
                    });
            }
        });

        App.initSelect2Base($('[name="edit_form_appUserTypeIds"]'), '/AppUserType/Filter');

        $('[name="edit_form_appUserTypeIds"]').val(null).trigger("change");
        
        if (editingData && editingData.appUserTypes && editingData.appUserTypes.length > 0) {
            let htmlOption = "";
            editingData.appUserTypes.forEach((item) => {
                htmlOption += "<option value=" + item.id + " selected>" + item.name + "</option>";
            });

            $('[name="edit_form_appUserTypeIds"]').append(htmlOption).trigger('change');
        }






        $('.card-toolbar ul li a').click(function () {
            let $this = $(this);
            var active = $(this).attr("href");


            switch (active) {

                case "#kt_supplier_view_order":
                    $this.on("webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend",
                        function (event) {
                            dtTableOrder.columns.adjust();
                        }
                    );
                    break;

                case "#kt_supplier_view_product":
                    dtTableProduct.columns.adjust();
                    break;

                case "#kt_supplier_view_return":
                    $this.on("webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend",
                        function (event) {
                            dtTableReturn.columns.adjust();
                        }
                    );

                    break;
                case "#kt_supplier_view_cashbook":

                    $this.on("webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend",
                        function (event) {
                            dtTableCashBook.columns.adjust();
                        }
                    );
                    break;
            }
        });

        var datatableOrderOption = initialDatatableOption();
        datatableOrderOption.ajax.url = "/Customer/DataTableGetListInfomationByType";
        datatableOrderOption.ajax.data = {
            id: function () {
                return (editingData != null ? editingData.id : null);
            },
            type: function () {
                return 3;
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
        dtTableOrder = $('#kt_supplier_view_table_order').DataTable(datatableOrderOption);

    };

    return {
        // public functions
        init: function () {
            initialComponents();
        }
    };
}();