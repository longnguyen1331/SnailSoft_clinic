//== Class definition

var Province = function () {
    let dtTable = null,editingData = null;
    let edit_form = $("#edit_form");

    let initialComponents = () => {

        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });


        $('[name="btnCreate"],[name="btnCancel"]').click(function (e) {
            e.preventDefault();
            resetForm();
            editingData = null;
            $('.switcher-btn').trigger('click');
        });


        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });

        $('[name="btnUpdate"]').click(function (e) {
            e.preventDefault();
            let result = {};
            if (checkDataUpdate()) {
                edit_form.find("select, textarea, input").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {

                        switch (fieldName) {

                            default:
                                result[$(el).data("field")] = $(el).val();
                        }
                    }
                }),
                    data = {
                        Id: (editingData != null ? editingData.id : "0"),
                        Data: result
                    },
                    console.log(data);
                    App.sendDataToURL("/Province/Save", data, "POST")
                        .then(function (res) {
                            if (!res.isSuccessed) {
                                App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);

                            }
                            else {
                                editingData = null;
                                dtTable.draw();
                                resetForm();
                                App.notification("top right", "success", "fadeIn animated bx bx-check-circle", "", "Updated success.");
                            }
                        }
                    )
            }

          
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


    function checkDataUpdate() {

        if ($('input[data-field="Code"]').val() == '') {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter code");
            return false;
        }

        if ($('input[data-field="Name"]').val() == '') {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter name");
            return false;
        }

        return true;
    }

    let initialDatatable = function () {
        var datatableOption = initialDatatableOption();
        datatableOption.buttons = ['excel', 'pdf', 'print'];
        datatableOption.ajax.url = "/Province/DataTableGetList";
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
                "targets": [0, 4],
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
            {
                width: "120px", "title": "Active", "render": function (data, type, full, meta) {
                    
                    let html = '<div class="d-flex order-actions">';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="#" class="edit ms-3">\
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
        dtTable.buttons().container().appendTo('#buttonExtension .col-md-6:eq(0)');

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            editingData = dtTable.row($(this).parents('tr')).data();
            edit_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                let fieldName = $(el).data("field");
                let type = $(el).attr("type");
                if (fieldName) {
                    switch (fieldName) {
                        default:

                            if ($(el).is("select")) {
                                $(el).val(editingData[App.lowerFirstLetter(fieldName)]).trigger('change');
                            }else
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
        });

     

        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });

    };

    let resetForm = () => {
        edit_form[0].reset();
    }

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Province/DeleteByIds", dtTable, null)
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
