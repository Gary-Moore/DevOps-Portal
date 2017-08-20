(function () {
    'use strict';

    angular.module('app.solutioncreator').factory('createSolutionService', createSolutionService);

    createSolutionService.$inject = ['dataService'];

    function createSolutionService(dataService) {
        var model = {};
        return {
            create: create,
            model: model
        };

        function create() {

            var data = model;
            return dataService.post('SolutionCreator/Create', data);
        }
    }
})();