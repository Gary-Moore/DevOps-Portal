(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpOctopusStep", dpOctopusStep);

    function dpOctopusStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/octopusStepTemplate.html"
        };

        return directive;
    }
})();