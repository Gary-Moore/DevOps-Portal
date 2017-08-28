(function() {
    "use strict";

    angular.module('app.solutioncreator').controller('CreationProgressModalController', CreationProgressModalController);

    CreationProgressModalController.$inject = ['$uibModalInstance', 'createSolutionService', 'progressService'];

    function CreationProgressModalController($uibModalInstance, createSolutionService, progressService) {
        var vm = this;
        vm.activate = activate;

        vm.activate();

        function activate() {
            progressService.then(function (hub) {
                vm.status = hub.status;
                hub.start().then(function (data) {
                    createSolutionService.model.connectionId = data;
                    createSolutionService.create().then(function(data) {
                        if (data.success) {
                            $uibModalInstance.close(data.result);
                        }
                    });
                });
            });
        }

        vm.cancel = function () {
            $uibModalInstance.dismiss();
        }
    }
})();