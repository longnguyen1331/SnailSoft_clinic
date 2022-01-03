//== Class definition

var AppRole = function () {
    let dtTable = null;
    let modal = $("#modal_edit"),
        modal_form = $("#modal_edit_form"),
        modal_form_buttonSubmit = $('#modal_edit_submit'),
        modal_header_text = $("#modal_edit_header_text");
    let editingDataRow = null;

    let modal_role_assign = $("#modal_edit_role_assign"),
        modal_role_assign_form = $("#modal_edit_role_assign_form"),
        modal_role_assign_form_buttonSubmit = $('#modal_edit_role_assign_submit'),
        modal_role_assign_header_text = $("#modal_edit_role_assign_header_text"),
        modal_role_assign_form_submit_text = $("#modal_edit_role_assign_submit_text");

    let loadMenuAppRoleData = (appRoleId) => {
        App.sendDataToURL("/MenuAppRole/GetByAppRoleId?appRoleId=" + appRoleId, null, "GET")
            .then(function (res) {
                
                if (!res.isSuccessed) {
                    Swal.fire(App.swalFireErrorDefaultOption(res.message))
                }
                else {
                    for (let i = 0; i < res.resultObj.length; i++) {
                        let item = res.resultObj[i];
                        $("input[data-menuid='" + item.menuId + "'][data-menuapproletype='" + item.menuAppRoleType + "']").prop("checked", item.isAllow);
                    }                    
                }
            });
    };

    let initialComponents = () => {

        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('[name="btnCreate"]').click(function (e) {
            e.preventDefault();
            editingDataRow = null;
            modal_header_text.text("Create");
            resetForm();
            modal.modal("show");
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        $('#modal_edit_submit').click(function (e) {
            e.preventDefault();
            let result = {};
            modal_form.find("select, textarea, input").each((index, el) => {
                let fieldName = $(el).data("field");

                if (fieldName) {

                    switch (fieldName) {

                        default:
                            result[$(el).data("field")] = $(el).val();
                    }
                }
            }),
            data = {
                Id: (editingDataRow != null ? editingDataRow.id : ""),
                Data: result
            },
            App.sendDataToURL("/AppRole/Save", data, "POST")
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
                    }
                }
            )
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

        $("input[name='modal_edit_role_assign_checkbox']").change(function(){
          
            let data = {
                MenuId: $(this).data("menuid"),
                MenuAppRoleType: $(this).data("menuapproletype"),
                AppRoleId: editingDataRow.id,
                IsAllow: $(this).is(":checked")
            };

            App.sendDataToURL("/MenuAppRole/Save", data, "POST")
            .then(function (res) {
                if (!res.isSuccessed) {
                    Swal.fire(App.swalFireErrorDefaultOption(res.message))
                }
            });
        });
    };

    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/AppRole/DataTableGetList";
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
                "targets": [0, 5],
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
            { "data": "code", "name": "code", "autoWidth": true, "title": "Code" },
            { "data": "name", "name": "name", "autoWidth": true, "title": "Name" },
            { "data": "description", "name": "description", "autoWidth": true, "title": "Description" },
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
                    html += '</div> ';

                    return html;
                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            editingDataRow = dtTable.row($(this).parents('tr')).data();
             
            modal_header_text.text("Update");

            $('input[data-field="Code"]').val(editingDataRow.code);
            $('input[data-field="Name"]').val(editingDataRow.name);
            $('input[data-field="Description"]').val(editingDataRow.description);
            
            setTimeout(function () { $('input[name="modal_edit_form_code"]').focus() }, 500);

            modal.modal('show');
        });

        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });

        $('#dtTable tbody').on('click', 'a.role-assign', function (e) {
            e.preventDefault();

            resetForm_role_assign();

            editingDataRow = dtTable.row($(this).parents('tr')).data();
            
            if (editingDataRow) {
                loadMenuAppRoleData(editingDataRow.id);
            }
            

            modal_role_assign.modal('show');
            
        });
    };

    let resetForm = () => {
        modal_form[0].reset();
        setTimeout(function () { $('input[name="modal_edit_form_code"]').focus() }, 500);
    }

    let resetForm_role_assign = () => {
        modal_role_assign_form[0].reset();

        $("input[name='modal_edit_role_assign_checkbox']").prop("checked", false);
    }

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/AppRole/DeleteByIds", dtTable, null)
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
