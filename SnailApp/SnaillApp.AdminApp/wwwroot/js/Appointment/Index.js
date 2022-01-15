//== Class definition

var Appointment = function () {
    let editingData = null, edit_form = $("#edit-form"),
        payment_form = $("#payment_form"),
        listService = [], listDoctor_Service = [], calendar = null;

    let initialComponents = () => {

        $('.vnd').autoNumeric('init', initialTienVNDOption());
        $('#timeCreated').pickatime({
            formatSubmit: 'h:i',
            interval: 5,
            min: [8, 0],
            max: [17, 0],
            hiddenName: true,
            onSet: function (event) {
                if (event.select) {
                    $('#timeCreated').val(this.get('select', 'HH:i'))
                }
            },
            hiddenPrefix: 'prefix__',
            hiddenSuffix: '__suffix'
        });

        $('#smartwizard').smartWizard();
        calendar = initAndRefreshFullCalendar();
        calendar.render();

        $('#FilterStatus').change(function (e) {
            e.preventDefault();
            calendar.refetchEvents();
        });

        $('[name="btnCreate"],[name="btnCancel"]').click(function (e) {
            e.preventDefault();
            resetForm();
            $('#PatientInfomation').hide(); 
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

                            case "Date":
                                result[$(el).data("field")] = $(el).val() +  " " + $('#timeCreated').val();
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

        $('button[name="btnCheckin"]').click(function (e) {
            e.preventDefault();
            App.sendDataToURL("/Appointment/UpdateStatusCheckin", { id: editingData.id }, "POST", true, 'body')
                .then(function (res) {
                    if (!res.isSuccessed) {
                        App.notification("top right", "error", "fadeIn animated bx bx-error", "", res.message);
                    }
                    else {
                        editingData = null;
                        App.notification("top right", "success", "fadeIn animated bx bx-check-circle", "", "Update checkin success.");
                        calendar.refetchEvents();
                        $('.switcher-btn').trigger('click');
                    }
                })
        })

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
                    $('#PatientInfomation').show();
                    let item = res.resultObj;
                    $('#avatarImage').attr('src', item.avatar);
                    $('span[data-name="patientFullName"]').text(item.firstName + " " + item.lastName);
                    $('span[data-name="patientCode"]').text(item.code);
                    $('span[data-name="patientPhoneNumber"]').text(item.phoneNumber);
                    $('span[data-name="patientEmail"]').text(item.email);
                    $('span[data-name="patientAddress"]').text(item.address);
                }
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
                        Description: $(this).find('textarea[data-field="Description"]').val(),
                        Date: $(this).find('input[data-field="Date"]').val() + " " + $(this).find('input[data-field="Time"]').val(),
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

                html += '<tr><td colspan="2">Sub total</td>\
					<td style="width: 20%;">'+ qty +'</td>\
					<td style="width: 20%;">'+ App.dinhDangTien(total) +'</td>\
				    </tr>';

                $('.tableCheckout tbody input[data-field="Total"]').autoNumeric('set', total);
                $('.tableCheckout tbody input[data-field="AmountDue"]').autoNumeric('set', total);
                $('#reviewService').append(html);
            }
        });

        $('#smartwizard').on("leaveStep", function (e, anchorObject, currentStepIndex, nextStepIndex, stepDirection) {
            if (nextStepIndex == 'forward') {

                switch (currentStepIndex) {
                    case 0:
                        if (checkDataUpdate()) return true; else return false;
                        break;

                    case 1:

                        $.each($('.accordion-item'), function (index, item) {
                            listDoctor_Service.push({
                                Description: $(item).find('textarea[data-field="Description"]').val(),
                                Date: $(item).find('input[data-field="Date"]').val() + " " + $(item).find('input[data-field="Time"]').val(),
                                Charges: $(item).find('input[data-field="Charges"]').val(),
                                Quantity: $(item).find('input[data-field="Quantity"]').val(),
                                ServiceId: $(item).data('id'),
                                DoctorId: $(item).find('select[data-field="DoctorId"]').val(),
                            });
                        });

                        if (checkDataServiceUpdate()) return true; else return false;
                        break;

                    default:
                        return false
                        break;
                }
            }
        });

        //payment_form
        payment_form.find('input[data-field="Discount"]').change(function () {
            let discount = parseFloat($(this).val()),
                total = parseFloat(payment_form.find('input[data-field="Total"]').autoNumeric('get')),
                amountDue = 0;
            amountDue = total - (total * (discount / 100));
            payment_form.find('input[data-field="AmountDue"]').autoNumeric('set', amountDue);
        });

        $('button[name="btnCheckout"]').click(function (e) {
            e.preventDefault();
            if (editingData == null) {
                App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Appoiment is not found");
            } else {
                let result = {};
                if (checkDataUpdatePayment()) {
                    payment_form.find("select, textarea, input").each((index, el) => {
                        let fieldName = $(el).data("field");
                        if (fieldName) {
                            switch (fieldName) {
                                case "AmountDue":
                                case "Total":
                                    result[$(el).data("field")] = $(el).autoNumeric('get');
                                    break;
                                default:
                                    result[$(el).data("field")] = $(el).val();
                            }
                        }
                    });
                    result["Id"] = 0;
                    result["AppointmentId"] = editingData.id;
                    App.sendDataToURL("/Appointment/SavePayment", result, "POST")
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
            }
        });
    };

    function createAccordionService(id, name, charge) {

        let date = edit_form.find('input[data-field="Date"]').val();
        let time = $('#timeCreated').val();

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
                                            <input data-field="Date" class="result form-control form-control-sm" type="date" value="'+ date +'">\
                                        </div>\
                                    </div>\
                                </div>\
                                <div class="col-md-6">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-time"></i></span>\
                                            <input  data-field="Time" class="result form-control form-control-sm timepicker timeService_'+id+'" value="'+time+'" type="text">\
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
                                            <textarea data-field="Description" class="form-control form-control-sm"rows="3" placeholder="Enter Note..."></textarea>\
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

    function updateAccordionService(data) {
        let date = data.date.split(" ");
        return '<div class="accordion-item  itemService_' + data.serviceId + '" data-appid="' + data.appointmentId + '" data-id="' + data.serviceId + '" data-name="' + data.serviceName + '" >\
					<h2 class="accordion-header" id="heading'+ data.serviceId + '">\
						<button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapse'+ data.serviceId + '" aria-expanded="false" aria-controls="collapse' + data.serviceId + '"> ' + data.serviceName + '\
						</button>\
					</h2>\
					<div id="collapse'+ data.serviceId + '" class="accordion-collapse collapse" aria-labelledby="heading' + data.serviceId + '" data-bs-parent="#listService" style="">\
						<div class="accordion-body">	\
                            <div class="row">\
                                    <div class="col-sm-12" >\
						            <div class="mb-3 px-1 select2-sm">\
							            <label class="form-label">Doctor(*)</label>\
							                <select data-field="DoctorId" data-control="select2" name="doctor_service_'+ data.serviceId + '" \
							                    class="form-select form-select-solid form-select-md radius-15 single-select">\
                                                <option value="'+ data.doctorId + '">' + data.doctorFullName +'</option>\
                                            </select>\
						            </div>\
					            </div>\
                                <div class="col-md-6">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-calendar-check"></i></span>\
                                            <input data-field="Date" class="result form-control form-control-sm" type="date" value="'+ date[0]+'">\
                                        </div>\
                                    </div>\
                                </div>\
                                <div class="col-md-6">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-time"></i></span>\
                                            <input  data-field="Time" class="result form-control form-control-sm timepicker timeService_'+ data.serviceId + '" type="text" value="' + date[1] +'">\
                                        </div>\
                                    </div>\
                                </div>\
                                    <div class="col-md-6">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-move-vertical"></i></span>\
                                            <input data-field="Charges" class="result form-control form-control-sm" hidden type="number" value="'+ data.charges + '">\
                                            <input data-field="Quantity" class="result form-control form-control-sm" type="number"  min="1"  value="'+ data.quantity + '">\
                                        </div>\
                                    </div>\
                                </div>\
                                <div class="col-md-12">\
                                    <div class="card-body mx-0 px-0 px-0 py-2">\
                                        <div class="input-group">\
                                            <span class="input-group-text form-control-sm"><i class="fadeIn animated bx bx-book"></i></span>\
                                            <textarea type="text" data-field="Description" class="form-control form-control-sm"rows="3">'+ data.description+'</textarea>\
                                        </div>\
                                    </div>\
                                </div>\
                                <div class="col-md-12">\
                                    <div class="mb-3 px-1">\
                                        <button type="button" class="btn btn-danger px-5 radius-15 w-100" name="btnDeleteService" data-id="'+ data.serviceId + '">Delete</button>\
                                    </div>\
                                </div >\
                            </div>\
                        </div>\
					</div>\
				</div>';
    }

    function checkDataUpdate() {
        let check = true;
        edit_form.find("select, input").each((index, el) => {
            let fieldName = $(el).data("field");
            if (fieldName) {
                switch (fieldName) {
                    case "Date":
                        if ($(el).val() == '' || $(el).val() == '-1') {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter " + fieldName);
                            check =  false;
                        }
                        break;

                    case "DoctorId":
                    case "PatientId":
                        if (isNullOrEmpty($(el).val()) || $(el).val() == '-1') {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter " + fieldName);
                            check =  false;
                        }
                        break;

                    default:
                        break;
                }
            }
        });

        return check;
    }

    function checkDataServiceUpdate() {

        if (listDoctor_Service.length == 0) {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Choose Service");
            return false;
        } else if (checkNullListServices()) {
            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Choose Doctor and Date in each service");
            return false;
        }
        return true;
    }

    function checkDataUpdatePayment() {


        payment_form.find("select, input").each((index, el) => {
            let fieldName = $(el).data("field");
            if (fieldName) {
                switch (fieldName) {
                    case "Date":
                        if ($(el).val() == '' || $(el).val() == '-1') {
                            App.notification("top right", "error", "fadeIn animated bx bx-error", "", "Enter " + fieldName);
                            return false;
                        }
                        break;

                    case "PaymentMethod":
                    case "Status":
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
        showHIdeButton(-1);
        editingData = null;
        $('#listService').html('');
        $('textarea').text('');
        edit_form[0].reset();
        $('select[data-field="PatientId"]').val(null).trigger('change');
        $('select[data-field="DoctorId"]').val(null).trigger('change');
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
            displayEventTime: true,
            eventClick: function (eventClickInfo) {
                $('#smartwizard').smartWizard("reset");

                editingData = { id: eventClickInfo.event._def.publicId };
                // get infomation from appoimentId
               
                $('#PatientInfomation').show();
                App.sendDataToURL("/Appointment/GetById?id=" + editingData.id, null, "GET", true, 'body')
                    .then(function (res) {
                        if (!$('.switcher-wrapper').hasClass('switcher-toggled')) $('.switcher-btn').trigger('click');

                        edit_form.find("select, textarea, input:not(:radio)").each((index, el) => {
                            let fieldName = $(el).data("field");
                            let type = $(el).attr("type");

                            if (fieldName) {
                                switch (fieldName) {
                                    case "DoctorId":
                                        $('select[data-field="' + fieldName + '"]').append('<option selected value ="' + res.resultObj[App.lowerFirstLetter(fieldName)] + '">' + res.resultObj["doctorFullName"]+ '</option>');
                                        break;

                                    case "Status":
                                        $('select[data-field="' + fieldName + '"]').val(res.resultObj[App.lowerFirstLetter(fieldName)]);
                                        showHIdeButton(res.resultObj[App.lowerFirstLetter(fieldName)]);
                                        break;

                                    case "PatientId":
                                        $('select[data-field="' + fieldName + '"]').append('<option selected value ="' + res.resultObj[App.lowerFirstLetter(fieldName)] + '">' + res.resultObj["patientFullName"]+ '</option>');
                                        break;

                                    case "Date":
                                        let date = res.resultObj[App.lowerFirstLetter(fieldName)].split(' ');
                                        $(el).val(date[0]);
                                        $('#timeCreated').val(date[1]);
                                        break;

                                    default:
                                        if ($(el).is("textarea")) {
                                            $(el).text(res.resultObj[App.lowerFirstLetter(fieldName)]);
                                        } else if ($(el).is("input")) {
                                            if (type === "checkbox") {
                                                $(el).prop('checked', res.resultObj[App.lowerFirstLetter(fieldName)]);
                                            } else if (type === "date") {
                                                $(el).val(res.resultObj[App.lowerFirstLetter(fieldName)].substring(0, 10));
                                            }  else {
                                                $(el).val(res.resultObj[App.lowerFirstLetter(fieldName)]);
                                            }
                                        }
                                        break;
                                }
                            }
                        });
                        $('#avatarImage').attr('src', res.resultObj["patientAvatar"]);
                        $('span[data-name="patientFullName"]').text(res.resultObj["patientFullName"]);
                        $('span[data-name="patientCode"]').text(res.resultObj["patientCode"]);
                        $('span[data-name="patientPhoneNumber"]').text(res.resultObj["patientPhone"]);
                        $('span[data-name="patientEmail"]').text(res.resultObj["patientEmail"]);
                        $('span[data-name="patientAddress"]').text(res.resultObj["patientAddress"]);

                        $('#listService').html('');

                        $.each(res.resultObj.appointment_Services, function (index, item) {

                            listService.push({ id: item.serviceId });
                            $('#listService').append(updateAccordionService(item));
                            initAllEvent(item.serviceId);
                        });

                        payment_form.find('input[data-field="Discount"]').val(res.resultObj.appointmentPayment.discount);
                        payment_form.find('input[data-field="AmountDue"]').val(res.resultObj.appointmentPayment.amountDue);
                        payment_form.find('select[data-field="PaymentMethod"]').val(res.resultObj.appointmentPayment.paymentMethod).trigger('change');
                        payment_form.find('select[data-field="Status"]').val(res.resultObj.appointmentPayment.status).trigger('change');
                        payment_form.find('input[data-field="Date"]').val(res.resultObj.appointmentPayment.date);
                        payment_form.find('textarea[data-field="Description"]').text(res.resultObj.appointmentPayment.description);


                    }
                );
            },
            events: function (fetchInfo, successCallback, failureCallback) {
                var data = {
                    fDate: fetchInfo.startStr != null ? fetchInfo.startStr.substring(0, 10) : "",
                    tDate: fetchInfo.endStr != null ? fetchInfo.endStr.substring(0, 10) : ""
                }

                App.sendDataToURL("/Appointment/DataTableGetList?Status=" + $('#FilterStatus').val() + "&fDate=" + data.fDate + "&tDate=" + data.tDate, null, "GET", true, 'body')
                    .then(function (res) {
                        var events = [];
                        $.each(res.data, function (index, item) {

                            events.push({
                                id: item.id,
                                time: item.date,
                                status: item.status,
                                title: item.name,
                                start: item.date
                            });
                        });

                        if (events != null && events != undefined) successCallback(events);
                    })
            },
            eventContent: function (arg) {
                let italicEl = document.createElement('div')
                let status = arg.event._def.extendedProps.status;
                let date = arg.event._def.extendedProps.time.substring(11,16);
                switch (status) {
                    case 0:
                        italicEl.innerHTML = '<div class="d-flex align-items-center border-left border-4 bg-cancel text-cancel"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0 text-cancel"> ' + date + " " + arg.event._def.title + '</span>	</div>';
                        break;
                    case 1:
                        italicEl.innerHTML = '<div class="d-flex align-items-center border-left border-4  bg-booking text-booking"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0 text-booking"> ' + date + " " + arg.event._def.title + '</span>	</div>';
                        break;
                    case 2:
                        italicEl.innerHTML = '<div class="d-flex align-items-center border-left border-4  bg-confirm text-confirm "><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0 text-confirm "> ' + date + " " + arg.event._def.title + '</span>	</div>';
                        break;
                    case 3:
                        italicEl.innerHTML = '<div class="d-flex align-items-center border-left border-4  bg-checkin text-checkin"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0 text-checkin"> ' + date + " " + arg.event._def.title + '</span>	</div>';
                        break;
                    case 4:
                        italicEl.innerHTML = '<div class="d-flex align-items-center border-left border-4  bg-examination text-examination"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0 text-examination"> ' + date + " " + arg.event._def.title + '</span>	</div>';
                        break;
                    case 5:
                        italicEl.innerHTML = '<div class="d-flex align-items-center border-left border-4  bg-checkout text-checkout"><i class="bx bx-radio-circle-marked bx-burst bx-rotate-90 align-middle font-18 me-1"></i><span class="mb-0 text-checkou"> ' + date + " " + arg.event._def.title + '</span>	</div>';
                        break;
                }
                

                let arrayOfDomNodes = [italicEl]
                return { domNodes: arrayOfDomNodes }
            }

        });
        return calendar;
    }

    let showHIdeButton = (status) => {
        if (status == parseInt(checkinStaus)) {
            $('.tableCheckout').show();
            $('button[name="btnCheckout"]').show();
            $('button[name="btnCheckin"]').hide();
            $('button[name="btnUpdate"]').hide();
        } else if (status == parseInt(checkoutStaus)) {
            $('.tableCheckout').hide();
            $('button[name="btnCheckout"]').hide();
            $('button[name="btnCheckin"]').hide();
            $('button[name="btnUpdate"]').hide();
        } else if (status == parseInt(bookingStaus)){
            $('.tableCheckout').hide();
            $('button[name="btnCheckout"]').hide();
            $('button[name="btnCheckin"]').show();
            $('button[name="btnUpdate"]').hide();
        } else  {
            $('.tableCheckout').hide();
            $('button[name="btnCheckout"]').hide();
            $('button[name="btnCheckin"]').hide();
            $('button[name="btnUpdate"]').show();
        }


        if (editingData == null) {
            $('button[name="btnCheckin"]').prop('disabled', true);
        } else $('button[name="btnCheckin"]').prop('disabled', false);
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

        $('.timeService_' + id).pickatime({
            formatSubmit: 'h:i',
            interval: 5,
            min: [8, 0],
            max: [17, 0],
            hiddenName: true,
            onSet: function (event) {
                if (event.select) {
                    $('.timeService_' + id).val(this.get('select', 'HH:i'))
                }
            },
            hiddenPrefix: 'prefix__',
            hiddenSuffix: '__suffix'
        });
    }

    function checkExistServices(id) {
                            
        return listService.some(function (el) {
            return el.id == id;
        });
    }

    function checkNullListServices() {
        return listDoctor_Service.some(function (el) {
            console.log(el);
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
