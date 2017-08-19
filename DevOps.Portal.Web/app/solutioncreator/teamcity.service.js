(function() {
    "use strict";

    angular.module('app.solutioncreator').factory('teamcityService', teamcityService);

    teamcityService.$inject = ['$http', '$q'];

    function teamcityService($http, $q) {
        return {
            getBuildTemplates: getBuildTemplates,
            getProjects: getProjects
        };

        function getBuildTemplates() {
            var deferred = $q.defer();

            $http.get('/TeamCity/BuildTemplates').then(function (result) {
                deferred.resolve(result.data);
            }, function (error) {
                deferred.reject(error);
            });

            return deferred.promise;
        }

        function getProjects(searchTerm) {
            var deferred = $q.defer();

            var parameters = {
                searchTerm: searchTerm
            };
            var config = {
                params: parameters
            };
            $http.get('/TeamCity/Projects', config).then(function (result) {
                deferred.resolve(result.data);
            }, function (error) {
                deferred.reject(error);
            });

            return deferred.promise;
        }
    }
})();