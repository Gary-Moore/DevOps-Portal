(function() {
    "use strict";

    angular.module('app.core').config(routeConfig);

    routeConfig.$inject = ['$stateProvider', '$urlRouterProvider'];

    function routeConfig($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise('/');

        $stateProvider
            .state('dashboard',
            {
                url: '/',
                template: "<dp-dashboard></dp-dashboard>"
            })
            .state('solutioncreator',
            {
                url: '/create-solution',
                template: "<dp-solution-creator></dp-solution-creator>"
            });


    }
})();