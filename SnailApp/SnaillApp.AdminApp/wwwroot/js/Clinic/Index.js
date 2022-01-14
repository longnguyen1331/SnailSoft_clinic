//== Class definition

var Clinic = function () {
    let dtTable = null, dtTableClinic = null ;
    let clinicId = -1;
    let edit_form = $("#edit_form"),
        edit_google_form = $("#edit_google_form"),
        edit_facebook_form = $("#edit_facebook_form"),
        edit_firebase_form = $("#edit_firebase_form"),
        create_user_clinic_form_buttonSubmit = $('[name="btnCreateUserToClinic"]'),
        edit_form_buttonSubmit = $('[name="btnUpdate"]');
    
    let initialComponents = () => {

        $('.color').colpick({
            onSubmit: function (hsb, hex, rgb, el, bySetColor) {
                $(el).css("background-color", '#' + hex)
                $(el).val('#' + hex)
                $(el).colpickHide();
            }
        });
        
 
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
            $('#CreateRoleToUser').hide();
            $('.switcher-btn').trigger('click');
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        edit_form_buttonSubmit.click(function (e) {
            e.preventDefault();

            if (checkDataUpdate()) {
                let formData = new FormData();

                edit_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        switch (fieldName) {
                            case "Logo":
                                let files = $(el).prop('files');
                                if (files.length > 0) {
                                    formData.append("Logo", files[0]);
                                }
                                break;

                            case "Status":
                                formData.append("Status", $(el).is(':checked'));
                                break;
                           
                            default:
                                if ($(el).data("field")) {
                                    formData.append($(el).data("field"), $(el).val());
                                }
                                break;
                        }
                    }
                });

                edit_facebook_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        switch (fieldName) {

                            case "FacebookLogin":
                                formData.append("FacebookLogin", $(el).is(':checked'));
                                break;

                            default:
                                if ($(el).data("field")) {
                                    formData.append($(el).data("field"), $(el).val());
                                }
                                break;
                        }
                    }
                });

                edit_google_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        switch (fieldName) {
                            case "GoogleLogin":
                                formData.append("GoogleLogin", $(el).is(':checked'));
                                break;

                            default:
                                if ($(el).data("field")) {
                                    formData.append($(el).data("field"), $(el).val());
                                }
                                break;
                        }
                    }
                });

                edit_firebase_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        switch (fieldName) {
                          
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
                };
                App.sendDataFileToURL("/Clinic/Save", formData, "POST", true, 'body')
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
            var filename = $(this).val().replace(/.*(\/|\\)/, '');
            $('#image-upload-src').val(filename);
        });

        $('#dtTableSearch').keyup(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        $('#edit_form_appUserIds').select2(
            {
                ajax: {
                    url: '/Staff/Filter',
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

        create_user_clinic_form_buttonSubmit.click(function (e) {
            e.preventDefault();
            if ($('#edit_form_appUserIds').val() != null && $('#edit_form_appUserIds').val() != '') {
                let data =  {
                    UserId: $('#edit_form_appUserIds').val(),
                    ClinicId: clinicId
                }
                App.sendDataToURL("/Clinic/AddUserToClinic", data, "POST", true, 'body')
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);
                        }
                        else {
                            App.notification("top right", "success", "fadeIn animated bx bx-check-circle", "", "Updated success.");
                            $('#edit_form_appUserIds').val(null).trigger('change');
                            dtTableClinic.draw();
                        }
                    }
                )
            }
        });

    };

    function checkDataUpdate() {
        if ($('input[data-field="Code"]').val() == '') {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter Code");
            return false;
        }

        if ($('input[data-field="Code"]').val() == '') {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter name");
            return false;
        }

        if ($('input[data-field="StartDate"]').val() == '') {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter Start date");
            return false;
        }

        if ($('input[data-field="ExpirationDate"]').val() == '') {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter Expiration date");
            return false;
        }

        return true;
    }

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
        datatableOption.ajax.url = "/Clinic/DataTableGetList";
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
                "targets": [0,3,6],
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
                "data": "name", "name": "name", "autoWidth": true, "title": "Name",
                "render": function (data, type, full, meta) {
                    return '<a class="d-flex align-items-center nav-link dropdown-toggle dropdown-toggle-nocaret" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">\
							<img src="' + full.logo + '" class="user-img" alt="user avatar">\
							<div class="user-info ps-3">\
								<p class="user-name mb-0">' + full.name+ '</p>\
							</div>\
						</a>';
                }
            },
            {
                "data": "status", "name": "status", "autoWidth": true, "title": "Active",
                "render": function (data, type, full, meta) {
                    return data == true ? '<span class="badge rounded-pill bg-primary">Active</span>' : '<span class="badge rounded-pill bg-danger">Disable</span>';
                }
            },
            { "data": "phone", "name": "phone", "autoWidth": true, "title": "Phone" },
            { "data": "email", "name": "email", "autoWidth": true, "title": "Email" },
            {
                width: "120px", "title": "Active", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex order-actions">';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="edit">\
					                <i class="bx bxs-edit"></i>\
				                </a>';
                    }
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="ms-3 delete">\
					                <i class="bx bxs-trash"></i>\
				                </a>';
                    }
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="ms-3 role">\
					                <i class="bx bxs-user-check"></i>\
				                </a>';
                    }
                    html += '</div> ';

                    return html;

                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);
        dtTable.buttons().container().appendTo('#buttonExtension .col-md-6:eq(0)');

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            editingData = dtTable.row($(this).parents('tr')).data();

            if (editingData != null) {
                $('#avatarImage').attr('src', editingData.logo);


                edit_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                    let fieldName = $(el).data("field");
                    let type = $(el).attr("type");

                    if (fieldName) {
                        switch (fieldName) {
                            default:
                                if ($(el).is("textarea")) {
                                    $('textarea[data-field="' + fieldName + '"]').text(editingData[App.lowerFirstLetter(fieldName)]);
                                } else if ($(el).is("input")) {
                                    if (type === "checkbox") {
                                        $('input[data-field="' + fieldName + '"]').prop('checked', editingData[App.lowerFirstLetter(fieldName)]);
                                    } else if(type==="date") {
                                        $('input[data-field="' + fieldName + '"]').val(editingData[App.lowerFirstLetter(fieldName)].substring(0, 10));
                                    } else if (type === "file") {
                                        $('#avatarImage').attr('src', editingData[App.lowerFirstLetter(fieldName)]);
                                    }else {
                                        $('input[data-field="' + fieldName + '"]').val(editingData[App.lowerFirstLetter(fieldName)]);
                                    }
                                }
                                break;
                        }
                    }
                });

                $('#CreateInfomation').show();
                $('#CreateRoleToUser').hide();
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

        $('#dtTable tbody').on('click', 'a.role', function (e) {
            e.preventDefault();
            editingData = dtTable.row($(this).parents('tr')).data();

            if (editingData) {
                clinicId = editingData.id;
                dtTableClinic.draw();
                $('#CreateInfomation').hide();
                $('#CreateRoleToUser').show();
                $('.switcher-btn').trigger('click');
            }
        });
    };



    let initialDatatableClinic = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.buttons = [];
        datatableOption.ajax.url = "/Clinic/DataTableUserClinicGetList";
        datatableOption.ajax.data = {
            clinicId: function () {
                return editingData != null ? editingData.id : -1;
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
                "targets": [3],
                "className": 'dt-center'
            }
        ];

        datatableOption.columns = [
            { "data": "id", "name": "id", "autoWidth": true, "title": "Id" },
            {
                "data": "firstName", "name": "firstName", "autoWidth": true, "title": "Full name", "render": function (data, type, full, meta) {
                    return full.firstName + " " + full.lastName;
                }
            },
            { "data": "phoneNumber", "name": "phoneNumber", "autoWidth": true, "title": "Phone" },
            {
                width: "120px", "title": "Active", "render": function (data, type, full, meta) {
                    let html = '<div class="d-flex order-actions">';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="editUser">\
					                <i class="bx bxs-edit"></i>\
				                </a>';
                    }
                    if (user.roles.isAllowDelete == true) {
                        html += '<a href="#" class="ms-3 deleteUser">\
					                <i class="bx bxs-trash"></i>\
				                </a>';
                    }
                    html += '</div> ';

                    return html;

                }
            },
        ]
        dtTableClinic = $('#dtTableUserClinic').DataTable(datatableOption);
        dtTableClinic.buttons().container().appendTo('#dtTableUserClinic .col-md-6:eq(0)');

        $('#dtTableUserClinic tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            var sel = dtTableClinic.row($(this).parents('tr')).data();
        });

        $('#dtTableUserClinic tbody').on('click', 'a.deleteUser', function (e) {
            e.preventDefault();
            let sel = dtTableClinic.row($(this).parents('tr')).data();
            if (sel) {
                deleteDataUsereClinics([sel]);
            }
        });
    };

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Clinic/DeleteByIds", dtTable, null)
            .then(function () {
                dtTable.draw();
            });
    }

    function deleteDataUsereClinics(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Clinic/DeleteUserByIds", dtTableClinic, null)
            .then(function () {
                dtTableClinic.draw();
            });
    }

    return {
        // public functions
        init: function () {
            initialDatatable();
            initialDatatableClinic();
            initialComponents();
        }
    };
}();