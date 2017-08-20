(function () {
    'use strict';

    angular.module('app.layout').directive("dpMenuItem", dpMenuItem);

    function dpMenuItem() {
        var directive = {
            require: "^dpMenu",
            transclude: true,
            scope: {
                label: '@',
                icon: '@'
            },
            templateUrl: 'app/layout/menu/dpMenuItemTemplate.html'
        };
        return directive;
    }
})();