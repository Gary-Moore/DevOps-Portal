(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpGitlabStep", dpGitlabStep);

    function dpGitlabStep() {
        var directive = {
            scope: {

            },
            templateUrl: "app/solutioncreator/steps/gitlabStepTemplate.html"
        };

        return directive;
    }
})();