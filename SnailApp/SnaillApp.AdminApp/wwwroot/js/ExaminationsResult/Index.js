//== Class definition

var ExaminationsResult = function () {
    let dtTable = null,editingData = null;

    let initialComponents = () => {
        $('#inputFromDate').val(new Date().toISOString().slice(0, 8) + '01');
        $('#inputToDate').val(new Date().toISOString().slice(0, 10));



        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('#btnRefreshData').click(function (e) {
            e.preventDefault();
            dtTable.draw();
        });


        $('#FilterStatus, #inputFromDate, #inputToDate').change(function (e) {
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
        datatableOption.buttons = ['excel', 'pdf', 'print'];
        datatableOption.ajax.url = "/ExaminationsResult/DataTableGetList";
        datatableOption.ajax.data = {
            textSearch: function () {
                return $('#dtTableSearch').val();
            },
            fDate: function () {
                return $('#inputFromDate').val();
            },
            tDate: function () {
                return $('#inputToDate').val();
            },
            status: function () {
                return $('#FilterStatus').val();
            },
            doctorId: function () {
                return '';
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
                "targets": [0, 4,5, 6],
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
            { "data": "doctorFullName", "name": "doctorFullName", "autoWidth": true, "title": "Doctor Name" },
            { "data": "patientFullName", "name": "patientFullName", "autoWidth": true, "title": "Patient Name" },
            { "data": "date", "name": "date", "autoWidth": true, "title": "Date" },
            {
                "data": "status", "name": "status", "autoWidth": true, "title": "Status", "render": function (data, type, full, meta) {
                    let html = '';
                    switch (data) {
                        case 0:
                            html = '<div class="d-flex align-items-center border-left border-4  text-cancel"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0l"> Cancel </span></div>';
                            break;
                        case 1:
                            html = '<div class="d-flex align-items-center border-left border-4 text-booking"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0"> Booking</span></div>';
                            break;
                        case 2:
                            html = '<div class="d-flex align-items-center border-left border-4  text-confirm"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0">Approve</span></div>';
                            break;
                        case 3:
                            html = '<div class="d-flex align-items-center border-left border-4  text-checkin"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0"> Checkin</span></div>';
                            break;
                        case 4:
                            html = '<div class="d-flex align-items-center border-left border-4  text-examination"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0"> Examined</span></div>';
                            break;
                        case 5:
                            html = '<div class="d-flex align-items-center border-left border-4   text-checkout"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0"> Checkout</span></div>';
                            break;
                    }

                    return html;
                }
            },
            {
                width: "120px", "title": "Active", "render": function (data, type, full, meta) {
                    
                    let html = '<div class="d-flex order-actions"><a href="#" class="edit btn btn-outline-orange"><i class="fadeIn animated bx bx-mail-send"></i></a>';
                    if (user.roles.isAllowEdit == true) {
                        html += '<a href="/ExaminationsResult/Update?appointmentId=' + full.id +'"  class="edit btn btn-outline-orange ms-2">\
					                <i class="fadeIn animated bx bx-first-aid"></i>\
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
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);
        dtTable.buttons().container().appendTo('#buttonExtension .col-md-6:eq(0)');

        //$('#dtTable tbody').on('click', 'a.edit', function (e) {
        //    e.preventDefault();
        //    editingData = dtTable.row($(this).parents('tr')).data();
        //});

     

        $('#dtTable tbody').on('click', 'a.delete', function (e) {
            e.preventDefault();
            let selectedDataRow = dtTable.row($(this).parents('tr')).data();
            if (selectedDataRow) {
                deleteDataRows([selectedDataRow]);
            }
        });

    };

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/ExaminationsResult/DeleteByIds", dtTable, null)
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
