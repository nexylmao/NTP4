$(document).ready(function () {
    
    $('#toggler').on('click', function () {
        $('h1').toggleClass('beamed');
        $('h2').toggleClass('beamed');
        $('h3').toggleClass('beamed');
    });

    $('#egocentricniNaslov').on('click', function () {
        $('h2').css('color','darkcyan');
        $('h3').css('color','darkcyan');
    });

    let list = $('#youKnowYouCanGoogleThese');

    $('#dodaj').on('click', function () {
        list.append('<li> Hallå. Skratta ursäkta xD. </li>');
    });

    $('#obrisi').on('click', function () {
        list.empty();
    });

});