(function(){
    var SammyApp = Sammy('#content', function(){
        this.get('#/', function(){
            this.redirect('#/home');
        });

        this.get('#/home', cookieController.allCookies);

        //this.get('#/home?category=' + cookieController.wantedurl, cookieController.category(cookieController.wantedurl));

        this.get('#/users/register', userController.register);

        this.get('#/share', cookieController.share);

    });

    $(function(){
        $(function() {
            SammyApp.run('#/home');

            if (data.users.hasUser()) {
                $('#container-sign-in').addClass('hidden');
                $('.special').css('display', 'block');
                $('#btn-sign-out').on('click', function() {
                    data.users.signOut()
                        .then(function() {
                            document.location = '#/';
                            document.location.reload(true);
                        });
                });
            } else {
                $('#container-sign-out').addClass('hidden');
                $('.special').css('display', 'none');
                $('#btn-sign-in').on('click', function() {
                    var user = {
                        username: $('#tb-username').val(),
                        password: $('#tb-password').val()
                    };
                    data.users.signIn(user)
                        .then(function(user) {
                            document.location = '#/';
                            document.location.reload(true);
                        }, function(err) {
                            console.log(err);
                        });
                });
            }
        });
    });
}());