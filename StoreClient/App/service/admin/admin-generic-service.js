app.service('adminGenericService', ['$q', 'localStorageService', '$state', 'ServerRequestService',
    function ($q, localStorageService, $state, ServerRequestService) {

        var deferred = $q.defer();

        this.getNumberOfAdmins = function () {
            ServerRequestService.getAdminResources('getNumberOfAdmins').then(function (response) {
                
                deferred.resolve(response.data);
            });
            return deferred.promise;
        }

}])