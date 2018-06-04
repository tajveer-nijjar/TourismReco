$(document).ready(function () {

    $("input[name=includeRoute]").change(function () {
        var x = $("#weatherInformation");
        //if ($("#planRouteYes").prop("checked", true)) {
        if (this.value === "yes") {
            x.removeClass('hide_it');
        } else {
            $("#weatherInformation").addClass('hide_it');
        }

    });

    var x = $('#accordion .panel-collapse');

    for (var i = 0; i < x.length; i++) {
        x[i].collapse('toggle');
    }
    
//    $('#accordion .panel-default').on('click', function () {
//        .collapse('toggle');
//    });    

});




$(function () {
    $('#colour-variations ul').styleSwitcher({
        defaultThemeId: 'theme-switch',
        hasPreview: false,
        cookie: {
            expires: 30,
            isManagingLoad: true
        }
    });
    $('.option-toggle').click(function () {
        $('#colour-variations').toggleClass('sleep');


    });
});

//$(document).ready();