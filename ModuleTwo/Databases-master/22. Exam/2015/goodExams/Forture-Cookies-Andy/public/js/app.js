(function () {
    var sammyApp = Sammy('#content', function () {

        this.get('#/', function () {
            this.redirect('#/home');
        });

        this.get('#/home', cookiesController.all);

        this.get('#/login', usersController.login);

        this.get('#/cookies', cookiesController.all);

        this.get('#/cookies/add', cookiesController.add);

    });

    $(function () {
        sammyApp.run('#/');

        if (data.users.current()) {
            $('#btn-go-to-login').addClass('hidden');
        }
        else {
            $('#btn-logout').addClass('hidden');
        }

        $('#btn-logout').on('click', function () {
            data.users.logout()
            .then(function () {
                location = '#/';
                document.location.reload(true);
            });
        });
    });
}());