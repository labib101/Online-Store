app.controller('adminBaseController', ['$scope', '$state', 'localStorageService','adminGenericService',
    function ($scope, $state, localStorageService, adminGenericService) {

    $scope.q = true;

    console.log('Admin controller started');
    
    

    adminGenericService.getRandomQuote().then(function (promise) {
        
        $scope.quote = promise;
        console.log(promise);
        

        adminGenericService.getNumberOfAdmins().then(function (promise) {
            $scope.noOfAdmins = promise.length;
            console.log(promise.length);
            $scope.q = false;
        });
    });

    $scope.adminInfo = adminGenericService.getAdminInfo();

    $scope.days = adminGenericService.getUpdatePasswordStatus($scope.adminInfo.LastUpdate);

    $scope.generatePassword = function () {

    }

    

    $scope.logout = function () {
        adminGenericService.logout();
    }

    

    

}]);