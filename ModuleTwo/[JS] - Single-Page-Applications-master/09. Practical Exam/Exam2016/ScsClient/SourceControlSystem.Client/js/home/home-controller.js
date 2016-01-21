(function () {
    'use strict';

    function homeController(projects, commits, statistics, notifier) {
        var vm = this;



        projects.getProjects()
            .then(function (response) {
                vm.projects = response;
            }, function (err) {
                notifier.error(err);
            });

        commits.getCommits()
            .then(function (response) {
                vm.commits = response;
            }, function (err) {
                notifier.error(err);
            });

        statistics.getStatistics()
            .then(function (response) {
                vm.stats = response;
            }, function (err) {
                notifier.error(err);
            });
    }

    angular.module('myApp.controllers')
        .controller('HomeController', ['projects', 'commits', 'statistics', 'notifier', homeController]);
}())