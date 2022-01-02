//== Class definition

var Staff = function () {
    let dtTable = null;
    let roles = [];
    let initialComponents = () => {

        $('#date-picker').bootstrapMaterialDatePicker({
            format: 'DD/MM/YYYY',
            time: false
        });

        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();
            $('.switcher-btn').trigger('click')
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
                "targets": [3,4,5],
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
                    let tempArr = data.split("|");

                    return '<a class="d-flex align-items-center nav-link dropdown-toggle dropdown-toggle-nocaret" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">\
							<img src="' + tempArr[1] + '" class="user-img" alt="user avatar">\
							<div class="user-info ps-3">\
								<p class="user-name mb-0">' + tempArr[2] + '</p>\
								<p class="designattion mb-0">' + tempArr[3] + '</p>\
							</div>\
						</a>';
                }
            },
            { "data": "phoneNumber", "name": "phoneNumber", "autoWidth": true, "title": "Phone" },
            { "data": "email", "name": "email", "autoWidth": true, "title": "Email" },
            {
                width: "120px", "title": "Hành động", "render": function (data, type, full, meta) {
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
                    html += '</div> ';

                    return html;

                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow != null) {
                //window.location.href = "/Staff/SecurityEdit?id=" + selectedDataRow.id;
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
                $('#addRoleChips').append('<div class="chip chip-md bg-info text-white chipRole">' + $('#edit_form_appRoleIds :selected').text() + ' <span class="closebtn" id="removeRoleSpan_' +  $('#edit_form_appRoleIds').val() + '" data-id=' + $('#edit_form_appRoleIds').val() + '>×</span></div>');
                roles.push($('#edit_form_appRoleIds').val());
                intiEventRemoveRole($('#edit_form_appRoleIds').val());
            }
        });
    };

    function intiEventRemoveRole(id) {
        $('#removeRoleSpan_' +id).click(function (e) {
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