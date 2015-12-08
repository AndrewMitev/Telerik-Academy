var userController = function(){

    function isValidUsername(username){
        if(typeof username !== 'string'){
            return false;
        }

        if(username.length < 6 || username.length > 30){
            return false;
        }

        if(!/^[a-zA-Z0-9._]+$/.test(username)){
            return false;
        }

        return true;
    }

    function register(context){
        templates.get('register')
            .then(function(template){
                context.$element().html(template);

                $('#register-button').on('click', function(){
                    var $username = $('#tb-reg-username').val(),
                        $password = $('#tb-reg-pass').val();

                    if(!isValidUsername($username)){
                        toastr.error('Invalid username!');
                        return;
                    }

                    var tempUser = {
                        username: $username,
                        password: $password
                    };

                    data.users.register(tempUser)
                        .then(function(){
                            context.redirect('#/');
                            document.location.reload(true);
                            toastr.success("Successfully registered");
                        });
                });
            });
    }

    return {
        register: register
    };
}();
