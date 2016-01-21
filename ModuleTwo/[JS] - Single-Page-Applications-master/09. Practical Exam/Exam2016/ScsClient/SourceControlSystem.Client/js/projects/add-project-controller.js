(function(){
    'use strict';

    function addProjectController($location, projects, notifier) {
        var vm = this;

        vm.addProject = function (project, formName) {
            if (!formName.$valid) {
                notifier.error('Invalid form!');
            }

            projects.addProject(project)
                .then(function () {
                    notifier.success('Project added!');
                    $location.path('/projects');
                }, function (err) {
                    notifier.error(err);
                })
        };
    }

    angular.module('myApp.controllers')
        .controller('AddProjectController', ['$location', 'projects', 'notifier', addProjectController]);
}());