(function () {
    "use strict";

    angular.module("app.solutioncreator").directive("dpStepItem", dpStepItem);

    dpStepItem.$inject = [];

    function dpStepItem() {
        var directive = {
            scope: {
                name: '@',
                route: '@',
                icon: '@'
            },
            replace: true,
            templateUrl: 'app/solutioncreator/stepTemplate.html',
            link: function (scope, el, attr) {
                
            }
        };

        return directive;
    }
})();