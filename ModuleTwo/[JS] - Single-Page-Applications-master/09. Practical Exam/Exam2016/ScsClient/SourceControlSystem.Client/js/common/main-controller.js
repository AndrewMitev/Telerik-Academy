(function () {
    'use strict';

    function mainController($scope, identity) {
        var vm = this;

        vm.isGlobalUserSet = identity.isAuthenticated();
    }

    angular.module('myApp')
        .controller('MainController', ['$scope', 'identity', mainController]);
}());