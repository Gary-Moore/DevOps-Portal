(function () {
    "use strict";

    angular.module('app.solutioncreator').config(routeConfig);

    routeConfig.$inject = ['$stateProvider', '$urlRouterProvider'];

    function routeConfig($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise('/');

        $stateProvider
            .state('solutioncreator.visualstudio',
                {
                    url: '/',
                    views: {
                        'wizard': {
                            templateUrl: 'app/solutioncreator/visualStudioStepTemplate.html'
                        }
                    }
                })
            .state('solutioncreator.gitlab',
                {
                    url: '/gitlab',
                    views: {
                        'wizard': {
                            templateUrl: 'app/solutioncreator/gitlabStepTemplate.html'
                        }
                    }
                })
            .state('solutioncreator.teamcity',
                {
                    url: '/teamcity',
                    views: {
                        'wizard': {
                            template: '<dp-teamcity-step></dp-teamcity-step>'
                        }
                    }
                });
    }
})();