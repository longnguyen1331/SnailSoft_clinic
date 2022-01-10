//== Class definition

var Service = function () {
    let dtTable = null;
    let editingData = null;

    let edit_form = $("#snail-edit-form"),
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
                        case "Image":
                            let files = $(el).prop('files');
                            if (files.length > 0) {
                                formData.append("Image", files[0]);
                            }
                            break;

                        case "IsVisibled":
                            formData.append("IsVisibled", $(el).is(':checked'));
                            break;

                        default:
                            if ($(el).data("field")) {
                                formData.append($(el).data("field"), $(el).val());
                            }
                            break;
                    }
                }
            });

            if (editingData != null) {
                formData.set("Id", editingData.id);
            }

            App.sendDataFileToURL("/Service/Save", formData, "POST", true, 'body')
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
        });

        $('#dtTableSearch').keyup(function (e) {
            e.preventDefault();
            dtTable.draw();
        });
    };
    function reset() {
        editingData = null;
        edit_form[0].reset();
        $('#avatarImage').attr('src','/snailsoft/assets/images/avatars/avatar-1.png');
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
        datatableOption.ajax.url = "/Service/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTableSearch').val();
            }
        };
        datatableOption.order = [[2, "desc"]];
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
                "targets": [0, 2,4,5,6],
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
            { "data": "sortOrder", "name": "sortOrder", "autoWidth": true, "title": "Odx" },
            {
                "data": "name", "name": "name", "width": "40%", "title": "Infomaiton",
                "render": function (data, type, full, meta) {

                    return '<div class="d-flex align-items-center nav-link">\
							<img src="' + full.image + '" class="user-img" alt="user avatar">\
							<div class="user-info ps-3">\
								<p class="user-name mb-0">' + full.name + '</p>\
								<p class="designattion mb-0"><i class="fadeIn animated bx bx-map"></i> ' + full.serviceTypeName + '</p>\
							</div>\
						</div>';
                }
            },
            { "data": "charges", "name": "charges", "autoWidth": true, "title": "Charge" },
            {
                "data": "isVisibled", "name": "isVisibled", "autoWidth": true, "title": "Active",
                "render": function (data, type, full, meta) {
                    return data == true ? '<span class="badge rounded-pill bg-primary">Active</span>' : '<span class="badge rounded-pill bg-danger">Disable</span>';
                }
            },
            {
                width: "120px", "title": "Action", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex order-actions">';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="edit btn btn-outline-primary">\
					                <i class="fadeIn animated bx bxs-edit"></i>\
				                </a>';
                    }
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="ms-3 delete btn btn-outline-danger">\
					                <i class="fadeIn animated bx bxs-trash"></i>\
				                </a>';
                    }



                    html += '</div> ';

                    return html;

                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            editingData = dtTable.row($(this).parents('tr')).data();
            if (editingData != null) {
                $('select[data-field="ServiceTypeId"]').append('<option value="' + editingData['serviceTypeId'] + '" selected>' + editingData['serviceTypeName'] + '</option>').trigger('change');
                $('input[data-field="Name"]').val(editingData.name);
                $('input[data-field="SortOrder"]').val(editingData.sortOrder);
                $('input[data-field="Charges"]').val(editingData.charges);
                $('input[data-field="Description"]').val(editingData.description);
                $('input[data-field="IsVisibled"]').prop('checked', editingData.isVisibled);
                $('#avatarImage').attr('src', editingData.image);
                if (!$('.switcher-wrapper').hasClass('.switcher-toggled')) $('.switcher-btn').trigger('click');
            }
        });

        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });

        App.initSelect2Base($('#ServiceType'), '/ServiceType/Filter', { selectedFields: ["id", "name"] });

    };

  
    function deleteDataRows(dataRows) {


        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Service/DeleteByIds", dtTable, null)
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