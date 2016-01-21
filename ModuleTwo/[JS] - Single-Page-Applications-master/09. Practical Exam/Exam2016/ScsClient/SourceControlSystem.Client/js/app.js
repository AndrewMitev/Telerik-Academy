(function () {
    'use strict';

    var VIEW_MODEL_NAME = 'vm';

    var routeResolvers = {
        authenticationRequired: {
            authenticate: ['$q', 'identity', function ($q, identity) {
                if (identity.isAuthenticated()) {
                    return true;
                }

                return $q.reject('not authorized');
            }]
        }
    };

    function config($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/partials/home.html',
                controller: 'HomeController',
                controllerAs: VIEW_MODEL_NAME
            })
            .when('/projects', {
                templateUrl: 'views/partials/projects-view.html',
                controller: 'ProjectsController',
                controllerAs: VIEW_MODEL_NAME
            })
            .when('/projects/add', {
                templateUrl: 'views/partials/add-project.html',
                controller: 'AddProjectController',
                controllerAs: VIEW_MODEL_NAME,
                resolve: routeResolvers.authenticationRequired
            })
            .when('/projects/:id/addcommits', {
                templateUrl: 'views/partials/add-commit-to-project.html',
                controller: 'AddCommitToProjectController',
                controllerAs: VIEW_MODEL_NAME,
                resolve: routeResolvers.authenticationRequired
            })
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpController'
            })
            .when('/commits/:id', {
                templateUrl: 'views/partials/commit-info.html',
                controller: 'CommitsController',
                controllerAs: VIEW_MODEL_NAME,
                resolve: routeResolvers.authenticationRequired
            })
            .when('/unauthorized', {
                template: '<div class"jumbotron"><h1 class="text-center">You shall not pass!<br /> (not talking about the exam :D)</h1></div>'
            })
            .otherwise({ redirectTo: '/' });
    }

    var run = function run($rootScope, $location) {

        $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
            if (rejection === 'not authorized') {
                $location.path('/unauthorized');
            }
        });
    };

    angular.module('myApp.services', []);
    angular.module('myApp.directives', []);
    angular.module('myApp.controllers', ['myApp.services']);
    angular.module('myApp', ['ngRoute', 'ngCookies', 'myApp.controllers', 'myApp.directives'])
        .config(['$routeProvider', config])
        .run(['$rootScope', '$location', run])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://spa.bgcoder.com');
}());