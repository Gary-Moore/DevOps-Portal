(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpConfirmStep", dpConfirmStep);

    function dpConfirmStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/confirmStepTemplate.html"
        };

        return directive;
    }
})();