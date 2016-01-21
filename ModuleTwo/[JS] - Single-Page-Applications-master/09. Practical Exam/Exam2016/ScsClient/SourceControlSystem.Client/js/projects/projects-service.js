(function(){
    'use strict';

    function projects(data) {

        function getProjects() {
            return data.get('/api/projects');
        }

        function filterProjects(filters) {
            var queryString = '';

            if (filters.hasOwnProperty('page')) {
                queryString += '&page=' + filters.page;
            }

            if (filters.hasOwnProperty('pageSize')) {
                queryString += '&pageSize=' + filters.pageSize;
            }

            if (filters.hasOwnProperty('filter')) {
                queryString += '&filter=' + filters.filter;
            }

            if (filters.hasOwnProperty('orderBy')) {
                queryString += '&orderby=' + filters.orderBy;
            }

            if (filters.hasOwnProperty('orderType')) {
                queryString += '&ordertype=' + filters.orderType;
            }

            if (filters.hasOwnProperty('byUser')) {
                queryString += '&byuser=' + filters.byUser;
            }

            if (filters.hasOwnProperty('onlyPublic')) {
                queryString += '&onlypublic=' + filters.onlyPublic;
            }

            queryString = queryString.substr(1);
            return data.get('/api/projects/all?' + queryString);
        }

        function addProject(project) {
            return data.post('/api/projects', project);
        }

        return {
            getProjects: getProjects,
            filterProjects: filterProjects,
            addProject: addProject
        };
    }

    angular.module('myApp.services')
        .factory('projects', ['data', projects]);
}());