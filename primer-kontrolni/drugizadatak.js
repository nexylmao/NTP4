window.onload = function () {
    let naslov = document.getElementById('naslov');
    naslov.onmouseover = function () {
        naslov.style.color = 'yellow';
    };

    let form = document.getElementById('kogaZanimaOvo');
    form.onsubmit = function () {
        let povrce = document.getElementById('povrce').value;
        let voce = document.getElementById('voce').value;
        let tecnost = document.getElementById('tecnost').value;
        let godina = document.getElementById('godina').value;
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
    };
}