$(document).ready(function () {

    let json = {};
    let users = [];

    $.getJSON('data/users.json')
        .done(function (data) {
            json = data;
            users = data.users;
        })
        .fail(function (err) {
            alert(err.message);
            console.error(err);
            $("#registerButton").prop("disabled", true);
        });

    let saveUsers = function () {
        json.name = 'hello!';
        console.log(json);
        $.ajax({
            type: 'POST',
            url: 'data/users.json',
            data: JSON.stringify(json),
            success: () => {
                console.log('is good!');
            },
            contentType: 'application/json',
            dataType: 'json'
        })
            .fail(err => {
               console.log(err);
            });
    };

    saveUsers();

    $('#backButton').on('click', function () {
        window.location.replace('index.html');
    });

    $('#registerForm').submit(function () {

    });

});