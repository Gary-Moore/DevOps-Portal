(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpSolutionCreator", dpSolutionCreator);

    dpSolutionCreator.$inject = [];

    function dpSolutionCreator() {
        var directive = {
            scope: {
                creationStarted: '='
            },
            templateUrl: 'app/solutioncreator/createSolutionTemplate.html',
            controller: dpSolutionCreatorController,
            controllerAs: "vm"
        };

        return directive;
    }

    function dpSolutionCreatorController() {
        var vm = this;
    }
})();