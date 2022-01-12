//== Class definition

var Appointment = function () {
    let dtTable = null,editingData = null;
    let edit_form = $("#edit_form");

    let initialComponents = () => {

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
            dayMaxEvents: true, // allow "more" link when too many events
            editable: true,
            selectable: true,
            timeZone : 'UTC',
            businessHours: true,
            eventClick: function (eventClickInfo ) {
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
                        console.log(item.date)

                    });

                    if (events != null && events != undefined) successCallback(events);
                })
            }
        });
        calendar.render();


        $('#dtTableSearch').on('keyup', function (e) {
            e.preventDefault();
            if (e.keyCode == 13) {
                dtTable.draw();
            }
        });

        $('[name="btnCreate"],[name="btnCancel"]').click(function (e) {
            e.preventDefault();
            resetForm();
            editingData = null
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
                    App.sendDataToURL("/Appointment/Save", data, "POST")
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

 
    let resetForm = () => {
        edit_form[0].reset();
    }

    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Appointment/DeleteByIds", dtTable, null)
        .then(function () {
            dtTable.draw();
            App.showHideButtonDelete(false);
        });
    }


    function deleteDataRows(dataRows) {
        App.deleteDataConfirm({ ids: dataRows.map((item) => item.id) }, "/Appointment/DeleteByIds", dtTable, null)
            .then(function () {
                dtTable.draw();
                App.showHideButtonDelete(false);
            });
    }

    return {
        // public functions
        init: function () {
            initialComponents();
        }
    };
}();
