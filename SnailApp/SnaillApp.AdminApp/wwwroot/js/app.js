var App = function () {
    let run_waitMe = (selector, option) => {
        if (!selector) {
            selector = 'body';
        }

        $(selector).block({
            message: '<div class="spinner-grow text-primary" role="status"> <span class="visually-hidden">Loading...</span></div>',
            css: {
                border: 'none',
                padding: '15px',
                background: 'none',
            },
            overlayCSS: { backgroundColor: '#FFF' }
        });
    }

    let stop_waitMe = (selector) => {
        if (!selector) {
            selector = 'body';
        }
        $(selector).find('.blockUI')
            .fadeOut(300, function () { $(this).remove(); });
    }

    var body = document.getElementsByTagName("BODY")[0];

    let notification = (position, type, icon, title, message) => {
        if (typeof icon == 'undefined' || icon == '') {
            icon = 'bx bx-x-circle';
        }
        if (typeof position == 'undefined' || position == '') {
            position = 'top right';
        }
        if (typeof type == 'undefined' || type == '') {
            type = 'success';
        }

        var notiOptions = {
            pauseDelayOnHover: true,
            rounded: true,
            size: 'mini',
            icon: icon,
            continueDelayOnInactiveTab: false,
            position: position,
            msg: message,
            title: title
        };

        if (typeof title == 'undefined' || title == '') {
            notiOptions.size = 'mini';
        }

        Lobibox.notify(type, notiOptions);

    }

    let sendDataToURL = (url, data, method, isShowLoading, waitingElementOption) => {
        var defered = $.Deferred();

        if (!isShowLoading || isShowLoading == true) {
            if (!waitingElementOption) {
                waitingElementOption = {
                    selector: 'body'
                };
            }
            run_waitMe(waitingElementOption.selector, waitingElementOption.option);
        }

        $.ajax({
            type: method || "POST",
            url: url,
            data: data != null ? JSON.stringify(data) : null,
            dataType: 'JSON',
            contentType: "application/json",
            error: function (res) {
                if (!isShowLoading || isShowLoading == true) {
                    stop_waitMe(waitingElementOption.selector);
                }
                console.log(res);
                defered.reject('Không tìm thấy máy chủ.');
            },
            success: function (res) {
                if (!isShowLoading || isShowLoading == true) {
                    stop_waitMe(waitingElementOption.selector);
                }

                defered.resolve(res);
            }
        });

        return defered.promise();
    }

    let sendDataFileToURL = (url, data, method, isShowLoading, waitingElementOption) => {
        var defered = $.Deferred();

        if (!isShowLoading || isShowLoading == true) {
            if (!waitingElementOption) {
                waitingElementOption = {
                    selector: 'body'
                };
            }
            run_waitMe(waitingElementOption.selector, waitingElementOption.option);
        }

        $.ajax({
            url: url,
            type: method || "POST",
            data: data,
            processData: false,
            contentType: false,
            error: function (xhr, status, p3, p4) {
                if (!isShowLoading || isShowLoading == true) {
                    stop_waitMe(waitingElementOption.selector);
                }

                var err = "Error " + " " + status + " " + p3 + " " + p4;
                if (xhr.responseText && xhr.responseText[0] == "{")
                    err = JSON.parse(xhr.responseText).Message;
                console.log(err);

                defered.reject('Không tìm thấy máy chủ.');

                return false;
            },
            success: function (res) {
                if (!isShowLoading || isShowLoading == true) {
                    stop_waitMe(waitingElementOption.selector);
                }

                defered.resolve(res);
            }
        });

        return defered.promise();
    }

    let isNullOrEmpty = (value) => {
        return typeof value == 'string' && !value.trim() && value == null ||
            typeof value == 'number' && value == null ||
            typeof value == 'object' && value == null ||
            typeof value == 'undefined' || value === null;
    }

    let deleteDataConfirm = (data, url, table, urlTroVe) => {
        var defered = $.Deferred();
        
        Swal.fire({
            title: 'Are you sure to delete?',
            text: "Data not recover when to delete!",
            icon: "warning",
            customClass: { cancelButton: "btn btn-light", confirmButton: "btn btn-primary" },
            showCancelButton: true,
            confirmButtonText: 'OK',
            cancelButtonText: 'Cancel',
            reverseButtons: true
        }).then(function (result) {
            if (result.value) {
                sendDataToURL(url, data, "DELETE")
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            Swal.fire({
                                title: 'Notification',
                                text: res.message,
                                type: 'warning',
                                confirmButtonText: 'Close!',
                                customClass: { confirmButton: "btn btn-primary" }
                            })
                        }
                        else {
                            Swal.fire({
                                title: 'Notification',
                                text: 'Delete Success.',
                                type: 'success',
                                confirmButtonText: 'Close!',
                                customClass: { confirmButton: "btn btn-primary" }
                            })

                            if (table != null) {
                                table.draw();

                            }
                            if (!isNullOrEmpty(urlTroVe)) {
                                window.location.href = urlTroVe;
                            }
                        }

                        defered.resolve(res);
                    });
            }
        });
        return defered.promise();
    };

    let cancelDataConfirm = (data, url, table, urlTroVe) => {
        var defered = $.Deferred();

        Swal.fire({
            title: 'Are you sure to cancel?',
            icon: "warning",
            customClass: { cancelButton: "btn btn-light", confirmButton: "btn btn-primary" },
            showCancelButton: true,
            confirmButtonText: 'OK',
            cancelButtonText: 'Cancel',
            reverseButtons: true
        }).then(function (result) {
            if (result.value) {
                sendDataToURL(url, data, "DELETE")
                    .then(function (res) {
                        if (!res.isSuccessed) {
                            Swal.fire({
                                title: 'Notification',
                                text: res.message,
                                type: 'warning',
                                confirmButtonText: 'Close!',
                                customClass: { confirmButton: "btn btn-primary" }
                            })
                        }
                        else {
                            Swal.fire({
                                title: 'Notification',
                                text: 'Cancel Success.',
                                type: 'success',
                                confirmButtonText: 'Close!',
                                customClass: { confirmButton: "btn btn-primary" }
                            })

                            if (table != null) {
                                table.draw();

                            }
                            if (!isNullOrEmpty(urlTroVe)) {
                                window.location.href = urlTroVe;
                            }
                        }

                        defered.resolve(res);
                    });
            }
        });
        return defered.promise();
    };


    let scroll = () => {
        if (window.pageYOffset > 40) {
            if (body.hasAttribute('data-kt-sticky') === false) {
                body.setAttribute('data-kt-sticky', 'on');
            }
        } else {
            if (body.hasAttribute('data-kt-sticky') === true) {
                body.removeAttribute('data-kt-sticky');
            }
        }
    }

    let initevencheckbox = () => {
        if (this.checked) {
            showHideButtonDelete(true);
        } else {
            $('#dtTable tbody input[type="checkbox"]:checked').length > 0 ?
                showHideButtonDelete(true) : showHideButtonDelete(false);
        }
    }

    let showHideButtonDelete = (showDelete) => {
        if (showDelete) {
            $('.showSelected').show();
            $('#selected_count').text($('#dtTable tbody input[type="checkbox"]:checked').length);
            $('.showNotSelected').addClass('hideBtnCreate');
        } else {
            $('.showSelected').hide();
            $('.showNotSelected').removeClass('hideBtnCreate');
            $('#checkbox-select-all').prop('checked', false);
        }
    }

    let initSelect2Base = (el, url, options, filters) => {
        el.select2(
            {
                ajax: {
                    url: url,
                    data: function (params) {
                        var query = null;

                        if (filters && filters.parentFilter) {
                            query = {
                                textSearch: params.term,
                                parentId: filters.parentFilter[0]
                            };
                        } else {
                            query = {
                                textSearch: params.term
                            };
                        }

                        if (options && options.query) {
                            for (var key in options.query) {
                                query[key] = options.query[key];
                            }
                        }                       

                        return query;
                    },
                    processResults: function (res) {
                                                
                        var data = $.map(res.items, function (item, i) {
                                                       
                            return {
                                id: (options && options.selectedFields ? item[options.selectedFields[0]] : item.id),
                                text: (options && options.selectedFields ? item[options.selectedFields[1]] : item.name)
                            }
                        });
                        if (options && options.append0 != null && options.append0 == true) {
                            data.unshift({
                                id: 0,
                                text: "Not selected"
                            })
                        }

                        return {
                            results: data
                        };
                    }
                },
                allowClear: true,
            }).trigger('change');
    }

    let readImageURL =(input, element) => {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                element.attr('src', e.target.result);
            }

            reader.readAsDataURL(input.files[0]);
        }
    }

    let dinhDangTien = (n, digits) => {
        if (n) {
            if (parseInt(digits) < 0 || typeof (digits) == 'undefined') {
                digits = 2;
            }

            if (parseFloat(n)) {
                n = parseFloat(parseFloat(n).toFixed(digits));
            }
        }

        let isNavigate = n < 0 ? "-" : "";

        var strTien = Math.abs(n).toString().split('.');
        return isNavigate + parseFloat(strTien[0]).toString().replace(/./g, function (c, i, a) {
            return i > 0 && c !== "." && (a.length - i) % 3 === 0 ? "," + c : c;
        }) + (strTien.length > 1 ? '.' + strTien[1] : '');
    }

    let swalFireSuccessDefaultOption = (message) => {
        return {
            title: message || 'Notification',
            text: 'Update success.',
            type: 'success',
            confirmButtonText: 'Close!',
            customClass: { confirmButton: "btn btn-primary" },
            icon: 'success',
            timer: 3000
        }
    };

    let swalFireErrorDefaultOption = (message) => {
        return {
            text: message || "Error." ,
            icon: "error",
            buttonsStyling: !1,
            confirmButtonText: "Close !",
            customClass: { confirmButton: "btn btn-primary" }
        }
    };


    let lowerFirstLetter = (string) => {
        return string.charAt(0).toLowerCase() + string.slice(1);
    }

    return {
        //run_waitMe: run_waitMe,
        //stop_waitMe: stop_waitMe,
        lowerFirstLetter: lowerFirstLetter,
        notification: notification,
        sendDataToURL: sendDataToURL,
        sendDataFileToURL: sendDataFileToURL,
        deleteDataConfirm: deleteDataConfirm, 
        cancelDataConfirm: cancelDataConfirm,
        scroll: scroll,
        initevencheckbox: initevencheckbox,
        showHideButtonDelete: showHideButtonDelete,
        isNullOrEmpty: isNullOrEmpty,
        initSelect2Base: initSelect2Base,
        readImageURL: readImageURL,
        dinhDangTien: dinhDangTien,
        swalFireErrorDefaultOption: swalFireErrorDefaultOption,
        swalFireSuccessDefaultOption: swalFireSuccessDefaultOption
    }
}();


window.onscroll = function () { App.scroll() };

$(document).keydown(function (event) {
    if (event.which == 113) { //F2
        if ($('button[name="btnCreate"]').length > 0
        ) {
            $('button[name="btnCreate"]').trigger('click');
        }
        return false;
    }
    else if (event.which == 114) { //F3
        if ($('button[name="btnCreateService"]').length > 0
        ) {
            $('button[name="btnCreateService"]').trigger('click');
        }
        return false;
    }
});