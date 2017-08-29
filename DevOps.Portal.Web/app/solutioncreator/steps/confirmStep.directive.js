(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpConfirmStep", dpConfirmStep);

    function dpConfirmStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/confirmStepTemplate.html",
            controller: dpConfirmStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpConfirmStepController.$inject = ['$state', 'createSolutionService'];

    function dpConfirmStepController($state, createSolutionService) {
        var vm = this;
        vm.$onInit = activate;
        vm.moveToNextStep = moveToNextStep;
        vm.create = create;

        function activate() {
            vm.model = createSolutionService.model;
        }

        function create() {
            createSolutionService.model = vm.model;
            createSolutionService.create().then(function() {
                $state.go('solutioncreator.progress');
            });
        }

        function moveToNextStep() {
            createSolutionService.model = vm.model;
            $state.go('solutioncreator.confirm');
        }
    }
})();