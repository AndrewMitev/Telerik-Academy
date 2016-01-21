(function(){
    'use strict';

    function commits(data) {
        function getCommits() {
            return data.get('/api/commits');
        }

        function getCommitById(id) {
            return data.get('/api/commits/' + id);
        }

        function updateCommit(obj) {
            return data.post('api/commits', obj);
        }

        return {
            getCommits: getCommits,
            getCommitById: getCommitById,
            updateCommit: updateCommit
        };
    }

    angular.module('myApp.services')
        .factory('commits', ['data', commits]);
}());