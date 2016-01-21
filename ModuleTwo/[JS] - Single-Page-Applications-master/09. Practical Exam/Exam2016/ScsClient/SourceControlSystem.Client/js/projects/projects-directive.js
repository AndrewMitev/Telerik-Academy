(function () {
    'use strict';

    function firstTenProjects() {
        return {
            restrict: 'A',
            templateUrl: 'views/directives/projects-directive-view.html'
        }
    }

    angular.module('myApp.directives')
        .directive('firstTenProjects', [firstTenProjects]);
}());