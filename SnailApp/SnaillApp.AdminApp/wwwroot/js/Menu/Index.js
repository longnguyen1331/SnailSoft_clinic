//== Class definition

var Menu = function () {
    let dtTable = null;

    let edit_form = $("#edit_form"),
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
            $('.switcher-btn').trigger('click');
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        edit_form_buttonSubmit.click(function (e) {
            e.preventDefault();
            let result = {};
            console.log(editingDataRow);
            edit_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                let fieldName = $(el).data("field");
                if (fieldName) {
                    switch (fieldName) {
                        case "IsVisibled":
                            result[$(el).data("field")] = $(el).val() === "on" ? true : false;
                            break;

                        default:

                            result[$(el).data("field")] = $(el).val();

                            break;
                    }
                }
            });

            data = {
                Id: (editingDataRow != null ? editingDataRow.id : -1),
                Data: result
            },
                console.log(data),
                App.sendDataToURL("/Menu/Save", data, "POST", true, 'body')
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


        $('#dtTableSearch').keyup(function (e) {
            e.preventDefault();
            dtTable.draw();
        });
    };
    function reset() {
        editingDataRow = null;
        edit_form[0].reset();
        dtTable.draw();
        $('#ParentId').append('<option value="0" selected>Not selected</option>');

    }

    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.ajax.url = "/Menu/DataTableGetList";
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
                "targets": [0, 2, 3],
                "orderable": false
            },
            {
                "targets": [10, 3],
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
            { "data": "parentName", "name": "parentName", "autoWidth": true, "title": "Parent" },
            { "data": "sortOrder", "name": "sortOrder", "autoWidth": true, "title": "Sort" },
            { "data": "code", "name": "code", "autoWidth": true, "title": "Code" },
            { "data": "name", "name": "name", "autoWidth": true, "title": "Name" },
            { "data": "link", "name": "link", "autoWidth": true, "title": "Link" },
            { "data": "controllerName", "name": "controllerName", "autoWidth": true, "title": "Controller" },
            { "data": "actionName", "name": "actionName", "autoWidth": true, "title": "Action" },
            { "data": "icon", "name": "icon", "autoWidth": true, "title": "Icon" },
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

            if (editingDataRow != null) {
                console.log(editingDataRow);
                $('input[data-field="Code"]').val(editingDataRow.code);
                $('input[data-field="Name"]').val(editingDataRow.name);
                $('input[data-field="Icon"]').val(editingDataRow.icon);
                $('input[data-field="Link"]').val(editingDataRow.link);
                $('input[data-field="ControllerName"]').val(editingDataRow.controllerName);
                $('input[data-field="ActionName"]').val(editingDataRow.actionName);
                $('input[data-field="SortOrder"]').val(editingDataRow.sortOrder);
                $('input[data-field="IsVisibled"]').prop('checked', editingDataRow.isVisibled);

                $('#ParentId').append('<option value="' + (editingDataRow.parentId != null ? editingDataRow.parentId : -1) + '" selected>' + (editingDataRow.parentName != null ? editingDataRow.parentName : "Not selected") +'</option>');
                
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
        App.initSelect2Base($('#ParentId'), '/Menu/Filter', { selectedFields: ["id", "name", "code"], append0: true });
    };

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Menu/DeleteByIds", dtTable, null)
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