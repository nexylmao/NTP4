$(document).ready(function () {

        let users = [];

    $.getJSON('data/users.json')
        .done(function (data) {
            users = data.users;
        })
        .fail(function (err) {
            alert(err.message);
            console.error(err);
            $("#registerButton").prop("disabled", true);
        });

    $('#backButton').on('click', function () {
        window.location.replace('index.html');
    });

    $('#registerForm').submit(function () {
        if ($('#passwordInput').val() !== $('#verifyPasswordInput').val()) {
            alert('You gotta type in the same password!');
            return false;
        }

        alert('to: profesorka, mail: frontend js can\'t write files!');
        window.location.replace('index.html');
    });

});