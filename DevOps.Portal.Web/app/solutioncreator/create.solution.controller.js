(function() {
    'use strict';

    angular.module('app.solutioncreator').controller('CreateSolutionController', CreateSolutionController);

    CreateSolutionController.$inject = ['createSolutionService'];

    function CreateSolutionController(createSolutionService) {
        var vm = this;

        vm.activate = activate;
        vm.create = create;

        function activate() {
            vm.model = {};
        }

        function create(model) {
            //createSolutionService.
        }
    }
})();