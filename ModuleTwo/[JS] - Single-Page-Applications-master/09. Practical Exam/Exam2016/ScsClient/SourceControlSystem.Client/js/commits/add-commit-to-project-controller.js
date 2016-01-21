(function(){
    'use strict';

    function addCommitToProject($routeParams, $location, commits, notifier){
        var vm = this;

        vm.updateCommit = function(commit) {
            commit.projectId = $routeParams.id;
            commits.updateCommit(commit).then(function () {
                notifier.success('Commit Updated!');
                $location.path('/');
            });
        };
    }

    angular.module('myApp.controllers')
        .controller('AddCommitToProjectController', ['$routeParams','$location', 'commits', 'notifier', addCommitToProject]);
}());