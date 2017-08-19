(function() {
    "use strict";

    angular.module('app.solutioncreator').directive('dpTeamcityStep', dpTeamcityStep);

    dpTeamcityStep.$inject = [];

    function dpTeamcityStep() {
        var directive = {
            templateUrl: 'app/solutioncreator/steps/teamcityStepTemplate.html',
            scope: {
                
            },
            controller: dpTeamcityStepController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    dpTeamcityStepController.$inject = ['teamcityService'];

    function dpTeamcityStepController(teamcityService) {
        var vm = this;
        vm.$onInit = activate;

        function activate() {
            vm.newParent = 'existing';

            teamcityService.getBuildTemplates().then(function(data) {
                vm.buildTemplates = data;
            });

            teamcityService.getProjects().then(function (data) {
                vm.projects = data;
            });
        }
    }
})();