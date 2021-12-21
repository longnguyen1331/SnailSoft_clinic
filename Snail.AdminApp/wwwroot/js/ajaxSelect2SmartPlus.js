function geListByDonViIdDataSelect2AjaxOption(url, donViId) {
    return {
        ajax: {
            type: "POST",
            url: url,
            dataType: 'json',
            contentType: "application/json",
            delay: 250,
            data: function (params) {
                return JSON.stringify({
                    term: params.term,
                    donViId: donViId
                });
            },
            processResults: function (res) {
                var data = $.map(res, function (item, i) {
                    return {
                        id: item.Id,
                        text: (item.Ma != null && item.Ma != "" && item.Ma != "null") ? item.Ma + ' - ' + item.Ten : item.Ten
                    }
                });

                return {
                    results: data
                };
            }
        }
    };
}

function getAllListByDonViIdDataSelect2AjaxOption(url, donViId) {
    return {
        ajax: {
            type: "POST",
            url: url,
            dataType: 'json',
            contentType: "application/json",
            delay: 250,
            data: function (params) {
                return JSON.stringify({
                    term: params.term,
                    donViId: donViId
                });
            },
            processResults: function (res) {
                var data = $.map(res, function (item, i) {
                    return {
                        id: item.Id,
                        text: (item.Ma != null && item.Ma != "" && item.Ma != "null") ? item.Ma + ' - ' + item.Ten : item.Ten
                    }
                });

                if (data.length > 0) {
                    data.unshift({
                        id: "",
                        text: "Tất cả"
                    });
                }

                return {
                    results: data
                };
            }
        }
    };
}

function geListDataSelect2AjaxOption(url, id) {
    return {
        ajax: {
            type: "POST",
            url: url,
            dataType: 'json',
            contentType: "application/json",
            delay: 250,
            data: function (params) {
                return JSON.stringify({
                    term: params.term,
                    id: id
                });
            },
            processResults: function (res) {
                var data = $.map(res, function (item, i) {
                    return {
                        id: item.Id,
                        text: (item.Ma != null && item.Ma != "" && item.Ma != "null") ? item.Ma + ' - ' + item.Ten : item.Ten
                    }
                });

                return {
                    results: data
                };
            }
        }
    };
}

function getListThueSelect2AjaxOption(url, id) {
    return {
        ajax: {
            type: "POST",
            url: url,
            dataType: 'json',
            contentType: "application/json",
            delay: 250,
            data: function (params) {
                return JSON.stringify({
                    term: params.term,
                    id: id
                });
            },
            processResults: function (res) {
                var data = $.map(res, function (item, i) {
                    return {
                        id: item.Id,
                        text: item.Thue + " - " + item.LoaiThueSuat
                    }
                });

                return {
                    results: data
                };
            }
        }
    };
}

function getListDataHangHoaByKhoIdAjaxOption(url, khoId) {
    return {
        ajax: {
            type: "POST",
            url: url,
            dataType: 'json',
            contentType: "application/json",
            delay: 250,
            data: function (params) {
                return JSON.stringify({
                    term: params.term,
                    khoId: khoId
                });
            },
            processResults: function (res) {
                var data = $.map(res, function (item, i) {
                    return {
                        id: item.Id,
                        text: (item.Ma != null && item.Ma != "" && item.Ma != "null") ? item.Ma + ' - ' + item.Ten : item.Ten
                    }
                });

                data.unshift({
                    id: "",
                    text: "Tất cả"
                });

                return {
                    results: data
                };
            }
        }
    };
}