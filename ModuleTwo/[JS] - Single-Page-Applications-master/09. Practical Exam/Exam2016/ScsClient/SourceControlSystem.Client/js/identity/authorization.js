(function () {
    'use strict';

    function authorization(identity) {
        return {
            getAuthorizationHeader: function () {
                if (identity.getCurrentUser()) {
                    return {
                        'Authorization': 'Bearer ' + identity.getCurrentUser()['access_token']
                    }
                }
            }
        }
    }

    angular.module('myApp.services')
        .factory('authorization', ['identity', authorization]);
}());