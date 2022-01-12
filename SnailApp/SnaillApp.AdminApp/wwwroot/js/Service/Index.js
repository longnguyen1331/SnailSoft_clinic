//== Class definition

var Service = function () {
    let dtTable = null, editingData = null,
        dtTableUser = null,
        serviceId = 0,
        create_user_service_form_buttonSubmit = $('[name="btnCreateUserToService"]'),
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
            $('#CreateInfomation').show();
            $('#CreateServiceToUser').hide();
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
                        $('.switcher-btn').trigger('click');
                    }
                }
            )
        });

        create_user_service_form_buttonSubmit.click(function (e) {
            e.preventDefault();
            if ($('#edit_form_userIds').val() != null && $('#edit_form_userIds').val() != '') {
                let data = {
                    serviceId: serviceId,
                    doctorId: $('#edit_form_userIds').val()
                }
                App.sendDataToURL("/Doctor_Service/Save", data, "POST", true, 'body')
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);
                        }
                        else {
                            App.notification("top right", "success", "fadeIn animated bx bx-check-circle", "", "Updated success.");
                            $('#edit_form_serivceIds').val(null).trigger('change');
                            dtTableUser.draw();
                        }
                    }
                )
            }
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
        serviceId = 0;
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
            { "data": "id", "name": "id", "Width": "20px", "title": "Id" },
            { "data": "sortOrder", "name": "sortOrder", "Width": "20px", "title": "Odx" },
            {
                "data": "name", "name": "name", "Width": "40%", "title": "Infomation",
                "render": function (data, type, full, meta) {

                    return '<div class="d-flex align-items-center nav-link">\
							<img src="' + full.image + '" class="recent-product-img" alt="user avatar">\
							<div class="user-info ps-3">\
								<p class="user-name mb-0">' + full.name + '</p>\
								<p class="designattion mb-0"><i class="fadeIn animated bx bx-map"></i> ' + full.serviceTypeName + '</p>\
							</div>\
						</div>';
                }
            },
           
            { "data": "description", "name": "description", "Width": "30%", "title": "Description" },
            { "data": "charges", "name": "charges", "Width": "10%", "title": "Charge" },
            {
                "data": "isVisibled", "name": "isVisibled", "autoWidth": true, "title": "Active",
                "render": function (data, type, full, meta) {
                    return data == true ? '<div class="d-flex align-items-center text-success"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span>Active</span></div>' : '<div class="d-flex align-items-center text-danger">	<i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span>Disable</span>	</div >';
                }
            },
            {
                width: "120px", "title": "Action", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex order-actions">';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="edit btn btn-outline-primary">\
					                <i class="fadeIn animated bx bxs-edit"></i>\
				                </a>';

                        html += '<a href="#" class="ms-3 assign-user">\
					                <i class="bx bxs-user-plus"></i>\
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
                $('#CreateInfomation').show();
                $('#CreateServiceToUser').hide();
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
        $('#dtTable tbody').on('click', 'a.assign-user', function (e) {
            e.preventDefault();
            editingData = dtTable.row($(this).parents('tr')).data();

            if (editingData != null) {
                serviceId = editingData.id;
                dtTableUser.draw();
                $('#CreateInfomation').hide();
                $('#CreateServiceToUser').show();
                $('.switcher-btn').trigger('click');
            }
        });
        $('#edit_form_userIds').select2(
            {
                ajax: {
                    url: '/Doctor/Filter',
                    data: function (params) {
                        var query = {
                            textSearch: params.term
                        };

                        return query;
                    },
                    processResults: function (res) {

                        var data = $.map(res.items, function (item, i) {
                            return {
                                id: item.id,
                                text: item.firstName + " " + item.lastName
                            }
                        });
                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');
    };

  
    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Service/DeleteByIds", dtTable, null)
            .then(function () {
                dtTable.draw();
                App.showHideButtonDelete(false);
            });
    }


    function deleteDataUsereServices(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Doctor_Service/DeleteByIds", dtTableUser, null)
            .then(function () {
                dtTableUser.draw();
            });
    }

    let initialDatatableService = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/Doctor_Service/DataTableGetUserList";
        datatableOption.buttons = [];
        datatableOption.ajax.data = {
            textSearch: function () {
                return '';
            },
            serviceId: function () {
                return serviceId;
            }
        };
        datatableOption.order = [[0, "desc"]];
        datatableOption.columnDefs = [
            {
                "targets": [0],
                "visible": false,
                "orderable": false
            },
            {
                "targets": [2],
                "className": 'dt-center'
            }
        ];
        datatableOption.columns = [
            { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
            { "data": "doctorFullName", "name": "doctorFullName", "autoWidth": true, "title": "Doctor" },
            {
                width: "120px", "title": "Active", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex order-actions">';
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="ms-3 deleteService">\
					                <i class="bx bxs-trash"></i>\
				                </a>';
                    }
                    html += '</div> ';

                    return html;
                }
            },
        ]
        dtTableUser = $('#dtTableUserService').DataTable(datatableOption);
        $('#dtTableUserService tbody').on('click', 'a.deleteService', function (e) {
            e.preventDefault();
            let sel = dtTableUser.row($(this).parents('tr')).data();
            if (sel) {
                deleteDataUsereServices([sel]);
            }
        });
        dtTableUser.buttons().container().appendTo('#dtTableUserService .col-md-6:eq(0)');
    };



    return {
        // public functions
        init: function () {
            initialDatatable();
            initialDatatableService();
            initialComponents();
        }
    };
}();