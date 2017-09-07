app.service('loginService', ['ServerRequestService', '$q', 'localStorageService','$state',
    function (ServerRequestService, $q, localStorageService, $state) {

    var deferred = $q.defer();

    this.getAuthentication = function (user,route ) {
        ServerRequestService.getLoginRoute(route,user).then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

    this.checkLog = function () {
        var res = localStorageService.get('storeAccessData');
        console.log(res);
        if (res != null) {
            
            this.redirectService(res);
        }

        return false;
    }

    this.redirectService = function (resp) {

        console.log("redirecting");

        if (resp.Status == "Pending") {

            $state.go('auth.error.pending');

        }
        else if (resp.Status == "Active") {

            if (resp.AuthToken == "Admin") {
              
                $state.go('auth.admin.home');

            } else if (resp.AuthToken == "Customer") {

                
                $state.go('auth.admin.home');
            } else if (resp.AuthToken == "Organisation") {

            }

        }

    }

}]);