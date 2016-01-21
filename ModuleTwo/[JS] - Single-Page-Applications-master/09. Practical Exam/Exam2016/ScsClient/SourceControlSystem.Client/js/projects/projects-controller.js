(function () {
    'use strict';

    function projectsController(identity, projects, notifier) {
        var vm = this;

        vm.isAuth = identity.isAuthenticated();

        vm.request = {
            page: 1
        };

        vm.prevPage = function () {
            if (vm.request.page == 1) {
                return;
            }

            vm.request.page--;
            vm.filterProjects();
        }

        vm.nextPage = function () {
            if (!vm.projects || vm.projects.length == 0) {
                return;
            }

            vm.request.page++;
            vm.filterProjects();
        }

        vm.filterProjects = function () {
            projects.filterProjects(vm.request)
                .then(function (filteredProjects) {
                    vm.projects = filteredProjects;
                    console.log(vm.request);
                });
        }

        projects.getProjects()
            .then(function (projects) {
                vm.projects = projects;
            }, function (err) {
                notifier.error(err);
            });
    }

    angular.module('myApp.controllers')
        .controller('ProjectsController', ['identity', 'projects', 'notifier', projectsController]);
}());