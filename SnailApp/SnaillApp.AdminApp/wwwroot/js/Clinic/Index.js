//== Class definition

var Clinic = function () {
    let dtTable = null;

    let edit_form = $("#edit_form"),
        edit_form_buttonSubmit = $('[name="btnUpdate"]');

    let initialComponents = () => {

        $('.color').colpick({
            onSubmit: function (hsb, hex, rgb, el, bySetColor) {
                $(el).css("background-color", '#' + hex)
                $(el).val('#' + hex)
                $(el).colpickHide();
            }
        });

        $('.date').bootstrapMaterialDatePicker({
            format: 'DD/MM/YYYY',
            time: false
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
                                formData.append("Status", $(el).val() === "on" ? true : false);
                                break;

                            case "FacebookLogin":
                                formData.append("FacebookLogin", $(el).val() === "on" ? true : false);
                                break;

                            case "GoogleLogin":
                                formData.append("GoogleLogin", $(el).val() === "on" ? true : false);
                                break;

                            default:
                                if ($(el).data("field")) {
                                    formData.append($(el).data("field"), $(el).val());
                                }
                                break;
                        }
                    }
                });

                if (editingDataRow != null) {
                    formData.set("Id", editingDataRow.id);
                }
                console.log(formData)
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
    };

    function checkDataUpdate() {

        if (App.isNullOrEmpty($('input[data-field="StartDate"]').val())) {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter Start date");
            return false;
        }

        if (App.isNullOrEmpty($('input[data-field="ExpirationDate"]').val())) {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter Expiration date");
            return false;
        }

        return true;
    }


    function reset() {
        editingDataRow = null;
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
                "targets": [3,6],
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
            { "data": "name", "name": "name", "autoWidth": true, "title": "Name" },
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
                    html += '</div> ';

                    return html;

                }
            },
        ]
        dtTable = $('#dtTable').DataTable(datatableOption);

        $('#dtTable tbody').on('click', 'a.edit', function (e) {
            e.preventDefault();
            editingDataRow = dtTable.row($(this).parents('tr')).data();
            console.log(editingDataRow);

            if (editingDataRow != null) {
                $('#avatarImage').attr('src', editingDataRow.logo);
                $('input[data-field="Status"]').prop('checked', editingDataRow.status);
                $('input[data-field="PrimaryColor"]').val(editingDataRow.primaryColor);
                $('input[data-field="SecondaryColor"]').val(editingDataRow.secondaryColor);
                $('input[data-field="Introduction"]').val(editingDataRow.introduction);
                $('input[data-field="Address"]').val(editingDataRow.address);
                $('input[data-field="Email"]').val(editingDataRow.email);
                $('input[data-field="Phone"]').val(editingDataRow.phone);
                $('input[data-field="GoogleScript"]').val(editingDataRow.googleScript);
                $('input[data-field="FacebookPixel"]').val(editingDataRow.facebookPixel);
                $('input[data-field="FacebookChat"]').val(editingDataRow.facebookChat);
                $('input[data-field="Firebase_apiKey"]').val(editingDataRow.firebase_apiKey);
                $('input[data-field="Firebase_authDomain"]').val(editingDataRow.firebase_authDomain);
                $('input[data-field="Firebase_projectId"]').val(editingDataRow.firebase_projectId);
                $('input[data-field="Firebase_storageBucket"]').val(editingDataRow.firebase_storageBucket);
                $('input[data-field="Firebase_messagingSenderId"]').val(editingDataRow.firebase_messagingSenderId);
                $('input[data-field="Firebase_appId"]').val(editingDataRow.firebase_appId);
                $('input[data-field="Firebase_measurementId"]').val(editingDataRow.firebase_measurementId);
                $('input[data-field="ClinicDomain"]').val(editingDataRow.clinicDomain);
                $('input[data-field="FacebookAppname"]').val(editingDataRow.facebookAppname);
                $('input[data-field="FacebookAppid"]').val(editingDataRow.facebookAppid);
                $('input[data-field="FacebookAppsecret"]').val(editingDataRow.facebookAppsecret);
                $('input[data-field="FacebookLogin"]').prop('checked', editingDataRow.facebookLogin);
                $('input[data-field="GoogleLogin"]').prop('checked', editingDataRow.googleLogin);
                $('input[data-field="GoogleAppname"]').val(editingDataRow.googleAppname);
                $('input[data-field="GoogleApikey"]').val(editingDataRow.googleApikey);
                $('input[data-field="GoogleClientid"]').val(editingDataRow.googleClientid);
                $('input[data-field="GoogleClientsecret"]').val(editingDataRow.googleClientsecret);
                $('input[data-field="StartDate"]').val(editingDataRow.startDate);
                $('input[data-field="ExpirationDate"]').val(editingDataRow.expirationDate);
                
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
    };

    
    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Clinic/DeleteByIds", dtTable, null)
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