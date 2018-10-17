$(document).ready(function () {
    $('#kogaZanimaOvo').submit(function () {
        let povrce = $('#povrce').val();
        let voce = $('#voce').val();
        let tecnost = $('#tecnost').val();
        let godina = $('#godina').val();
        if (povrce === '') {
            alert('Mora neko povrce, inace ces se raspasti od avitaminoze');
        } else if (voce === '') {
            alert('Mora neko voce, inace ces ostati u jovinoj do kraja zivota');
        } else if (tecnost === '') {
            alert('Ako ne pijes nista, onda ces postati frontend programer. Njima ne treba nista, jer ne rade nista.');
        } else if (godina <= 0) {
            alert('Voleo bih i ja da nemam godine, ali ne da profesorka');
        } else {
            window.location.replace('https://www.jjzmaj.edu.rs');
        }
        return false;
    });
});