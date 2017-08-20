(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpAzureStep", dpAzureStep);

    function dpAzureStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/azureStepTemplate.html",
            controller: dpAzureStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpAzureStepController.$inject = ['$state', 'createSolutionService'];

    function dpAzureStepController($state, createSolutionService) {
        var vm = this;
        vm.$onInit = activate;
        vm.moveToNextStep = moveToNextStep;

        function activate() {
            vm.model = createSolutionService.model;
        }

        function moveToNextStep() {
            createSolutionService.model = vm.model;
            $state.go('solutioncreator.confirm');
        }
    }
})();