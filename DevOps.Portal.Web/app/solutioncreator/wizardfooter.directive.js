(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpWizardFooter", dpWizardFooter);

    dpWizardFooter.$inject = [];

    function dpWizardFooter() {
        var directive = {
            transclude: true,
            scope: {

            },
            templateUrl: 'app/solutioncreator/wizardFooterTemplate.html'
        };

        return directive;
    }
})();