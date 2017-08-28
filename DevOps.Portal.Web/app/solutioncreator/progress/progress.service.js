(function() {
    "use strict";

    angular.module("app.solutioncreator").factory("progressService", progressService);

    progressService.$inject = ['$rootScope', '$q', 'Hub'];

    function progressService($rootScope, $q, Hub) {
        var model = {},
            status = {};

        var service = {
            model: model,
            start: start,
            status: status
        };

        var progressHub = new Hub('solutioncreator', {

            listeners: {
                'progress': function (data) {
                    status.current = data.currentStatus;
                    console.log(status.current);
                    $rootScope.$apply();
                }
            },
            methods: ['startConnection'],
            errorHandler: function (error) {
                console.error(error);
            },
            stateChanged: function (state) {
                switch (state.newState) {
                case $.signalR.connectionState.connecting:
                    //your code here
                    console.log("connecting");
                    break;
                case $.signalR.connectionState.connected:
                    //your code here
                    console.log("connected");
                    break;
                case $.signalR.connectionState.reconnecting:
                    //your code here
                    console.log("reconnecting");
                    break;
                case $.signalR.connectionState.disconnected:
                    //your code here
                    console.log("disconnected");
                    break;
                }
            }
        });

        function start() {

            var deferred = $q.defer();

            progressHub.startConnection().then(function(result) {
                deferred.resolve(result);
            },
            function(error) {
                deferred.reject(error);
            });

            return deferred.promise;
        };

        var deferred = $q.defer();

        progressHub.promise.done(function() {
            deferred.resolve(service);
        });

        progressHub.promise.fail(function (error) {
            deferred.reject(new Error("Error connecting to Server: " + error));
        });

        return deferred.promise;
    }
})();