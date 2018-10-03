$(document).ready(function () {

    if (window.localStorage.getItem('id') === null) {
        window.location.replace('index.html');
    }



    $('#logout').on('click', function () {
        window.localStorage.clear();
        window.location.replace('index.html');
    });
});