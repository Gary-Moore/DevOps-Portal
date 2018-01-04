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

    dpVisualStudioStepController.$inject = ['$state', 'createSolutionService', 'templateService'];

    function dpVisualStudioStepController($state, createSolutionService, templateService) {
        var vm = this;
        vm.$onInit = activate;
        vm.moveToNextStep = moveToNextStep;

        function activate() {
            vm.model = createSolutionService.model;

            templateService.getTemplates().then(function (data) {
                vm.templates = data;
            });
        }

        function moveToNextStep() {
            createSolutionService.model = vm.model;
            $state.go('solutioncreator.gitlab');
        }
    }
})();