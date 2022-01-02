//== Class definition

var Product = function () {
    let dtTable = null, images = [], files = [], myDropzone = null,clearDropzone;
    let modal = $("#kt_modal_edit"),
        modal_form = $("#kt_modal_edit_form"),
        modal_form_buttonSubmit = $('#kt_modal_edit_submit'),
        modal_header_text = $("#kt_modal_edit_header_text"),
        table_attribute = $('#kt_create_new_attribute_fields tbody'),

        modal_form_submit_text = $("#kt_modal_edit_submit_text"),
        editingDataRow = null;
    let textValue = '';
    let validator = FormValidation.formValidation(modal_form[0], {
        fields: {
            kt_form_edit_name: { validators: { notEmpty: { message: "vui lòng nhập tên hàng hóa" } } },
            kt_form_edit_productType: { validators: { notEmpty: { message: "vui lòng chọn nhóm hàng hóa" } } },
        },
        plugins: {
            trigger: new FormValidation.plugins.Trigger(),
            bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
        },
    });

    let importFileFromExcelDropzone;

    let initialComponents = () => {

        myDropzone = new Dropzone("#kt_dropzonejs_example_images", {
            url: '/Product/UploadImage',
            paramName: "upload",
            maxFiles: 10,
            maxFilesize: 10, // MB
            addRemoveLinks: true,
            success: function (file, response) {
                files.push(file)
                images.push({ 'ImagePath': response.url, 'FileSize': response.size })
            },
           
            removedfile: function (file) {
                var i = files.map(function (obj, index) {
                    if (file == obj) {
                        return index;
                    }
                });
                files.splice(i, 1);
                images.splice(i, 1);

                file.previewElement.remove();
            }
        });



        Dropzone.options.importFileFromExcelDropzone = new Dropzone("#kt_dropzonejs_import_file", {
            autoProcessQueue: false,
            uploadMultiple: false,
            acceptedFiles:".xls,.xlsx,.csv",
            url: '/Product/ImportExcel',
            paramName: "importFile",
            maxFiles: 1,
            maxFilesize: 10, // MB
            addRemoveLinks: true,
            init: function () {
                importFileFromExcelDropzone = this;
            },
            success: function (file, response) {
                console.log(file, response)
            }
        });


        $("#btnImportExcel").click(function (e) {
            e.preventDefault();

            $('#fileImportData').trigger('click');
        });

        $('#fileImportData').change(function () {

            let dataFile = new FormData();

            let files = $(this).prop('files');
            if (files.length > 0) {
                for (var x = 0; x < files.length; x++) {
                    dataFile.append("file" + x, files[x]);
                }
            }

            var url = "/Product/ImportExcel";

            App.sendDataFileToURL(url, dataFile, "POST")
                .then(function (res) {
                    if (res) {
                        if (!res.isSuccessed) {
                            Swal.fire(App.swalFireErrorDefaultOption(res.message))
                        }
                        else {
                            Swal.fire(App.swalFireSuccessDefaultOption())
                            dtTable.draw();
                        }
                    }
                });
        });

        $('.tien-VND').autoNumeric('init', initialTienVNDOption());

        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('button[name="btnCreate"]').click(function (e) {
            e.preventDefault();

            editingDataRow = null;
            resetForm();
            $('input[name="kt_form_edit_IsProduct"]').prop('checked', true);
            if (!$('#closeAttribute').hasClass('collapsed')) $('#closeAttribute').trigger('click');

            modal_header_text.text("Thêm hàng hóa");
            modal_form_submit_text.text("Thêm");
            modal.modal('show');
        });

        $('button[name="btnCancelAttribute"]').click(function (e) {
            e.preventDefault(); // cancel default behavior
           
            if ($('#kt_attribute_method').hasClass('show')) {
                $('#closeAttribute').trigger('click');
                $('[name="kt_form_edit_attribute"]').val(null).trigger('change');
                $('#kt_form_edit_isHasSKU').prop('checked', false);
                removeAllTag();
                $('#kt_attribute_method').removeClass('show')
            }
        });

        $('#kt_form_edit_isHasSKU').on('change', function (e) {
            e.preventDefault();
            if (this.checked && !$('#kt_attribute_method').hasClass('show')) {
                $('#kt_attribute_method').addClass('show');

            } else {
                $('#kt_attribute_method').removeClass('show');
                $('[name="kt_form_edit_attribute"]').val(null).trigger('change');
                removeAllTag();
            }
        });



        
        $('[name="kt_form_edit_attribute"],[name="kt_form_edit_attribute_1"]').select2(

            {
                ajax: {
                    url: '/Attribute/Filter',
                    data: function (params) {
                        textValue = params.term;
                        var query = {
                            textSearch: params.term
                        };
                        return query;
                    },
                    processResults: function (res) {
                        var data = $.map(res.items, function (item, i) {
                            return {
                                id: item.id,
                                text: item.name
                            }
                        });

                        if (data.length <= 0) {
                            data.unshift({
                                id: -1,
                                text: textValue
                            })
                        }

                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');

        $('[name="kt_form_edit_manufactuer"]').select2(

            {
                ajax: {
                    url: '/Manufacturer/Filter',
                    data: function (params) {
                        textValue = params.term;
                        var query = {
                            textSearch: params.term
                        };
                        return query;
                    },
                    processResults: function (res) {
                        var data = $.map(res.items, function (item, i) {
                            return {
                                id: item.id,
                                text: item.name
                            }
                        });

                        if (data.length <= 0) {
                            data.unshift({
                                id: -1,
                                text: textValue
                            })
                        }

                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');

        $('[name="kt_form_edit_manufactuer"]').on("select2:select", function (e) {
            if (e.params.data.id < 0) {
                var data = {
                    Id: null,
                    Data: {
                        Name: e.params.data.text,
                        Description: ''
                    }
                };

                App.sendDataToURL("/Manufacturer/Save", data, "POST")
                    .then(function (res) {
                        $('[name="kt_form_edit_manufactuer"] option[value="-1"]').remove();
                        var option = new Option(e.params.data.text, res.resultObj, true, true);
                        $('[name="kt_form_edit_manufactuer"]').append(option).trigger('change');
                    }
                    )
            }
        });

        //product type
        $('[name="kt_form_edit_productType"]').select2(
            {
                ajax: {
                    url: '/ProductType/Filter',
                    data: function (params) {
                        textValue = params.term;
                        var query = {
                            textSearch: params.term
                        };
                        return query;
                    },
                    processResults: function (res) {
                        var data = $.map(res.items, function (item, i) {
                            return {
                                id: item.id,
                                text: item.name
                            }
                        });

                        if (data.length <= 0) {
                            data.unshift({
                                id: -1,
                                text: textValue
                            })
                        }

                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');

        $('[name="kt_form_edit_productType"]').on("select2:select", function (e) {
            console.log(e.params.data);
            if (e.params.data.id < 0) {
                var data = {
                    Id: null,
                    Data: {
                        ParentId: -1,
                        Name: e.params.data.text,
                        SortOrder: 0
                    }
                };
                App.sendDataToURL("/ProductType/Save", data, "POST")
                    .then(function (res) {
                        $('[name="kt_form_edit_productType"] option[value="-1"]').remove();
                        var option = new Option(e.params.data.text, res.resultObj, true, true);
                        $('[name="kt_form_edit_productType"]').append(option);
                        onAddRemoveTag();
                    }
                    )
            } else {
                onAddRemoveTag();
            }
        });



        // attribute

        $('[name="kt_form_edit_attribute"]').on("change", function () {
            removeAllTag();
            $('[name="kt_form_edit_attribute_value"]').select2(
                {
                    ajax: {
                        url: '/AttributeValue/Filter',
                        data: function (params) {
                            textValue = params.term;
                            var query = {
                                attributeId: $('[name="kt_form_edit_attribute"]').val(),
                                textSearch: params.term
                            }
                            return query
                        },
                        processResults: function (res) {
                            var data = $.map(res.items, function (item, i) {
                                return {
                                    id: item.id,
                                    text: item.name
                                }
                            });

                            if (data.length <= 0) {
                                data.unshift({
                                    id: -1,
                                    text: textValue
                                })
                            }

                            return {
                                results: data
                            };
                        }
                    },
                    allowClear: true,
                })
        });

        $('[name="kt_form_edit_attribute_1"]').on("change", function () {
            removeAllTag();
            $('[name="kt_form_edit_attribute_1_value"]').select2(
                {
                    ajax: {
                        url: '/AttributeValue/Filter',
                        data: function (params) {
                            textValue = params.term;
                            var query = {
                                attributeId: $('[name="kt_form_edit_attribute_1"]').val(),
                                textSearch: params.term
                            }
                            return query
                        },
                        processResults: function (res) {
                            var data = $.map(res.items, function (item, i) {
                                return {
                                    id: item.id,
                                    text: item.name
                                }
                            });


                            if (data.length <= 0) {
                                data.unshift({
                                    id: -1,
                                    text: textValue
                                })
                            }

                            return {
                                results: data
                            };
                        }
                    },
                    allowClear: true,
                })
        });

        $('[name="kt_form_edit_attribute"]').on("select2:select", function (e) {
            if (e.params.data.id < 0) {
                var data = {
                    Id: null,
                    Data: {
                        Name: e.params.data.text,
                        Description: ''
                    }
                };

                App.sendDataToURL("/Attribute/Save", data, "POST")
                    .then(function (res) {
                        $('[name="kt_form_edit_attribute"] option[value="-1"]').remove();
                        var option = new Option(e.params.data.text, res.resultObj, true, true);
                        $('[name="kt_form_edit_attribute"]').append(option).trigger('change');
                    }
                )
            }
        });

        $('[name="kt_form_edit_attribute_1"]').on("select2:select", function (e) {
            if (e.params.data.id < 0) {
                var data = {
                    Id: null,
                    Data: {
                        Name: e.params.data.text,
                        Description: ''
                    }
                };

                App.sendDataToURL("/Attribute/Save", data, "POST")
                    .then(function (res) {
                        $('[name="kt_form_edit_attribute_1"] option[value="-1"]').remove();
                        var option = new Option(e.params.data.text, res.resultObj, true, true);
                        $('[name="kt_form_edit_attribute_1"]').append(option).trigger('change');
                    }
                    )
            }
        });

        $('[name="kt_form_edit_attribute_value"]').on("select2:select", function (e) {
            if (e.params.data.id < 0) {
                if ($('[name="kt_form_edit_attribute"]').val() > 0) {
                    var data = {
                        Id: null,
                        Data: {
                            AttributeId: $('[name="kt_form_edit_attribute"]').val(),
                            Name: e.params.data.text,
                            Description: ''
                        }
                    };

                    App.sendDataToURL("/AttributeValue/Save", data, "POST")
                        .then(function (res) {
                            $('[name="kt_form_edit_attribute_value"] option[value="-1"]').remove();
                            var option = new Option(e.params.data.text, res.resultObj, true, true);
                            $('[name="kt_form_edit_attribute_value"]').append(option);
                            onAddRemoveTag();
                        }
                    )
                }
            } else {
                onAddRemoveTag();
            }
        });

        $('[name="kt_form_edit_attribute_value"]').on("select2:unselect", function (e) {
            onAddRemoveTag();
        });

        $('[name="kt_form_edit_attribute_1_value"]').on("select2:select", function (e) {
            if (e.params.data.id < 0) {
                if ($('[name="kt_form_edit_attribute_1"]').val() > 0) {

                    var data = {
                        Id: null,
                        Data: {
                            AttributeId: $('[name="kt_form_edit_attribute_1"]').val(),
                            Name: e.params.data.text,
                            Description: ''
                        }
                    };

                    App.sendDataToURL("/AttributeValue/Save", data, "POST")
                        .then(function (res) {
                            $('[name="kt_form_edit_attribute_1_value"] option[value="-1"]').remove();
                            var option = new Option(e.params.data.text, res.resultObj, true, true);
                            $('[name="kt_form_edit_attribute_1_value"]').append(option);
                            onAddRemoveTag();
                        }
                        )
                }
            } else {
                onAddRemoveTag();
            }
        });

        $('[name="kt_form_edit_attribute_1_value"]').on("select2:unselect", function (e) {
            onAddRemoveTag();
        });

        $('[name="kt_form_edit_productType"]').on("change", function () {
            validator.revalidateField("kt_form_edit_productType");
        });

        $("input[name='imageProduct']").on('change', function (e) {

            var formData = new FormData();
            formData.append('fileNameOld', $('#txt_Image').val());
            formData.append('upload', $("input[name='imageProduct']")[0].files[0]);

            $.ajax({
                url: '/Product/UploadImage',
                type: 'POST',
                data: formData,
                processData: false,
                contentType: false,
                success: function (result) {
                    $('#txt_Image').val(result.url)
                },
                error: function (jqXHR) {
                },
                complete: function (jqXHR, status) {
                }
            });
        });

        $('#kt_modal_edit_submit').click(function (e) {
            e.preventDefault();
            let result = {}, productAttribute = [];
            if (validator) {
                validator.validate().then(function (e) {
                    "Valid" == e ?
                        (
                            modal_form_buttonSubmit.attr("data-kt-indicator", "on"),
                            (modal_form_buttonSubmit.disabled = !0),
                            $("#kt_product_details").find("select, textarea, input, checkbox").each((index, el) => {
                                let type = $(el).attr('type');
                                let isVNDFormat = $(el).hasClass('tien-VND');

                                if ($(el).data("field")) {
                                    result[$(el).data("field")] = (type == 'checkbox' ? $(el).is(':checked') : (isVNDFormat ? $(el).autoNumeric('get') : $(el).val()));
                                }
                            }),

                            table_attribute.find('tr').each((index, el) => {
                                let obj = {};

                                $(el).find("td input").each((index, elTd) => {
                                    let isVNDFormat = $(elTd).hasClass('tien-VND');
                                    if ($(elTd).data("field")) {
                                        obj[$(elTd).data("field")] = (isVNDFormat ? $(elTd).autoNumeric('get') : $(elTd).val());
                                    }
                                });

                                productAttribute.push(obj);
                            }),
                            result["ProductSKU_AttributeValues"] = productAttribute,
                            result["ProductImages"] = images,

                            data = {
                                Id: editingDataRow != null ? editingDataRow.id : -1,
                                Data: result
                            },
                            App.sendDataToURL("/Product/Save", data, "POST")
                                .then(function (res) {
                                    modal_form_buttonSubmit.removeAttr("data-kt-indicator");
                                    if (!res.isSuccessed) {
                                        Swal.fire(App.swalFireErrorDefaultOption(res.message))
                                    }
                                    else {
                                        Swal.fire(App.swalFireSuccessDefaultOption())
                                        editingDataRow = null;
                                        dtTable.draw();
                                        resetForm();
                                        (modal_form_buttonSubmit.disabled = !1);
                                    }
                                }
                                )
                        )
                        : Swal.fire(App.swalFireErrorDefaultOption());
                });
            }
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        $('#btnDelete').click(function (e) {
            e.preventDefault();
            let arr = [];

            $('#dtTable tbody input[type="checkbox"]:checked').each(function () {
                let selectedDataRow = dtTable.row($(this).parents('tr')).data();
                arr.push({ id: selectedDataRow.id });
            });

            if (arr.length > 0) {
                deleteDataRows(arr);
            }
        });

    };

    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/Product/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTableSearch').val();
            }
        };
        datatableOption.order = [[1, "desc"]];
        datatableOption.columnDefs = [
            {
                "targets": [1],
                className: 'dt-body-center',
                "visible": false
            },
            {
                "targets": [0, 6, 7],
                className: 'dt-body-center',
                "orderable": false
            }
        ];

        datatableOption.initComplete = function () {
            var datatablesColumnsApi = this.api().columns();

            new Promise(function (resolve, reject) {
                datatablesColumnsApi.every(function (index) {
                    var column = this;

                    if (index == 0) {
                        $(column.header()).html('<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input id="checkbox-select-all"  class="form-check-input" type ="checkbox"  value ="" >\
                                    </div>');
                    }
                });

                $('#checkbox-select-all').on('change', function (e) {
                    e.preventDefault();

                    $('#dtTable tbody input[type="checkbox"]').prop('checked', this.checked);

                    if (this.checked) {
                        App.showHideButtonDelete(true);
                    } else {
                        App.showHideButtonDelete(false);
                    }
                });

                resolve();
            }).then(function (res) {
                dtTable.columns.adjust();
            });
        };
        datatableOption.columns = [
            {
                "autoWidth": true, "title": "", "render": function (data, type, full, meta) {
                    let html = '<div class="form-check form-check-sm form-check-custom form-check-solid">\
                            <input class="form-check-input" onchange="App.initevencheckbox()"  type ="checkbox" value ="" >\
                                    </div>';
                    return html;
                }
            },
            { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
            {
                "data": "name", "name": "name", "autoWidth": true, "title": "Tên hàng hóa", "render": function (data, type, full, meta) {
                    return '<div class="d-flex align-items-center">\
                        <div class="symbol symbol-45px me-5">\
                            <img src="'+ full.thumbnailImage + '" alt=""></div>\
                            <div class="d-flex justify-content-start flex-column">\
                                <a href="#!"  class="'+ (full.isHasSKU ? ' detail ' : '') +'text-dark fw-bolder text-hover-primary fs-6">'+ data + '</a>\
                                <span class="text-muted fw-bold text-muted d-block fs-7">Mã : '+ (full.isHasSKU ? 'Sản phẩm nhiều loại' : full.code) + '</span>\
                            </div>\
                        </div>';
                }
            },
            {
                "data": "stock", "name": "stock", "autoWidth": true, "title": "SL",
                "mRender": function (data, type, row, meta) {
                    if (row.isHasSKU) {
                        return '<span class="text-muted">0</span>';
                    } else {
                        return '<span class="text-muted">' + data + '</span>';
                    }
                }
            },
            {
                "data": "price", "name": "price", "autoWidth": true, "title": "Giá bán",
                "mRender": function (data, type, row, meta) {
                    if (row.isHasSKU) {
                        return '<span class="text-muted">' + Util.dinhDangTien(row.lowerPrice) + ' -  ' + Util.dinhDangTien(row.higherPrice) +'</span>';
                    } else {
                        return '<span class="text-muted">' + Util.dinhDangTien(data) + '</span>';
                    }
                }
            },
            {
                "data": "productTypeName", "name": "productTypeName", "autoWidth": true, "title": "Nhóm hàng", "render": function (data, type, full, meta) {
                    return '<span class="text-muted">' + data + '</span>';
                }
            },
            {
                "data": "manufactuerName", "name": "manufactuerName", "autoWidth": true, "title": "Nhà SX", "render": function (data, type, full, meta) {
                    return '<span class="text-muted">' + data + '</span>';
                }
            },
            {
                width: "120px", "title": "Hành động", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex justify-content-center flex-shrink-0">';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1 print">\
					            <span class="svg-icon svg-icon-3">\
						    			<!--begin::Svg Icon | path:/var/www/preview.keenthemes.com/metronic/releases/2021-05-14-112058/theme/html/demo2/dist/../src/media/svg/icons/Devices/Printer.svg--><svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
                            <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd" >\
        <rect x="0" y="0" width="24" height="24"/>\
        <path d="M16,17 L16,21 C16,21.5522847 15.5522847,22 15,22 L9,22 C8.44771525,22 8,21.5522847 8,21 L8,17 L5,17 C3.8954305,17 3,16.1045695 3,15 L3,8 C3,6.8954305 3.8954305,6 5,6 L19,6 C20.1045695,6 21,6.8954305 21,8 L21,15 C21,16.1045695 20.1045695,17 19,17 L16,17 Z M17.5,11 C18.3284271,11 19,10.3284271 19,9.5 C19,8.67157288 18.3284271,8 17.5,8 C16.6715729,8 16,8.67157288 16,9.5 C16,10.3284271 16.6715729,11 17.5,11 Z M10,14 L10,20 L14,20 L14,14 L10,14 Z" fill="#000000"/>\
        <rect fill="#000000" opacity="0.3" x="8" y="2" width="8" height="2" rx="1"/>\
    </g >\
					            </span>\
				            </a>\<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1 edit">\
					                <span class="svg-icon svg-icon-3">\
						                <svg xmlns="http://www.w3.org/2000/svg" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
							                <path d="M12.2674799,18.2323597 L12.0084872,5.45852451 C12.0004303,5.06114792 12.1504154,4.6768183 12.4255037,4.38993949 L15.0030167,1.70195304 L17.5910752,4.40093695 C17.8599071,4.6812911 18.0095067,5.05499603 18.0083938,5.44341307 L17.9718262,18.2062508 C17.9694575,19.0329966 17.2985816,19.701953 16.4718324,19.701953 L13.7671717,19.701953 C12.9505952,19.701953 12.2840328,19.0487684 12.2674799,18.2323597 Z" fill="#000000" fill-rule="nonzero" transform="translate(14.701953, 10.701953) rotate(-135.000000) translate(-14.701953, -10.701953)"></path>\
							                <path d="M12.9,2 C13.4522847,2 13.9,2.44771525 13.9,3 C13.9,3.55228475 13.4522847,4 12.9,4 L6,4 C4.8954305,4 4,4.8954305 4,6 L4,18 C4,19.1045695 4.8954305,20 6,20 L18,20 C19.1045695,20 20,19.1045695 20,18 L20,13 C20,12.4477153 20.4477153,12 21,12 C21.5522847,12 22,12.4477153 22,13 L22,18 C22,20.209139 20.209139,22 18,22 L6,22 C3.790861,22 2,20.209139 2,18 L2,6 C2,3.790861 3.790861,2 6,2 L12.9,2 Z" fill="#000000" fill-rule="nonzero" opacity="0.3"></path>\
						                </svg>\
					                </span>\
				                </a>';
                    }
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm delete">\
					                <span class="svg-icon svg-icon-3">\
						                <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="24px" height="24px" viewBox="0 0 24 24" version="1.1">\
							                <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">\
								                <rect x="0" y="0" width="24" height="24"></rect>\
								                <path d="M6,8 L6,20.5 C6,21.3284271 6.67157288,22 7.5,22 L16.5,22 C17.3284271,22 18,21.3284271 18,20.5 L18,8 L6,8 Z" fill="#000000" fill-rule="nonzero"></path>\
								                <path d="M14,4.5 L14,4 C14,3.44771525 13.5522847,3 13,3 L11,3 C10.4477153,3 10,3.44771525 10,4 L10,4.5 L5.5,4.5 C5.22385763,4.5 5,4.72385763 5,5 L5,5.5 C5,5.77614237 5.22385763,6 5.5,6 L18.5,6 C18.7761424,6 19,5.77614237 19,5.5 L19,5 C19,4.72385763 18.7761424,4.5 18.5,4.5 L14,4.5 Z" fill="#000000" opacity="0.3"></path>\
							                </g>\
						                </svg>\
					                </span>\
				                </a>';
                    }
                    html += '</div>';

                    return html;
                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);

        $('#dtTable tbody').on('click', 'a.print', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                print(selectedDataRow);
            }
        });

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            editingDataRow = selectedDataRow;
            modal_header_text.text("Cập nhật hàng hóa");
            modal_form_submit_text.text("Cập nhật");


            //gán giá trị
            $('input[data-field="FirstName"]').val(selectedDataRow.firstName);
            $('input[data-field="Image"]').val(selectedDataRow.thumbnailImage);
            $('.image-input-wrapper').css('background-image', 'url(' + selectedDataRow.thumbnailImage+')');

            $('input[data-field="Code"]').val(selectedDataRow.code);
            $('input[data-field="Name"]').val(selectedDataRow.name);
            $('textarea[data-field="Description"]').val(selectedDataRow.description);
            $('input[data-field="OriginalPrice"]').autoNumeric('set', selectedDataRow.originalPrice);
            $('input[data-field="Price"]').autoNumeric('set', selectedDataRow.price);
            $('input[data-field="Stock"]').val(selectedDataRow.stock);
            $('input[data-field="InventoryWarning"]').val(selectedDataRow.inventoryWarning);
            $('input[data-field="IsPOS"]').prop('checked', selectedDataRow.isPOS);
            $('input[data-field="IsHasSKU"]').prop('checked', selectedDataRow.isHasSKU);
            $('input[data-field="AllowSellWhenNotEnough"]').prop('checked', selectedDataRow.allowSellWhenNotEnough);

       
            //images 
            resetImages();
            let imageUrls = selectedDataRow.productImages.split(','),
                imageSizes = selectedDataRow.productImageSizes.split(',');


            $.each(imageUrls, function (index, item) {
                if (!App.isNullOrEmpty(item) && item != '') {
                    images.push(item);
                    itemDetail = item.split('products/');
                    var mockFile = { name: itemDetail[1], size: parseFloat(imageSizes[index]), height: "120px", width: "120px"};
                    imgUrl = item.replace('//download', '/download');
                    myDropzone.options.addedfile.call(myDropzone, mockFile);
                    myDropzone.options.thumbnail.call(myDropzone, mockFile, imgUrl);
                    $('#kt_dropzonejs_example_images').find('.dz-progress').hide();
                }
            });


            if (selectedDataRow.isHasSKU && !$('#kt_attribute_method').hasClass('show')) {
                $('#kt_attribute_method').addClass('show');
            } else {
                $('#kt_attribute_method').removeClass('show');
                $('[name="kt_form_edit_attribute"]').val(null).trigger('change');
                removeAllTag();
            }


            let arrayIds = selectedDataRow.productTypeIds.split(','),
                arrayNames = selectedDataRow.productTypeName.split(','),
                htmlProductType = '';

            $('[name="kt_form_edit_productType"]').html(htmlProductType).trigger('change');

            $.each(arrayIds, function (index, item) {
                if (!App.isNullOrEmpty(item)) {
                    htmlProductType += '<option selected value="' + item + '">' + arrayNames[index] + '</option>'
                }
            });

            $('[name="kt_form_edit_productType"]').append(htmlProductType).trigger('change');
            $('[name="kt_form_edit_manufactuer"]').append('<option value="' + selectedDataRow.manufactuerId + '">' + selectedDataRow.manufactuerName + '</option>').trigger('change');


            App.sendDataToURL("/Product/GetSKU_AttributeById", { Id: selectedDataRow.id, Data: null }, "POST")
                .then(function (res) {

                    if (res.isSuccessed && res.resultObj != null && res.resultObj.length > 0) {

                        let arrayAttributeIds = res.resultObj[0].attributeIds.split(','),
                            arrayAttributeNames = res.resultObj[0].attributeNames.split(',');

                        for (let i = 0; i < arrayAttributeIds.length; i++) {
                                var option = new Option(arrayAttributeNames[i], arrayAttributeIds[i], true, true);
                            if (i == 0) {
                                $('[name="kt_form_edit_attribute"]').append(option);
                            } else {
                                $('[name="kt_form_edit_attribute_1"]').append(option);
                            }
                        }

                        var selectedValues = new Array();
                        var selectedValues1 = new Array();
                        var selectedValuesNames = new Array();
                        var selectedValuesNames1 = new Array();

                        $.each(res.resultObj, function (index, item) {
                            var arr = item.attributeValueIds.split(',');
                            var arrName = item.attributeValueName.split(',');
                            console.log(item)

                            for (let i = 0; i < arr.length; i++) {
                                if (i == 0 && !selectedValues.includes(arr[i])) {
                                    selectedValues.push(arr[i]); 
                                }
                                else if (i != 0 && !selectedValues1.includes(arr[i])) selectedValues1.push(arr[i]); 

                                if (i == 0 && !selectedValuesNames.includes(arrName[i])) {
                                    selectedValuesNames.push(arrName[i]);
                                }else if (i != 0 && !selectedValuesNames1.includes(arrName[i])) selectedValuesNames1.push(arrName[i]);


                            }
                            let html = '<tr data-attributes="' + item.attributeIds + '"  data-values="' + item.attributeValueIds + '">\
                                <td>\
                                    <input type="text" class="form-control form-control-solid hidden" hidden name="null-0"  data-field="AttributeValueIds" value="'+ item.attributeValueIds + '">\
                                    <input type="text" class="form-control form-control-solid hidden" hidden name="null-0"  data-field="AttributeIds" value="'+ item.attributeIds + '">\
                                    <input type="text" class="form-control form-control-solid productskuname"  name="null-0"  data-field="ProductSKUName" value="'+ item.name + '">\
                                </td>\
                                <td>\
                                    <input type="text" class="form-control form-control-solid" name="null-0" data-field="ProductSKUCode" value="'+item.code+'">\
                                </td>\
                                <td>\
                                    <input type="text" class="form-control form-control-solid tien-VND" name="null-0" data-field="Price" value="'+ item.price +'">\
                                </td>\
                                <td>\
                                    <input type="text" class="form-control form-control-solid tien-VND" name="null-0" data-field="BuyingPrice" value="'+ item.buyingPrice +'">\
                                </td>\
                                <td>\
                                    <input type="number" class="form-control form-control-solid" name="null-0" data-field="QtyInStock" value="'+ item.qtyInStock +'">\
                                </td>\
                            </tr>';

                            $('#kt_create_new_attribute_fields tbody').append(html);
                            $('.tien-VND').autoNumeric('init', initialTienVNDOption());

                            setTimeout(function () {
                                $('#tag_' + item.id).find("td input").each((index, elTd) => {
                                    if ($(elTd).data("field")) {

                                        switch ($(elTd).data("field")) {

                                     
                                            case "ProductSKUCode":
                                                $(elTd).val(item.code);
                                                break;

                                            case "Price":
                                                $(elTd).autoNumeric('set', item.price.toString());
                                                break;

                                            case "BuyingPrice":
                                                $(elTd).autoNumeric('set', item.buyingPrice.toString());
                                                break;

                                            case "QtyInStock":
                                                $(elTd).val(item.qtyInStock);
                                                break;
                                            default:

                                                break;
                                        }
                                    }
                                });
                            }, 500);
                        });

                        for (let i = 0; i < selectedValues.length; i++) {
                            var option = new Option(selectedValuesNames[i], selectedValues[i], true, true);
                            $('[name="kt_form_edit_attribute_value"]').append(option);
                        }

                        for (let i = 0; i < selectedValuesNames1.length; i++) {
                            var option = new Option(selectedValuesNames1[i], selectedValues1[i], true, true);
                            $('[name="kt_form_edit_attribute_1_value"]').append(option);
                        }

                    }
                }
            )



            modal.modal('show');
            setTimeout(function () { $('input[name="kt_modal_edit_form_name"]').focus() }, 500);
        });
        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });
        $('#dtTable tbody').on('click', 'a.detail', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                openDetail(selectedDataRow.id)
            }
        });
    };

    function print(data) {
        //Get template phiếu thu 
        App.sendDataToURL("/Product/GenerateBarcode?productSkUCode=" + data.code, null, "GET")
            .then(function (res) {
                if (res) {
                    $("#page-print").show();
                    $(".barcode").attr('src', 'data:image/png;base64,' + res);
                    $("#page-print").print();
                    $("#page-print").hide();
                }
            }
        )
    }



    function openDetail(id) {
        $('#kt_view_detail_attribute_fields tbody').html('');

        App.sendDataToURL("/ProductSKU/GetByProductId?productId=" + id, null, "GET")
            .then(function (res) {
                if (res.items.length > 0) {
                    $.each(res.items, function (index, item) {
                        let html = '<tr>\
                            <td>\
                                <input type="text" class="form-control form-control-solid" disabled name="null-0" data-field="ProductSKUName" value="'+ item.name + '">\
                            </td>\
                            <td>\
                                <input type="text" class="form-control form-control-solid" name="null-0" data-field="ProductSKUCode" value="'+ item.code + '">\
                            </td>\
                            <td>\
                                <input type="text" class="form-control form-control-solid tien-VND" name="null-0" data-field="Price" value="'+ item.price + '">\
                            </td>\
                            <td>\
                                <input type="text" class="form-control form-control-solid tien-VND" name="null-0" data-field="BuyingPrice" value="'+ item.buyingPrice + '">\
                            </td>\
                            <td>\
                                <input type="number" class="form-control form-control-solid" name="null-0" data-field="QtyInStock" value="'+ item.qtyInStock + '">\
                            </td>\
                        </tr>';
                        $('#kt_view_detail_attribute_fields tbody').append(html);
                        $('.tien-VND').autoNumeric('init', initialTienVNDOption());

                        setTimeout(function () {
                            $('#tag_' + item.attributeValueId).find("td input").each((index, elTd) => {
                                if ($(elTd).data("field")) {

                                    switch ($(elTd).data("field")) {


                                        case "ProductSKUCode":
                                            $(elTd).val(item.productSKUCode);
                                            break;


                                        case "Price":

                                            $(elTd).autoNumeric('set', item.price.toString());
                                            break;

                                        case "BuyingPrice":
                                            $(elTd).autoNumeric('set', item.buyingPrice.toString());
                                            break;

                                        case "QtyInStock":
                                            $(elTd).val(item.qtyInStock);
                                            break;
                                        default:

                                            break;
                                    }
                                }
                            });
                        }, 500);

                    });
                    $('#kt_modal_view_detail').modal('show');
                }
            }
    )
    }


    let resetForm = () => {
        editingDataRow = null;
        modal_form[0].reset();
        $('#kt_attribute_method').removeClass('show');
        $('.image-input-wrapper').css('background-image', 'url(/images/header-bg.jpg)');
        setTimeout(function () { $('input[name="kt_form_edit_name"]').focus() }, 500);
        $('[name="kt_form_edit_manufactuer"]').val(null).trigger('change');
        $('[name="kt_form_edit_attribute"]').val(null).trigger('change');
        $('[name="kt_form_edit_attribute_value"]').val(null).trigger('change');

        $('[name="kt_form_edit_attribute_1"]').val(null).trigger('change');
        $('[name="kt_form_edit_attribute_1_value"]').val(null).trigger('change');
        $('[name="kt_form_edit_productType"]').val(null).trigger('change.select2');
        $('#kt_create_new_attribute_fields tbody').html('');
        resetImages();
    }

    function resetImages() {
        images = [], files = [];
        $('#kt_dropzonejs_example_images').html('\
            <div class="dz-message needsclick">\
            <i class="bi bi-file-earmark-arrow-up text-primary fs-3x"></i>\
            <div class="ms-4">\
                <h3 class="fs-5 fw-bolder text-gray-900 mb-1">Kéo thả hoặc click vào đây để tải ảnh lên.</h3>\
                <span class="fs-7 fw-bold text-gray-400">Tối đa 10 file</span>\
            </div>\
        </div>');
    }

    function onAddRemoveTag() {
        let productName = $('input[data-field="Name"]').val();
        $('#kt_create_new_attribute_fields tbody').html('');
        var dataAtt = $('[name="kt_form_edit_attribute"]').select2('data');
        var dataAtt1 = $('[name="kt_form_edit_attribute_1"]').select2('data');
        var data = $('[name="kt_form_edit_attribute_value"]').select2('data');
        var data1 = $('[name="kt_form_edit_attribute_1_value"]').select2('data');
        var resultId = [], resultId = [], resultName =[], resultAttId=[];

        if (data.length > 0) {
            for (let i = 0; i < data.length; i++) {
                if (data1.length <= 0) {
                    resultAttId.push(dataAtt[0].id.toString());
                    resultId.push(data[i].id.toString());
                    resultName.push(data[i].text.toString());
                } else {
                    for (let j = 0; j < data1.length; j++) {
                        resultAttId.push(dataAtt[0].id.toString() + ',' + dataAtt1[0].id.toString());
                        resultId.push(data[i].id.toString() + ',' + data1[j].id.toString());
                        resultName.push(data[i].text.toString() + ' ' + data1[j].text.toString());
                    }
                }
            }
        } else if (data1.length > 0 && data.length <= 0) {
            for (let i = 0; i < data1.length; i++) {
                resultAttId.push(dataAtt1[0].id.toString());
                resultId.push(data1[i].id.toString());
                resultName.push(data1[i].text.toString());
            }
        }
       
        for (let i = 0; i < resultId.length; i++) {
            let html = '<tr data-attributes="' + resultAttId[i] + '"  data-values="' + resultId[i] + '">\
                    <td>\
                      <input type="text" class="form-control form-control-solid " hidden name="null-0"  data-field="AttributeValueIds" value="'+ resultId[i]+ '">\
                    <input type="text" class="form-control form-control-solid " hidden name="null-0"  data-field="AttributeIds" value="'+ resultAttId[i] + '">\
                        <input type="text" class="form-control form-control-solid productskuname"  name="null-0"  data-field="ProductSKUName" value="'+ productName + ' ' + resultName[i]+ '">\
                    </td>\
                    <td>\
                        <input type="text" class="form-control form-control-solid" name="null-0" data-field="ProductSKUCode" value="">\
                    </td>\
                    <td>\
                        <input type="text" class="form-control form-control-solid tien-VND" name="null-0" data-field="Price" value="0">\
                    </td>\
                    <td>\
                        <input type="text" class="form-control form-control-solid tien-VND" name="null-0" data-field="BuyingPrice" value="0">\
                    </td>\
                    <td>\
                        <input type="number" class="form-control form-control-solid" name="null-0" data-field="QtyInStock" value="0">\
                    </td>\
                </tr>';

            $('#kt_create_new_attribute_fields tbody').append(html);
            $('.tien-VND').autoNumeric('init', initialTienVNDOption());
        }
    }

    function removeAllTag() {
        $('#kt_create_new_attribute_fields tbody').html('');
        $('[name="kt_form_edit_attribute_value"]').val(null).trigger('change');
        $('[name="kt_form_edit_attribute_1_value"]').val(null).trigger('change');
    }


    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Product/DeleteByIds", dtTable, null)
            .then(function () {
                dtTable.draw();
                App.showHideButtonDelete(false);
            });
    }

    function htmlDecode(input) {
        var doc = new DOMParser().parseFromString(input, "text/html");
        return doc.documentElement.textContent;
    }

    return {
        // public functions
        init: function () {
            initialDatatable();
            initialComponents();

        }
    };
}();