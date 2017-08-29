(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpConfirmStep", dpConfirmStep);

    function dpConfirmStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/confirm/confirmStepTemplate.html",
            controller: dpConfirmStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpConfirmStepController.$inject = ['$state', '$uibModal', 'createSolutionService', 'progressService'];

    function dpConfirmStepController($state, $uibModal, createSolutionService, progressService) {
        var vm = this;
        vm.$onInit = activate;
        vm.create = create;

        function activate() {
            vm.model = createSolutionService.model;
            vm.creationStarted = false;
            
        }

        function create() {
            $uibModal.open({
                    templateUrl: 'app/solutioncreator/progress/progressModalTemplate.html',
                    controller: 'CreationProgressModalController',
                    controllerAs: 'vm',
                    bindToController: true,
                    backdrop: 'static'
                })
                .result.then(function(result) {
                        createSolutionService.completedSolution = result;
                        $state.go('createdsolution');
                    },
                    function(error) {
                        console.log(error);
                    });
        }
    }
})();