(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpGitlabStep", dpGitlabStep);

    function dpGitlabStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/gitlabStepTemplate.html",
            controller: dpGitlabStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpGitlabStepController.$inject = ['$state', 'createSolutionService'];

    function dpGitlabStepController($state, createSolutionService) {
        var vm = this;
        vm.$onInit = activate;
        vm.moveToNextStep = moveToNextStep;

        function activate() {
            vm.model = createSolutionService.model;
        }

        function moveToNextStep() {
            createSolutionService.model = vm.model;
            $state.go('solutioncreator.teamcity');
        }
    }
})();