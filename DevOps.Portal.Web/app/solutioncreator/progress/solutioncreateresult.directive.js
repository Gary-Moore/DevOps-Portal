(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpSolutionCreateResult", dpSolutionCreateResult);

    dpSolutionCreateResult.$inject = [];

    function dpSolutionCreateResult() {
        var directive = {
            scope: {
                creationStarted: '='
            },
            templateUrl: 'app/solutioncreator/progress/createResultTemplate.html',
            controller: dpSolutionCreateResultController,
            controllerAs: "vm"
        };

        return directive;
    }

    dpSolutionCreateResultController.$inject = ['$state', 'createSolutionService'];

    function dpSolutionCreateResultController($state, createSolutionService) {
        var vm = this;
        vm.$onInit = activate();

        function activate() {
            if (!createSolutionService.completedSolution.ParentProject) {
                $state.go('solutioncreator.visualstudio');
            }
            vm.completedSolution = createSolutionService.completedSolution;
        }
    }
})();