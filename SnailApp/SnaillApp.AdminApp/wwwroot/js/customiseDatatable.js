
function initialDatatableOption(){
    return {
        "dom": "B<'row'<'col-sm-12 infopage'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7 pageandlength'pl>>",
        "processing": true,
        "serverSide": true,
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "pageLength": 10,
        'aLengthMenu': [[5, 10, 25, 50, 100, -1], [5, 10, 25, 50, 100, 'All']],
        'pagingType': 'numbers',
        "ajax": {
            "url": '',
            "type": "POST",
            "datatype":"json"
        },
        'order': [[1, "asc"]],
        //"scrollY": "50vh",
        "scrollX": "true",
        //"scrollCollapse": true,
        stateSave: false,
        'columnDefs':[],
        "columns": [],
        "language": {
            "decimal": ",",
            "thousands": ".",
            "lengthMenu": "Show _MENU_",
            "zeroRecords": "Not data",
            "info": "Trang _PAGE_ / _PAGES_",
            "infoEmpty": "Not data",
            "infoFiltered": "(Found _MAX_ lines)",
            "oAria": {
                "sSortAscending": "Click to sort ascending",
                "sSortDescending": "Click to sort descending"
            },
            "sProcessing": "Processing...",
            "sLoadingRecords": "Loading...",
            "oPaginate": {
                "sFirst": "First",
                "sLast": "End",
                "sNext": "Next",
                "sPrevious": "Previous"
            },
            "sEmptyTable": "Not found",
            "sInfo": "Show lines _START_ to _END_ out of _TOTAL_",
            "sSearch": "Search:"
        },
        "layout": {
            "theme": 'default', // datatable theme
            "class": 'nowrap', // custom wrapper class
            "scroll": false, // enable/disable datatable scroll both horizontal and vertical when needed.
			"height": '450', // datatable's body's fixed height
            "footer": true // display/hide footer
			},
    };
}
