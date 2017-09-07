app.service('setNewService', ['ServerRequestService', '$q', function (ServerRequestService, $q) {

    var deferred = $q.defer();

    this.setNewUser = function (user, route) {
        
    ServerRequestService.setNewEntity(route,user).then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

}]);