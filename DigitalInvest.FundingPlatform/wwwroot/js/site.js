// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function () {

    $('.investBtn').click(function () {

        var url = $(this).data('url');

        $.get(url, function (data) {

            $('#fundingModal').html(data);

            $('#fundingModal').modal('show');

        });
    });

    //clear modal cache so that new content can be loaded
    $('#fundingModal').on('hidden.bs.modal', function () {
        $(this).removeData('bs.modal');
    });

});