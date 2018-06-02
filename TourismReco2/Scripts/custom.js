$(document).ready(function () {

    $(".row #rateYo").rateYo({
        starWidth: "40px"
    });

    
    $("input[name=includeRoute]").change(function () {
        var x = $("#weatherInformation");
        //if ($("#planRouteYes").prop("checked", true)) {
        if (this.value === "yes") {
            x.removeClass('hide_it');
        } else {
            $("#weatherInformation").addClass('hide_it');
        }

    });
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