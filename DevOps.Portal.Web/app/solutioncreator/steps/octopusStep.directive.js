(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpOctopusStep", dpOctopusStep);

    function dpOctopusStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/octopusStepTemplate.html",
            controller: dpOctopusStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpOctopusStepController.$inject = ['$state', 'createSolutionService'];

    function dpOctopusStepController($state, createSolutionService) {
        var vm = this;
        vm.$onInit = activate;
        vm.moveToNextStep = moveToNextStep;

        function activate() {
            vm.model = createSolutionService.model;
        }

        function moveToNextStep() {
            createSolutionService.model = vm.model;
            $state.go('solutioncreator.azure');
        }
    }
})();