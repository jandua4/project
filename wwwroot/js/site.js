// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    // If the button has been clicked, display a span to tell the user the menu is being scanned.
    // Hide the button after clicking to prevent multiple clicks.
    $('.scan-btn').click(function () {
        $(this).hide();
        $('.scan-input').hide();
        $('.upload-label').hide();
        $('.scan-span').show();
    });

    // If the file input has no file, disable the button and show the prompt to submit the file.
    $('.scan-btn').mouseover(function () {
        if ($('.scan-input').val() === '') {
            $('.scan-btn').attr('disabled', 'disabled');
            $('.scan-check').show();
        }
    });

    // When clicking the file input field, re-enable the button.
    // The mouseover check in the other function will disable it again if there is no file provided.
    $('.scan-input').click(function () {
        $('.scan-btn').removeAttr('disabled');
        $('.scan-check').hide();
    });

    // On change of the Allergy Group dropdown, assign the value of the selected option to a hidden input to be detected by the controller
    $('#groupSelect').on('change', function () {
        $('#hiddenGroupSelect').val($(this).find('option:selected').text());
    });
});