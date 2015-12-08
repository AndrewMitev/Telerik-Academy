var usersController = function () {


    function login(context) {
        templates.get('login')
        .then(function (template) {
            context.$element().html(template());

            $('#btn-register').on('click', function () {
                var user = {
                    username: $('#tb-username').val(),
                    password: $('#tb-password').val()
                }
                data.users.register(user)
                .then(data.users.login(user))
                .then(function () {
                    toastr.success('User registred');
                    context.redirect('#/');
                    document.location.reload(true);
                })
            });
            $('#btn-login').on('click', function () {
                var user = {
                    username: $('#tb-username').val(),
                    password: $('#tb-password').val()
                }
                data.users.login(user)
                .then(function () {
                    toastr.success('User logged in');
                    context.redirect('#/');
                    document.location.reload(true);
                })
            });
        });
    }

    return {
        login: login
    }
}();