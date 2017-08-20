(function () {
    "use strict";

    angular.module("app.layout").directive("dpWizardFooter", dpWizardFooter);

    dpWizardFooter.$inject = [];

    function dpWizardFooter() {
        var directive = {
            transclude: true,
            scope: {

            },
            templateUrl: 'app/layout/footer/wizardFooterTemplate.html'
        };

        return directive;
    }
})();