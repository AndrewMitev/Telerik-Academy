var userController = function(){

    function register(context){
        templates.get('register')
            .then(function(template){
                context.$element().html(template);

                $('#register-button').on('click', function(){
                    var tempUser = {
                        username: $('#tb-reg-username').val(),
                        password: $('#tb-reg-pass').val()
                    };

                    data.users.register(tempUser)
                        .then(function(){
                            toastr.success("Successfully registered");
                            context.redirect('#/');
                            document.location.reload(true);
                        });
                });
            });
    }

    return {
        register: register
    };
}();
