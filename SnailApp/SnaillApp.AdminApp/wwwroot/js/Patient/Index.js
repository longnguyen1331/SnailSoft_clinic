//== Class definition

var Patient = function () {
    let dtTable = null, editingData = null,
        edit_form = $("#snail-edit-form"),
        edit_form_buttonSubmit = $('[name="btnUpdate"]');

    let initialComponents = () => {
      
        $('[name="inputSearch"]').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('[name="btnCreate"],[name="btnCancel"]').click(function (e) {
            e.preventDefault();
            reset();
            editingData = null;

            $('.switcher-btn').trigger('click');
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        edit_form_buttonSubmit.click(function (e) {
            e.preventDefault();

            let formData = new FormData();

            if (editingData != null) {
                formData.append("id", (editingData != null ? editingData.id : null));
            }

            edit_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                let fieldName = $(el).data("field");
                if (fieldName) {
                    switch (fieldName) {
                        case "Avatar":
                            let files = $(el).prop('files');
                            if (files.length > 0) {
                                formData.append("Avatar", files[0]);
                            }
                            break;

                        case "IsActive":
                            formData.append("IsActive", $(el).is(':checked'));
                            break;

                        default:
                            if ($(el).data("field")) {
                                formData.append($(el).data("field"), $(el).val());
                            }
                            break;
                    }
                }
            });

            var radios = document.getElementsByName('Gender');
            var sexValue = true;
            for (var i = 0, length = radios.length; i < length; i++) {
                if (radios[i].checked) {
                    sexValue = radios[i].value
                    break;
                }
            }

            formData.append("GenderId", sexValue);
            if (editingData != null) {
                formData.set("Id", editingData.id);
            }

            App.sendDataFileToURL("/Patient/SaveProfileDetail", formData, "POST", true, 'body')
            .then(function (res) {
                    if (!res.isSuccessed) {
                        App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);
                    }
                    else {
                        App.notification("top right", "success", "fadeIn animated bx bx-check-circle", "", "Updated success.");
                        reset();
                        editingData = {
                            id: res.resultObj
                        };
                    }
                }
            )
        });

        $('[name="btnDelete"]').click(function (e) {
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

        $('#btnUpload').click(function (e) {
            e.preventDefault();
            $('#image-upload').trigger('click');
        });

        $('#image-upload').change(function (e) {
            e.preventDefault();
            readURL(this);
            var filename = $(this).val().replace(/.*(\/|\\)/, '');
            $('#image-upload-src').val(filename);
        });

        $('#dtTableSearch').keyup(function (e) {
            e.preventDefault();
            dtTable.draw();
        });
    };
    function reset() {
        editingData = null;
        edit_form[0].reset();
        dtTable.draw();
    }
    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();
            reader.onload = function (e) {
                $('#avatarImage').attr('src', e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }

    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.buttons = ['excel', 'pdf', 'print'];
        datatableOption.ajax.url = "/Patient/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTableSearch').val();
            }
        };
        datatableOption.order = [[1, "desc"]];
        datatableOption.columnDefs = [
            {
                "targets": [1],
                "visible": false
            },
            {
                "targets": [0, 3],
                "orderable": false
            },
            {
                "targets": [0,3,4,5],
                "className": 'dt-center'
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
                "data": "id_Image_FullName_Email", "name": "image_FullName_Email", "autoWidth": true, "title": "Infomaiton",
                "render": function (data, type, full, meta) {

                    return '<a class="d-flex align-items-center nav-link dropdown-toggle dropdown-toggle-nocaret" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">\
							<img src="' + full.avatar + '" class="user-img" alt="user avatar">\
							<div class="user-info ps-3">\
								<p class="user-name mb-0">' + full.firstName + ' ' + full.lastName + '</p>\
								<p class="designattion mb-0">Code : ' + full.code + '</p>\
								<p class="designattion mb-0">Email : ' + full.email + '</p>\
								<p class="designattion mb-0">Address : ' + full.address + '</p>\
							</div>\
						</a>';
                }
            },
            { "data": "phoneNumber", "name": "phoneNumber", "autoWidth": true, "title": "Phone" },
            { "data": "dob", "name": "dob", "autoWidth": true, "title": "Dob" },
            {
                width: "120px", "title": "Hành động", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex order-actions"><a href="#" class="edit btn btn-outline-orange"><i class="fadeIn animated bx bx-history"></i></a>';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="edit ms-2  btn btn-outline-orange">\
					                <i class="bx bxs-edit"></i>\
				                </a>';
                    }
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="ms-2 delete btn btn-outline-orange">\
					                <i class="bx bxs-trash"></i>\
				                </a>';
                    }



                    html += '</div> ';

                    return html;

                }
            },
        ];
        dtTable = $('#dtTable').DataTable(datatableOption);
        dtTable.buttons().container().appendTo('#dtTable_wrapper .col-md-6:eq(0)');

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            editingData = dtTable.row($(this).parents('tr')).data();

            if (editingData != null) {
                if (editingData.genderId != null && editingData.genderId == 1) {
                    $('#Male').prop('checked', true);

                } else {
                    $('#Female').prop('checked', true);
                }
                console.log(editingData);
                edit_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                    let fieldName = $(el).data("field");
                    let type = $(el).attr("type");

                    if (fieldName) {
                        switch (fieldName) {


                            case "GenderId":
                                break;

                            case "ProvinceId":
                                    $(el).append('<option value="' + editingData['provinceId'] + '" selected>' + editingData['provinceName']+'</option>').trigger('change');
                                break;

                            case "BloodId":
                                $(el).append('<option value="' + editingData['bloodId'] + '" selected>' + editingData['bloodName']+'</option>').trigger('change');
                                break;

                            case "DistrictId":
                                $(el).append('<option value="' + editingData['districtId'] + '" selected>' + editingData['districtName']+'</option>').trigger('change');
                                break;

                         
                            default:
                                if ($(el).is("textarea")) {
                                    $('textarea[data-field="' + fieldName + '"]').text(editingData[App.lowerFirstLetter(fieldName)]);
                                } else if ($(el).is("input")) {
                                    if (type === "checkbox") {
                                        $('input[data-field="' + fieldName + '"]').prop('checked', editingData[App.lowerFirstLetter(fieldName)]);
                                    } else if (type === "date") {
                                        $('input[data-field="' + fieldName + '"]').val(editingData[App.lowerFirstLetter(fieldName)].substring(0, 10));
                                    } else if (type === "file") {
                                        $('#avatarImage').attr('src', editingData[App.lowerFirstLetter(fieldName)]);
                                    } else {
                                        $('input[data-field="' + fieldName + '"]').val(editingData[App.lowerFirstLetter(fieldName)]);
                                    }
                                }
                                break;
                        }
                    }
                });
                if (!$('.switcher-wrapper').hasClass('switcher-toggled')) $('.switcher-btn').trigger('click');
            }
        });

        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });



        App.initSelect2Base($('select[data-field="BloodId"]'), '/Blood/Filter', { selectedFields: ["id", "name"] });
        App.initSelect2Base($('select[data-field="ProvinceId"]'), '/Province/Filter', { selectedFields: ["id", "name"] });
        App.initSelect2Base($('select[data-field="DistrictId"]'), '/District/Filter', { selectedFields: ["id", "name"] }, { parentFilter: [0] });

        $('select[data-field="ProvinceId"]').change(function () {
            App.initSelect2Base($('select[data-field="DistrictId"]'), '/District/Filter', { selectedFields: ["id", "name"] }, { parentFilter: [$(this).val()] });
        })

    };

   
    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Patient/DeleteByIds", dtTable, null)
            .then(function () {
                dtTable.draw();
                App.showHideButtonDelete(false);
            });
    }

    return {
        // public functions
        init: function () {
            initialDatatable();
            initialComponents();
        }
    };
}();