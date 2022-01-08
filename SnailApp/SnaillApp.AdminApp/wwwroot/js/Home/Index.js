//== Class definition

var Home = function () {
    
    let initialComponents = () => {
        refreshData();
        $('#fromToDate').change(function (e) {
            e.preventDefault();
            refreshData();
        });

    };


    let refreshData = function () {
        //call ajax get thuộc tính

        let fDate = '', tDate = '';
        if (!App.isNullOrEmpty($('#fromToDate').val())) {
            fDate =  $('#fromToDate').val().split('-')[0].trim();
        }

        if (!App.isNullOrEmpty($('#fromToDate').val())) {
            tDate=  $('#fromToDate').val().split('-')[1] !== undefined ? $('#fromToDate').val().split('-')[1].trim() : '';
        }
    };



    return {
        // public functions
        init: function () {
            
            initialComponents();
        }
    };
}();


