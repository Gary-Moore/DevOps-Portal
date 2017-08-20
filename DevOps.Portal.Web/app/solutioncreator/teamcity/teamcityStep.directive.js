(function() {
    "use strict";

    angular.module('app.solutioncreator').directive('dpTeamcityStep', dpTeamcityStep);

    dpTeamcityStep.$inject = [];

    function dpTeamcityStep() {
        var directive = {
            templateUrl: 'app/solutioncreator/teamcity/teamcityStepTemplate.html',
            scope: {
                
            },
            controller: dpTeamcityStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpTeamcityStepController.$inject = ['$state', 'teamcityService', 'createSolutionService'];

    function dpTeamcityStepController($state, teamcityService, createSolutionService) {
        var vm = this;
        vm.$onInit = activate;
        vm.moveToNextStep = moveToNextStep;

        function activate() {
            vm.model = createSolutionService.model;
            vm.newParent = 'existing';

            teamcityService.getBuildTemplates().then(function(data) {
                vm.buildTemplates = data;
            });

            teamcityService.getProjects().then(function (data) {
                vm.projects = data;
            });
        }

        function moveToNextStep() {
            createSolutionService.model = vm.model;
            $state.go('solutioncreator.octopus');
        }
    }
})();