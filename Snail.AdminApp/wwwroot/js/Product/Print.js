//== Class definition

var Product = function () {
    let modal_form = $("#kt_modal_edit_form"),
        modal_form_buttonSubmit = $('#kt_modal_edit_submit'),
        select_product = $('#kt_modal_edit_form_products'),
        table_product_details = $('#kt_create_new_product_details tbody');


    let initialComponents = () => {
        select_product.autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: '/ProductSKU/Filter',
                    data: {
                        textSearch: request.term
                    },
                    success: function (data) {
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


        $("button[name=kt_modal_import_excel]").click(function (e) {
            console.log('a')
            $('#fileImportDataPrint').trigger('click');
        });

        $('#fileImportDataPrint').change(function () {

            let dataFile = new FormData();

            let files = $(this).prop('files');
            if (files.length > 0) {
                for (var x = 0; x < files.length; x++) {
                    dataFile.append("file" + x, files[x]);
                }
            }

            var url = "/Product/ImportExcelPrint";

            App.sendDataFileToURL(url, dataFile, "POST")
                .then(function (res) {
                    if (res) {
                        console.log(res);
                        $.each(res.resultObj, function (index, item) {
                            console.log(item)
                            onAddProduct({ value: item.id, label: item.name, code: item.code, qty: item.qtyInStock, buyingPrice: item.buyingPrice });
                        });
                    }
                });
        });


        $('#kt_modal_edit_submit').click(function (e) {
            e.preventDefault();
            let result = {}, products = [];
            result.Code = "QR";
            result.SizeName = $('input[name=sizeName]:checked').val();
            modal_form_buttonSubmit.attr("data-kt-indicator", "on"), (modal_form_buttonSubmit.disabled = !0),
                table_product_details.find('tr').each((index, el) => {
                    let obj = {};
                    $(el).find("td input").each((index, elTd) => {
                        let colName = $(elTd).data("field");

                        switch (colName) {
                            default:
                                obj[colName] = App.isNullOrEmpty($(elTd).val()) ? -1 : $(elTd).val();
                                break;
                        }

                    });
                    products.push(obj);
                }),
                result["ProductSkuPrints"] = products,
                data = {
                    Id: null,
                    Data: result
                }

                App.sendDataToURL("/Product/PrintQRCode", data, "POST")
                .then(function (res) {
                    printJS({ printable: res.resultObj, type: 'pdf', base64: true })
                }
            )
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
            console.log(e, e.qty);
            let html = '<tr id="product_' + e.value + '">\
                <td>\
                <input hidden type="number" class="form-control" data-field="ProductSKUId" value="'+ e.value + '">\
                <input hidden type="number" class="form-control" data-field="ProductCode" value="'+ e.code + '">\
                <input hidden type="number" class="form-control" data-field="ProductName" value="'+ e.label + '">\
                <input hidden type="number" class="form-control" data-field="ProductPrice" value="'+ e.buyingPrice + '">\
                    <div class="d-flex align-items-center">\
                        <div class="d-flex justify-content-start flex-column">\
                            <a href="#" class="text-dark fw-bolder text-hover-primary fs-6">'+ e.label + '</a>\
                            <span class="text-muted fw-bold text-muted d-block fs-7">'+ e.code + '</span>\
                        </div>\
                    </div>\
                </td>\
                <td>\
                    <input type="number" class="form-control inputQtyProductDetail" min="1" form-control-solid" data-id="'+ e.value + '" autocomplete="off" name="null-0" data-field="Qty" value="' +( e.qty != undefined ? e.qty : 1) +'">\
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
            initEnventDeleteProductDetail();
        }
    }

    let initEnventDeleteProductDetail = () => {
        //Delete 
        $('.delete_product_details').click(function (e) {
            $('#kt_create_new_product_details tbody #product_' + $(this).data('id')).remove();
        });
    }

    return {
        // public functions
        init: function () {
            initialComponents();
        }
    };
}();