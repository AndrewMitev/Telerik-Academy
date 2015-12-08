var data = function () {
    const USERNAME_STORAGE_KEY = 'username-key',
        AUTH_KEY_STORAGE_KEY = 'auth-key-key';

    function register(user) {
        var promise = new Promise(function (resolve, reject) {
            var url = 'api/users';
            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            }
            $.ajax(url, {
                method: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(reqUser),
                success: function (res) {
                    resolve(res);
                }
            });
        });
        return promise;
    }
    function login(user) {
        var promise = new Promise(function (resolve, reject) {
            var url = 'api/auth';
            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            }
            $.ajax(url, {
                method: 'PUT',
                contentType: 'application/json',
                data: JSON.stringify(reqUser),
                success: function (res) {
                    localStorage.setItem(USERNAME_STORAGE_KEY, res.result.username)
                    localStorage.setItem(AUTH_KEY_STORAGE_KEY, res.result.authKey)
                    resolve(res);
                }
            });
        });
        return promise;
    }
    function logout() {
        var promise = new Promise(function (resolve, reject) {
            localStorage.removeItem(USERNAME_STORAGE_KEY);
            localStorage.removeItem(AUTH_KEY_STORAGE_KEY);
            resolve();
        });
        return promise;
    }

    function getCurrentUser() {
        var username = localStorage.getItem(USERNAME_STORAGE_KEY);
        if (!username) {
            return null;
        }
        return {
            username
        }
    }

    function allCookies() {
        var promise = new Promise(function (resolve, reject) {
            $.getJSON('api/cookies', function (cookies) {
                resolve(cookies);
            });
        });

        return promise;
    }

    function addCookies(text, category) {
        var text;
        var category;
        var promise = new Promise(function (resolve, reject) {
            $.ajax({
                url: 'api/cookies',
                method: 'POST',
                headers: {
                    'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
                },
                data: JSON.stringify({ text , category }),
                contentType: 'application/json',
                success: function (res) {
                    resolve(res);
                }
    
            })
        });
        return promise;
    }

    return {
        users: {
            register: register,
            login: login,
            logout: logout,
            current:getCurrentUser
        },
        cookies: {
            all: allCookies,
            add: addCookies
        }
    }
}()