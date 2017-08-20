(function() {
    "use strict";

    angular.module('app.core').config(appConfig);

    appConfig.$inject = ['$provide'];

    function appConfig($provide) {
        $provide.decorator('$exceptionHandler', extendExceptionHandler);
    }

    extendExceptionHandler.$inject = ['$delegate', 'toastr'];

    function extendExceptionHandler($delegate, toastr) {
        return function(exception, cause) {
            $delegate(exception, cause);
            var errorData = {
                exception: exception,
                cause: cause
            };
            toastr.error(exception.msg, errorData);
        }
    }
})();