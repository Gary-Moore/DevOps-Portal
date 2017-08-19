(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpAzureStep", dpAzureStep);

    function dpAzureStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/azureStepTemplate.html"
        };

        return directive;
    }
})();