app.service('marketService', ['ServerRequestService', '$q', function (ServerRequestService, $q) {

    var deferred = $q.defer();

    this.fetchData = function (path) {
        ServerRequestService.getMarketItems(path).then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

}]);