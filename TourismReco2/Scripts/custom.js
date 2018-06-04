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

    jQuery(".panel-heading").click(function() {

        jQuery('#accordion .panel-heading').not(this).removeClass('isOpen');
        jQuery(this).toggleClass('isOpen');
        jQuery(this).next(".panel-collapse").addClass('thePanel');
        jQuery('#accordion .panel-collapse').not('.thePanel').slideUp("fast");
        jQuery(".thePanel").slideToggle("fast").removeClass('thePanel');
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