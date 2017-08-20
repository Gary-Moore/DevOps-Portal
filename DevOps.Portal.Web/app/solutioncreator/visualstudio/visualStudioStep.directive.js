(function() {
    "use strict";

    angular.module("app.solutioncreator").directive("dpVisualStudioStep", dpVisualStudioStep);

    function dpVisualStudioStep() {
        var directive = {
            scope: {
                
            },
            templateUrl: "app/solutioncreator/visualstudio/visualStudioStepTemplate.html",
            controller: dpVisualStudioStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpVisualStudioStepController.$inject = ['$state', 'createSolutionService'];

    function dpVisualStudioStepController($state, createSolutionService) {
        var vm = this;
        vm.$onInit = activate;
        vm.moveToNextStep = moveToNextStep;

        function activate() {
            vm.model = createSolutionService.model;
        }

        function moveToNextStep() {
            createSolutionService.model = vm.model;
            $state.go('solutioncreator.gitlab');
        }
    }
})();