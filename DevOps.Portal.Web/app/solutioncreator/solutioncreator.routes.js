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
                            template: '<dp-visual-studio-step></dp-visual-studio-step>'
                        }
                    }
                })
            .state('solutioncreator.gitlab',
                {
                    url: '/gitlab',
                    views: {
                        'wizard': {
                            template: '<dp-gitlab-step></dp-gitlab-step>'
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
                })
            .state('solutioncreator.azure',
                {
                    url: '/azure',
                    views: {
                        'wizard': {
                            template: '<dp-azure-step></dp-azure-step>'
                        }
                    }
                })
            .state('solutioncreator.octopus',
                {
                    url: '/octopus',
                    views: {
                        'wizard': {
                            template: '<dp-octopus-step></dp-octopus-step>'
                        }
                    }
                })
            .state('solutioncreator.confirm',
                {
                    url: '/confirm',
                    views: {
                        'wizard': {
                            template: '<dp-confirm-step></dp-confirm-step>'
                        }
                    }
                })
            .state('solutioncreator.progress',
                {
                    url: '/progress',
                    views: {
                        'wizard': {
                            template: '<dp-progress-step></dp-progress-step>'
                        }
                    }
                });
    }
})();