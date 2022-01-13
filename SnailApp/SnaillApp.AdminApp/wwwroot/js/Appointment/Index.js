//== Class definition

var Appointment = function () {
    let  editingData = null, edit_form = $("#edit-form"), listService = [], listDoctor_Service = [], calendar =null;

    let initialComponents = () => {

        $('#smartwizard').smartWizard();

        calendar = initAndRefreshFullCalendar();
        calendar.render();
        //console.log(new Date().toISOString().slice(0, 10));

        $('[name="btnCreate"],[name="btnCancel"]').click(function (e) {
            e.preventDefault();
            resetForm();
            editingData = null
            $('#smartwizard').smartWizard("reset");
            $('.switcher-btn').trigger('click');
        });

        $('button[name="btnUpdate"]').click(function (e) {
            e.preventDefault();
            let result = {};
            if (checkDataUpdate()) {
                edit_form.find("select, textarea, input").each((index, el) => {
                    let fieldName = $(el).data("field");
                    if (fieldName) {
                        switch (fieldName) {
                            case "PatientId":
                                result["Name"] = $('select[data-field="PatientId"] :selected').text();
                                result[$(el).data("field")] = $(el).val();
                                break;
                            default:
                                result[$(el).data("field")] = $(el).val();
                        }
                    }
                });

                result["Id"] = editingData != null ? editingData.id :0;
                result["Appointment_ServiceRequests"] = listDoctor_Service;
                App.sendDataToURL("/Appointment/Save", result, "POST")
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);
                        }
                        else {
                            App.notification("top right", "success", "fadeIn animated bx bx-check-circle", "", "Updated success.");
                            calendar.refetchEvents();
                            $('.switcher-btn').trigger('click');
                        }
                    }
                )
            }

          
        });

        $('select[data-field="PatientId"]').select2(
            {
                ajax: {
                    url: '/Patient/Filter',
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

        $('select[data-field="PatientId"]').change(function (e) {
            e.preventDefault();

            App.sendDataToURL("/Patient/GetById?userId=" + $(this).val(), null, "GET", true, 'body')
                .then(function (res) {
                    if (res.isSuccessed) {
                        let item = res.resultObj;
                        $('#avatarImage').attr('src', item.avatar);
                        $('span[data-name="patientFullName"]').text(item.firstName + " " + item.lastName);
                        $('span[data-name="patientCode"]').text(item.code);
                        $('span[data-name="patientPhoneNumber"]').text(item.phoneNumber);
                        $('span[data-name="patientEmail"]').text(item.email);
                        $('span[data-name="patientAddress"]').text(item.address);
                    }
                    console.log(res);
                })

        });

        $('select[data-field="DoctorId"]').select2(
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

        $('#service-form-service').select2(
            {
                ajax: {
                    url: '/Service/Filter',
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
                                text: item.name,
                                charges: item.charges
                            }
                        });
                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');

        $('#service-form-service').change(function (e) {
            e.preventDefault();
            if (!checkExistServices($(this).val())) {
                App.sendDataToURL("/Service/GetById?id=" + $(this).val(), null, "GET", true, 'body')
                .then(function (res) {
                    listService.push({ id: res.resultObj.id });
                    $('#listService').append(createAccordionService(res.resultObj.id, res.resultObj.name, res.resultObj.charges));
                    initAllEvent(res.resultObj.id);
                })
            }
        });

        $("#smartwizard").on("stepContent", function (e, anchorObject, stepIndex, stepDirection) {
            if (anchorObject.prevObject.length - 1 == stepIndex) {
                let total = 0, qty = 0, html = '';
                listDoctor_Service = [];
                $('#reviewService').html('');

                $.each($('.accordion-item'), function (index, item) {
                    listDoctor_Service.push({
                        Description: $(this).find('textarea[data-field="Description"]').text(),
                        Date: $(this).find('input[data-field="Date"]').val(),
                        Charges: $(this).find('input[data-field="Charges"]').val(),
                        Quantity: $(this).find('input[data-field="Quantity"]').val(),
                        ServiceId: $(this).data('id'),
                        DoctorId: $(this).find('select[data-field="DoctorId"]').val(),
                    }); 

                    qty += parseFloat($(this).find('input[data-field="Quantity"]').val());
                    total += ($(this).find('input[data-field="Charges"]').val() * $(this).find('input[data-field="Quantity"]').val());
                    html += '<tr><td  style="width: 40%; white-space: normal;">' + $(this).data('name') + '</td>\
					<td style="width: 20%;">'+ App.dinhDangTien($(this).find('input[data-field="Charges"]').val())+'</td>\
					<td style="width: 20%;">'+ $(this).find('input[data-field="Quantity"]').val()+'</td>\
					<td style="width: 20%;">'+ App.dinhDangTien(($(this).find('input[data-field="Charges"]').val() * $(this).find('input[data-field="Quantity"]').val()))+'</td>\
				    </tr>';
                });

                html += '<tr><td colspan="2">Total</td>\
					<td style="width: 20%;">'+ qty +'</td>\
					<td style="width: 20%;">'+ App.dinhDangTien(total) +'</td>\
				    </tr>';

                $('#reviewService').append(html);
            }
        });
    };

    function createAccordionService(id, name, charge) {
        return '<div class="accordion-item itemService_' + id + '" data-id="' + id +'" data-name="'+name+'" >\
					<h2 class="accordion-header" id="heading'+ id+'">\
						<button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapse'+ id + '" aria-expanded="false" aria-controls="collapse' + id +'"> '+name+'\
						</button>\
					</h2>\
					<div id="collapse'+ id +'" class="accordion-collapse collapse" aria-labelledby="heading'+ id +'" data-bs-parent="#listService" style="">\
						<div class="accordion-body">	\
                            <div class="row">\
                                    <div class="col-sm-12" >\
						            <div class="mb-3 px-1 select2-sm">\
							            <label class="form-label">Doctor(*)</label>\
							                <select data-field="DoctorId" data-control="select2" name="doctor_service_'+ id+'" \
							                class="form-select form-select-solid form-select-md radius-15 single-select">\
                                            </select>\
						            </div>\
					            </div>\
                                <div class="col-md-6">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-calendar-check"></i></span>\
                                            <input data-field="Date" class="result form-control form-control-sm" type="date"  placeholder="Enter date">\
                                        </div>\
                                    </div>\
                                </div>\
                                    <div class="col-md-6">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-move-vertical"></i></span>\
                                            <input data-field="Charges" class="result form-control form-control-sm" hidden type="number" value="'+ charge+'">\
                                            <input data-field="Quantity" class="result form-control form-control-sm" type="number"  min="1"  value="1">\
                                        </div>\
                                    </div>\
                                </div>\
                                <div class="col-md-12">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-book"></i></span>\
                                            <textarea type="text" data-field="Description" class="form-control form-control-sm"rows="3" placeholder="Enter Note..."></textarea>\
                                        </div>\
                                    </div>\
                                </div>\
                                <div class="col-md-12">\
                                    <div class="mb-3 px-1">\
                                        <button type="button" class="btn btn-danger px-5 radius-15 w-100" name="btnDeleteService" data-id="'+id+'">Delete</button>\
                                    </div>\
                                </div >\
                            </div>\
                        </div>\
					</div>\
				</div>';
    }

    function checkDataUpdate() {

        if (listDoctor_Service.length == 0) {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Choose Service");
            return false;
        } else if (checkNullListServices()) {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Choose Doctor and Date in each service");
            return false;
        }

        edit_form.find("select, input").each((index, el) => {
            let fieldName = $(el).data("field");
            if (fieldName) {
                switch (fieldName) {
                    case "Date":
                        if ($(el).val() == '' || $(el).val() == '-1') {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter " + fieldName);
                            return false;
                        }
                        break;

                    case "DoctorId":
                    case "PatientId":
                        if (isNullOrEmpty($(el).val()) || $(el).val() == '-1') {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter " + fieldName);
                            return false;
                        }
                        break;


                    default:
                        break;
                }
            }
        });

        return true;
    }
 
    let resetForm = () => {
        edit_form[0].reset();
        listService = [];
        $('#smartwizard').smartWizard("reset");
        listDoctor_Service = [];
    }

    let initAndRefreshFullCalendar = () => {
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            headerToolbar: {
                left: 'prev,next today',
                center: 'title',
                right: 'dayGridMonth,timeGridWeek,timeGridDay,listWeek'
            },
            initialView: 'dayGridMonth',
            initialDate: new Date(),
            navLinks: true, // can click day/week names to navigate views
            selectable: true,
            nowIndicator: true,
            dayMaxEvents: true, 
            editable: true,
            selectable: true,
            timeZone: 'UTC',
            businessHours: true,
            displayEventTime: false,
            eventClick: function (eventClickInfo) {
                console.log(eventClickInfo.event._def.publicId);
            },
            events: function (fetchInfo, successCallback, failureCallback) {
                var data = {
                    fDate: fetchInfo.startStr != null ? fetchInfo.startStr.substring(0, 10) : "",
                    tDate: fetchInfo.endStr != null ? fetchInfo.endStr.substring(0, 10) : ""
                }

                App.sendDataToURL("/Appointment/DataTableGetList?fDate=" + data.fDate + "&tDate=" + data.tDate, null, "GET", true, 'body')
                    .then(function (res) {
                        var events = [];
                        $.each(res.data, function (index, item) {

                            events.push({
                                id: item.id,
                                title: item.name,
                                start: item.date
                            });
                        });

                        if (events != null && events != undefined) successCallback(events);
                    })
            }
        });
        return calendar;

    }

    function initAllEvent(id) {
        $('button[name="btnDeleteService"]').click(function (e) {
            $('.itemService_' + id).remove();
            listService = listService.filter(item => item.id !== id);
        });
        $('.itemService_' + id).find('select').select2(
            {
                ajax: {
                    url: '/Doctor_Service/FilterDoctorByService',
                    data: function (params) {
                        var query = {
                            textSearch: params.term
                        };

                        return query;
                    },
                    processResults: function (res) {

                        var data = $.map(res.items, function (item, i) {
                            return {
                                id: item.doctorId,
                                text: item.doctorFullName
                            }
                        });
                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');
    }

    function checkExistServices(id) {
        return listService.some(function (el) {
            return el.id === id;
        });
    }

    function checkNullListServices() {
        return listDoctor_Service.some(function (el) {
            return el.DoctorId === null || el.Date =='';
        });
    }

    return {
        // public functions
        init: function () {
            initialComponents();
        }
    };
}();
