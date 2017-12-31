(function () {
    "use strict";

    angular.module('app.solutioncreator').factory('templateService', templateService);

    templateService.$inject = ['dataService'];

    function templateService(dataService) {
        return {
            getTemplates: getTemplates
        };

        function getTemplates() {

            return dataService.get('/SolutionTemplate/Templates');
        }
    }
})();