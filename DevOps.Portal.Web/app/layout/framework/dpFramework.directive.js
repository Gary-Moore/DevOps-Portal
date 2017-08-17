(function () {
    "use strict";

    angular.module("app.layout").directive("dpFramework", dpFramework);

    dpFramework.$inject = [];

    function dpFramework() {
        var directive = {
            transclude: true,
            controller: dpFrameworkController,
            controllerAs: 'vm',
            templateUrl: "app/layout/framework/dpFrameworkTemplate.html"
        };

        return directive;
    }

    function dpFrameworkController() {
        
    }
})();