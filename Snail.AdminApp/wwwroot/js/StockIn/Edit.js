//== Class definition

var StockIn = function () {
    let modal_form = $("#kt_modal_edit_form"),
        modal_form_buttonSubmit = $('#kt_modal_edit_submit'),
        select_product = $('#kt_modal_edit_form_products'),
        table_product_details = $('#kt_create_new_product_details tbody');

    let validator = FormValidation.formValidation(modal_form[0], {
        fields: {
            kt_modal_edit_form_total: { validators: { notEmpty: { message: "vui lòng nhập số tiền" } } },
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let initialComponents = () => {
        $('.tien-VND').autoNumeric('init', initialTienVNDOption());
        select_product.autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: '/ProductSKU/Filter',
                    data: {
                        textSearch: request.term
                    },
                    success: function (data) {
                        console.log(data);
                        response($.map(data.items, function (item) {
                            var data = {
                                value: item.id,
                                label: item.name,
                                price: item.price,
                                buyingPrice: item.buyingPrice,
                                code: item.code
                            };
                            return data;
                        }));
                    }
                });
            },
            minLength: 1,
            open: function () {
                $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
            },
            close: function () {
                $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
            },
            change: function (event, ui) {
                console.log('change :' + event, ui)
            },
            select: function (event, ui) {
                if (!ui.item) {
                    console.log('select !ui :' + event, ui)
                } else {
                    $('#kt_modal_edit_form_products').val('');
                    onAddProduct(ui.item);
                }
                return false;
            }
        });


        $('#kt_modal_edit_submit').click(function (e) {
            e.preventDefault();
            let result = {}, phieuKeToanChiTiets=[];
            if (validator) {
                validator.validate().then(function (e) {
                    "Valid" == e ?
                        (
                            modal_form_buttonSubmit.attr("data-kt-indicator", "on"), (modal_form_buttonSubmit.disabled = !0),

                            modal_form.find("select, input, textarea").each((index, el) => {
                                let type = $(el).attr('type');
                                let isVNDFormat = $(el).hasClass('tien-VND');
                                let colName = $(el).data("field");

                                if (!App.isNullOrEmpty(colName)) {
                                    switch (colName) {
                                        case "CustomerId":
                                            if (!App.isNullOrEmpty($(el).val())) {
                                                result[colName] = $(el).val();
                                            }
                                            break;

                                        default:
                                            if (type == 'checkbox') {
                                                result[colName] = $(el).is(':checked');
                                            } else if ($(el).tagName == 'textarea') {
                                                result[colName] = $(el).text();
                                            } else {
                                                result[colName] = (isVNDFormat ? $(el).autoNumeric('get') : $(el).val());
                                            }
                                            break;
                                    }
                                }
                            }),

                            table_product_details.find('tr').each((index, el) => {
                                let obj = {};
                                $(el).find("td input").each((index, elTd) => {
                                    let isVNDFormat = $(elTd).hasClass('tien-VND');
                                    let colName = $(elTd).data("field");

                                    switch (colName) {

                                        case "ProductSKUId":
                                            obj[colName] = App.isNullOrEmpty($(elTd).val()) ? -1 : $(elTd).val();
                                            break;

                                        default:
                                            obj[colName] = (isVNDFormat ? $(elTd).autoNumeric('get') : $(elTd).val());
                                            break;
                                    }

                                });
                                phieuKeToanChiTiets.push(obj);
                            }),

                            result["PhieuKeToanChiTiets"] = phieuKeToanChiTiets,


                            data = {
                                Id:  null,
                                Data: result
                            },
                            App.sendDataToURL("/StockIn/Save", data, "POST")
                            .then(function (res)
                            {
                                modal_form_buttonSubmit.removeAttr("data-kt-indicator");
                                if (!res.isSuccessed) {
                                    Swal.fire({
                                        text: res.message,
                                        icon: "error",
                                        buttonsStyling: !1,
                                        confirmButtonText: "Đóng !",
                                        customClass: { confirmButton: "btn btn-primary" },
                                    })
                                }
                                else {
                                    window.location.href = "/StockIn/Index";
                                }
                            }
                        )
                        )
                    : Swal.fire({
                        text: "Có lỗi xảy ra vui lòng kiểm tra lại.",
                        icon: "error",
                        buttonsStyling: !1,
                        confirmButtonText: "Đóng !",
                        customClass: { confirmButton: "btn btn-primary" },
                    });
                });
            }
           
        });

        $(document).keydown(function (event) {
            if (event.which == 115) { //F4
                select_product.focus();
                return false;
            }
        });
    };

    // tag added callback
    let onAddProduct = (e) => {
        if ($('#product_' + e.value + '').length <= 0) {

            let html = '<tr id="product_' + e.value + '">\
                <td>\
                <input hidden  type="number" class="form-control" data-field="ProductSKUId" value="'+ e.value + '">\
                    <div class="d-flex align-items-center">\
                        <div class="d-flex justify-content-start flex-column">\
                            <a href="#" class="text-dark fw-bolder text-hover-primary fs-6">'+ e.label + '</a>\
                            <span class="text-muted fw-bold text-muted d-block fs-7">'+ e.code + '</span>\
                        </div>\
                    </div>\
                </td>\
                <td>\
                    <input type="number" class="form-control inputQtyProductDetail" min="1" form-control-solid" data-id="'+ e.value + '" autocomplete="off" name="null-0" data-field="Qty" value="1">\
                </td>\
                <td>\
                    <input type="text" class="form-control form-control-solid tien-VND inputPriceProductDetail" data-id="'+ e.value + '" autocomplete="off" name="null-0" data-field="Price" value="'+e.price+'">\
                </td>\
                <td>\
                    <input type="text" class="form-control form-control-solid tien-VND inputTotalProductDetail" data-id="'+ e.value + '"  disabled name="null-0" data-field="Total" value="' + e.price +'">\
                </td>\
                <td>\
                    <input type="text" class="form-control form-control-solid tien-VND" data-id="'+ e.value + '" autocomplete="off" name="null-0" data-field="BuyingPrice" value="' + e.buyingPrice +'">\
                </td>\
                <td class="text-center">\
                    <a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm  delete_product_details" data-id="'+ e.value + '">\
                        <!--begin::Svg Icon | path: icons/duotone/General/Trash.svg-->\
                        <span class="svg-icon svg-icon-3">\
                            <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
                                <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">\
                                    <rect x="0" y="0" width="24" height="24"></rect>\
                                    <path d="M6,8 L6,20.5 C6,21.3284271 6.67157288,22 7.5,22 L16.5,22 C17.3284271,22 18,21.3284271 18,20.5 L18,8 L6,8 Z" fill="#000000" fill-rule="nonzero"></path>\
                                    <path d="M14,4.5 L14,4 C14,3.44771525 13.5522847,3 13,3 L11,3 C10.4477153,3 10,3.44771525 10,4 L10,4.5 L5.5,4.5 C5.22385763,4.5 5,4.72385763 5,5 L5,5.5 C5,5.77614237 5.22385763,6 5.5,6 L18.5,6 C18.7761424,6 19,5.77614237 19,5.5 L19,5 C19,4.72385763 18.7761424,4.5 18.5,4.5 L14,4.5 Z" fill="#000000" opacity="0.3"></path>\
                                </g>\
                            </svg>\
                        </span>\
                        <!--end::Svg Icon-->\
                    </a>\
                </td>\
            </tr>';
            table_product_details.append(html);
            $('.tien-VND').autoNumeric('init', initialTienVNDOption());
            initEnventChangeValueAndDeleteProductDetail();
            refreshTotal();
        }
    }

    let initEnventChangeValueAndDeleteProductDetail = () => {
        //ChangeValue
        let qty = 0, price = 0;

        $('.inputQtyProductDetail').change(function (e) {
            qty = parseFloat($(this).val());
            price = parseFloat($('.inputPriceProductDetail[data-id="' + $(this).data('id') + '"]').autoNumeric('get'));
            $('.inputTotalProductDetail[data-id="' + $(this).data('id') + '"]').autoNumeric('set', qty * price);
            refreshTotal();
        });

        $('.inputPriceProductDetail').change(function (e) {
            qty = parseFloat($('.inputQtyProductDetail[data-id="' + $(this).data('id') + '"]').val());
            price = parseFloat($(this).autoNumeric('get'));
            $('.inputTotalProductDetail[data-id="' + $(this).data('id') + '"]').autoNumeric('set', qty * price);
            refreshTotal();
        });

        //Delete 
        $('.delete_product_details').click(function (e) {
            $('#kt_create_new_product_details tbody #product_' + $(this).data('id')).remove();
            refreshTotal();
        });
    }

    let refreshTotal = () => {

        let tongTien = 0;

        table_product_details.find('tr').each((index, el) => {
            $(el).find('td input').each((idx, elT) => {
                tongTien += $(elT).data('field') == "Total" ? parseFloat($(elT).autoNumeric('get')) : 0;
            });
        });

        $('#kt_modal_edit_form_total').autoNumeric('set', tongTien);
    }

    function initSelect2() {


        $('[name="kt_form_edit_supplier"]').select2(
            {
                ajax: {
                    url: '/Supplier/Filter',
                    data: function (params) {
                        var query = {
                            textSearch: params.term
                        };

                        return query;
                    },
                    processResults: function (res) {
                        console.log(res.items)
                        var data = $.map(res.items, function (item, i) {

                            return {
                                id: item.id,
                                text: item.lastName + ' ' + item.firstName
                            }
                        });
                        data.unshift({
                            id: 0,
                            text: "Không chọn"
                        })

                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');
    }

    return {
        // public functions
        init: function () {
            initialComponents();
            form__date_register();
            initSelect2()
        }
    };
}();