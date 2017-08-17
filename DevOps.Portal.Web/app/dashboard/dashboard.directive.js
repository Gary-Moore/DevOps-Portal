(function() {
    "use strict";

    angular.module("app.dashboard").directive("dpDashboard", dpDashboard);

    dpDashboard.$inject = [];

    function dpDashboard() {
        var directive = {
            scope: {
                
            },
            templateUrl: 'app/dashboard/dashboardTemplate.html',
            controller: dpDashboardController,
            controllerAs: "vm"
        };

        return directive;
    }

    function dpDashboardController() {
        var vm = this;
    }
})();