$(document).ready(function () {

    let users = [];

    $.getJSON('data/users.json')
        .done(function (data) {
            users = data.users;
        })
        .fail(function (err) {
            alert(err.message);
            console.error(err);
            $("#loginButton").prop("disabled", true);
        });

    $('#registerButton').on("click", function () {
        window.location.replace("register.html");
    });

    $('#loginForm').submit(function () {
        let username = $('#usernameInput').val();
        let password = $('#passwordInput').val();
        let index = users.map(x => x.username).indexOf(username);
        if (index === -1) {
            alert('You have entered a non existing username!');
            return false;
        }
        else if (users[index].password !== password) {
            alert('You have entered a wrong password!');
            return false;
        }
        else {
            window.localStorage.setItem("id", users[index].id);
            window.location.replace("home.html");
            return false;
        }
    });

});