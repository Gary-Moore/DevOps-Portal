(function() {
    "use strict";

    angular.module('app.solutioncreator').factory('teamcityService', teamcityService);

    teamcityService.$inject = ['dataService'];

    function teamcityService(dataService) {
        return {
            getBuildTemplates: getBuildTemplates,
            getProjects: getProjects
        };

        function getBuildTemplates() {

            return dataService.get('/TeamCity/BuildTemplates');
        }

        function getProjects(searchTerm) {

            var parameters = {
                searchTerm: searchTerm
            };

            return dataService.get('/TeamCity/Projects', parameters);
        }
    }
})();