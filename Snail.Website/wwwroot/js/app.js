var App = function () {

    let sendDataToURL = (url, data, method, isShowLoading, waitingElementOption) => {
        var defered = jQuery.Deferred();

        //if (isShowLoading == true) {
        //    if (!waitingElementOption) {
        //        waitingElementOption = {
        //            selector: 'body'
        //        };
        //    }
        //    showLoader(waitingElementOption.selector, waitingElementOption.option);
        //        

        jQuery.ajax({
            type: method || "POST",
            url: url,
            data: data != null ? JSON.stringify(data) : null,
            dataType: 'JSON',
            contentType: "application/json",
            error: function (res) {
                //if (isShowLoading == true) {
                //    hideLoader(waitingElementOption.selector);
                //}

                defered.reject('Không tìm thấy máy chủ.');
            },
            success: function (res) {
                //if (isShowLoading == true) {
                //    hideLoader(waitingElementOption.selector);
                //}

                defered.resolve(res);
            }
        });

        return defered.promise();
    }

    let sendDataFileToURL = (url, data, method, isShowLoading, waitingElementOption) => {
        var defered = jQuery.Deferred();

        //if (isShowLoading == true) {
        //    if (!waitingElementOption) {
        //        waitingElementOption = {
        //            selector: 'body'
        //        };
        //    }
        //    showLoader(waitingElementOption.selector, waitingElementOption.option);
        //}

        jQuery.ajax({
            url: url,
            type: method || "POST",
            data: data,
            processData: false,
            contentType: false,
            error: function (xhr, status, p3, p4) {
                //if (isShowLoading == true) {
                //    hideLoader(waitingElementOption.selector);
                //}
                //stop_waitMe(waitingElementOption.selector, waitingElementOption.option);

                var err = "Error " + " " + status + " " + p3 + " " + p4;
                if (xhr.responseText && xhr.responseText[0] == "{")
                    err = JSON.parse(xhr.responseText).Message;
                console.log(err);

                defered.reject('Không tìm thấy máy chủ.');

                return false;
            },
            success: function (res) {
                if (isShowLoading == true) {
                    hideLoader(waitingElementOption.selector);
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

    let initSelect2Base = (el, url, options) => {

        el.select2(
            {
                ajax: {
                    url: url,
                    data: function (params) {
                        var query = {
                            textSearch: params.term
                        };

                        if (options && options.query) {
                            for (var key in options.query) {
                                query[key] = options.query[key];
                            }
                        }

                        return query;
                    },
                    processResults: function (res) {

                        var data = jQuery.map(res.items, function (item, i) {

                            return {
                                id: (options && options.selectedFields ? item[options.selectedFields[0]] : item.id),
                                text: (options && options.selectedFields ? item[options.selectedFields[1]] : item.name)
                            }
                        });
                        if (options && options.append0 != null && options.append0 == true) {
                            data.unshift({
                                id: 0,
                                text: "Không chọn"
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

    let scrollTo = (selector, speed) => {
        jQuery('html, body').animate({
            scrollTop: parseInt(jQuery(selector).offset().top)
        }, speed);
    }

    return {
        sendDataToURL: sendDataToURL,
        sendDataFileToURL: sendDataFileToURL,
        isNullOrEmpty: isNullOrEmpty,
        initSelect2Base: initSelect2Base,
        dinhDangTien: dinhDangTien,
        scrollTo: scrollTo
    }
}();