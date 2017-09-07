app.service('adminGenericService', ['$q', 'localStorageService', '$state', 'ServerRequestService',
    function ($q, localStorageService, $state, ServerRequestService) {

        var deferred = $q.defer();

        this.logout = function () {
            localStorageService.clearAll();
            $state.go('home.market');
        }

        this.getAdminInfo = function () {
            var admin = localStorageService.get('storeAccessData');
            return admin;
        }

        this.getUpdatePasswordStatus = function (day) {

            if (day != null) {
                var oneDay = 24 * 60 * 60 * 1000; // hours*minutes*seconds*milliseconds

                var updateDate = new Date(day);
                var today = new Date();

                var diffDays = Math.round(Math.abs((updateDate.getTime() - today.getTime()) / (oneDay)));
                console.log(diffDays);

                return diffDays;
            } else { return 0;}
           
        }

        this.getRandomQuote = function () {
            ServerRequestService.getRandomQuote().then(function (response) {
                //console.log(response);
                deferred.resolve(response.data);
            });
            return deferred.promise;
        }

        this.getNumberOfAdmins = function () {
            ServerRequestService.getAdminResources('getNumberOfAdmins').then(function (response) {
                
                deferred.resolve(response.data);
            });
            return deferred.promise;
        }

}])