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

        function getProjects() {
            var deferred = $q.defer();

            $http.get('/TeamCity/Projects').then(function (result) {
                deferred.resolve(result.data);
            }, function (error) {
                deferred.reject(error);
            });

            return deferred.promise;
        }
    }
})();