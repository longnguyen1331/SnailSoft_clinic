//== Class definition

var ExaminationsResult = function () {

    let initialComponents = () => {

        ClassicEditor
            .create(document.querySelector('#editor'))
            .then(editor => {
                console.log(editor);
            })
            .catch(error => {
                console.error(error);
            });
    };


    return {
        // public functions
        init: function () {
            initialComponents();
        }
    };
}();
