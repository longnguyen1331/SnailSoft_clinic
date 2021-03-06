//== Class definition

var Staff = function () {
    let dtTable = null;
    let roles = [];

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
            let roleString = '';
            for (let i = 0; i < roles.length; i++) {

                roleString += (i == roles.length - 1) ? roles[i] : roles[i] + '|';
            }
            formData.set("AppRoleCodes", roleString);
            if (editingDataRow != null) {
                formData.set("Id", editingDataRow.id);
            }

            App.sendDataFileToURL("/Staff/SaveProfileDetail", formData, "POST", true, 'body')
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
        editingDataRow = null;
        edit_form[0].reset();
        roles = [];
        dtTable.draw();
        $('#addRoleChips').html('');
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
        datatableOption.ajax.url = "/Staff/DataTableGetList";
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
                "targets": [0,  3, 4],
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
            { "data": "id", "name": "id", "width": '20px', "title": "Id" },
            {
                "data": "id_Image_FullName_Email", "name": "image_FullName_Email", "width": "70%", "title": "Infomaiton",
                "render": function (data, type, full, meta) {

                    return '<div class="d-flex align-items-center nav-link">\
							<img src="' + full.avatar + '" class="user-img" alt="user avatar">\
							<div class="user-info ps-3">\
								<p class="user-name mb-0">' + full.firstName + ' ' + full.lastName + '</p>\
								<p class="designattion mb-0"><i class="fadeIn animated bx bx-map"></i> ' + full.address + '</p>\
                                <p class="designattion mb-0"><i class="fadeIn animated bx bx-phone"></i> ' + full.phoneNumber + '</p>\
							</div>\
						</div>';
                }
            },
            {
                "data": "phoneNumber", "name": "Contact", "width": '30px', "title": "Contact",
                "render": function (data, type, full, meta) {

                    return '<div class="list-inline d-flex customers-contacts ms-auto"><a class="btn-outline-primary" href="tel:' + full.phoneNumber + '"><i class="fadeIn animated bx bx-phone"></i></a>\
                    &ensp;<a class="btn-outline-primary" href="mailto:' + full.email + '"><i class="fadeIn animated bx bx-envelope"></i></a></div\
                    ';
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
            editingDataRow = dtTable.row($(this).parents('tr')).data();

            if (editingDataRow != null) {
                console.log(editingDataRow);
                $('input[data-field="PhoneNumber"]').val(editingDataRow.phoneNumber);
                $('input[data-field="Email"]').val(editingDataRow.email);
                $('input[data-field="Address"]').val(editingDataRow.address);
                $('input[data-field="LastName"]').val(editingDataRow.lastName);
                $('input[data-field="FirstName"]').val(editingDataRow.firstName);
                $('input[data-field="Dob"]').val(editingDataRow.dob);
                if (editingDataRow.genderId != null && editingDataRow.genderId == 1) {
                    $('#Male').prop('checked', true);

                } else {
                    $('#Female').prop('checked', true);
                }

                $('input[data-field="IsActive"]').prop('checked', editingDataRow.isActive);
                $('input[data-field="Dob"]').val(editingDataRow.dob);
                $('#avatarImage').attr('src', editingDataRow.avatar);
                roles = [];
                $('#addRoleChips').html('');
                $.each(editingDataRow.appRoles, function (index, item) {
                    if (!roles.includes(item.code)) {
                        $('#addRoleChips').append('<div class="chip chip-md bg-info text-white chipRole">' + item.name + ' <span class="closebtn" id="removeRoleSpan_' + item.code + '" data-id=' + item.code + '>×</span></div>');
                        roles.push(item.code);
                        intiEventRemoveRole(item.code);
                    }
                })
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

        App.initSelect2Base($('#edit_form_appRoleIds'), '/AppRole/Filter', { selectedFields: ["code", "name"] });

        $('#edit_form_appRoleIds').change(function () {
            if (!roles.includes($('#edit_form_appRoleIds').val())) {
                $('#addRoleChips').append('<div class="chip chip-md bg-info text-white chipRole">' + $('#edit_form_appRoleIds :selected').text() + ' <span class="closebtn" id="removeRoleSpan_' + $('#edit_form_appRoleIds').val() + '" data-id=' + $('#edit_form_appRoleIds').val() + '>×</span></div>');
                roles.push($('#edit_form_appRoleIds').val());
                intiEventRemoveRole($('#edit_form_appRoleIds').val());
            }
        });
    };

    function intiEventRemoveRole(id) {
        $('#removeRoleSpan_' + id).click(function (e) {
            e.preventDefault();
            roles = roles.filter(function (item) {

                return item.trim() != id
            });
            $(this).parents('.chipRole').remove();
        });
    }

    function deleteDataRows(dataRows) {


        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Staff/DeleteByIds", dtTable, null)
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