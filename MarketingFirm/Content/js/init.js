(function ($) {
    $(function () {

        $(".button-collapse").sideNav({ edge: 'right'}); 
        $('.parallax').parallax();
        $('select').material_select();
        $(".dropdown-button").dropdown();
        $('.collapsible').collapsible('open');
        $('.slider').slider({ indicators: false});
        $('#JobFunc').val('New Text');
        $('#JobFunc').trigger('autoresize');
        $('.datepicker').pickadate({
            selectMonths: true, // Creates a dropdown to control month
            selectYears: 15, // Creates a dropdown of 15 years to control year,
            today: 'Today',
            clear: 'Clear',
            close: 'Ok',
            closeOnSelect: false, // Close upon selecting a date,
            formatSubmit: 'yyyy-mm-dd'
        });
        $('input#RZip').characterCounter();


    }); // end of document ready
})(jQuery); // end of jQuery name space