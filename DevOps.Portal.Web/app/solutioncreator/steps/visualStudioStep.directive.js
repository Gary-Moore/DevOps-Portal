(function() {
    "use strict";

    angular.module("app.solutioncreator").directive("dpVisualStudioStep", dpVisualStudioStep);

    function dpVisualStudioStep() {
        var directive = {
            scope: {
                
            },
            templateUrl: "app/solutioncreator/steps/visualStudioStepTemplate.html"
        };

        return directive;
    }
})();