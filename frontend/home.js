let json = {
    "repos": [
        {
            "link": "https://github.com/nexylmao/jwt-websocket",
            "pic": "src/jws.png",
            "text": "This is a library, that incorporates dotnet-jwt, newtonsoft.json and websocket-sharp, to make a simple to use, websocket client that can automatically verify messages, in form of JWT's, or ones sent as stringified Json's. For communication, a class is used, named 'SocketMessage<>'",
        },
        {
            "link": "https://github.com/nexylmao/NTP4",
            "pic": "src/ntp4.png",
            "text": "GitHub repo za skolu, predmet Napredne Tehnike Programiranja, 4. godina"
        },
        {
            "link": "https://github.com/nexylmao/ed-backend",
            "pic": "src/edb.png",
            "text": "Backend deo projekta iz MiBP 3. godina, nodejs aplikacija koja handle-uje usere/dnevnike/ocene "
        },
        {
            "link": "https://github.com/nexylmao/ed-frontend",
            "pic": "src/edf.png",
            "text": "Frontend deo zadatka za MiBP 3. godina"
        }
    ]
};

function show(index) {
    let content = document.getElementById('content');
    let repo = json.repos[index];
    content.innerHTML = '';
    content.innerHTML += '<a href="' + repo.link + '"><button class="btn btn-dark">Link to the repository</button></a>';
    content.innerHTML += '<p>' + repo.text + '</p>';
    content.innerHTML += '<img class="w-75" src="' + repo.pic + '"/>';
}

$(document).ready(function () {

    let user;

    console.log(json);

    if (window.sessionStorage.getItem('id') === null) {
        window.location.replace('index.html');
    } else {
        user = JSON.parse(window.sessionStorage.getItem('user'));
        $('#username').text(user.username);
    }

    show(0);
    $('#jws').on('click', function () {
        show(0);
    });
    $('#ntp4').on('click', function () {
        show(1);
    });
    $('#edb').on('click', function () {
        show(2);
    });
    $('#edf').on('click', function () {
        show(3);
    });

    $('#logout').on('click', function () {
        window.sessionStorage.clear();
        window.location.replace('index.html');
    });
});