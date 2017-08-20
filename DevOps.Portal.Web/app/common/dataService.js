(function () {
    "use strict";

    angular.module("app.common").factory("dataService", dataService);

    dataService.$inject = ["$http", "$q"];

    function dataService($http, $q) {
        return {
            get: getRequest,
            post: postRequest,
            put: putRequest,
            delete: deleteRequest
        };

        function getRequest(url, params) {
            var deferred = $q.defer();

            $http({
                    url: url,
                    method: "GET",
                    params: params
                })
                .then(function(result) {
                        deferred.resolve(result.data);
                    },
                    function(error) {
                        toastr.error(error);
                        deferred.reject(error);
                    });

            return deferred.promise;
        }

        function postRequest(url, data) {
            return makeRequest(url, data, "POST");
        }

        function putRequest(url, data) {
            return makeRequest(url, data, "PUT");
        }

        function deleteRequest(url, data) {
            return makeRequest(url, data, "DELETE");
        }

        function makeRequest(url, data, method) {
            var deferred = $q.defer();

            $http({
                    url: url,
                    method: method,
                    data: data
                })
                .then(function(result) {
                        deferred.resolve(result.data);
                    },
                    function(error) {
                        toastr.error(error);
                        deferred.reject(error);
                    });

            return deferred.promise;
        }
    }
})();