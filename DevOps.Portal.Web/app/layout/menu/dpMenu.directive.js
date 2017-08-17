(function () {
    'use strict';

    angular.module('app.layout').directive("dpMenu", dpMenu);

    function dpMenu() {
        var directive = {
            transclude: true,
            templateUrl: 'app/layout/menu/dpMenuTemplate.html',
            controller: dpMenuController
        };
        return directive;
    }

    dpMenuController.$inject = [];

    function dpMenuController() {
        
    }
})();