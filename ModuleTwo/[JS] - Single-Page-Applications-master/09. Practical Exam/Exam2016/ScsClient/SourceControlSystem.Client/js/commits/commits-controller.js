(function () {
    'use strict';

    function commitsController($routeParams, notifier, commits) {
        var vm = this;

        commits.getCommitById($routeParams.id)
            .then(function (response) {
                vm.commitInfo = response;
            }, function (err) {
                notifier.error(err);
            });

    }

    angular.module('myApp.controllers')
        .controller('CommitsController', ['$routeParams', 'notifier', 'commits', commitsController])
}());