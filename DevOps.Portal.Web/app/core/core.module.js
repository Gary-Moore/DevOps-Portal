(function () {
    'use strict';

    angular.module('app.core', [
        // Angular modules 
        'ngAnimate',
        'ngSanitize',
        // Custom modules 
        'app.layout',
        'app.common',
        // 3rd Party Modules
        'ui.router',
        'ui.bootstrap',
        'ui.select',
        'SignalR'
    ]);
})();