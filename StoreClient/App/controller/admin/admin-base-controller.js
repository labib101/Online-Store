app.controller('adminBaseController', ['$scope', '$state', 'localStorageService', 'adminGenericService',
    'genericService',
    function ($scope, $state, localStorageService, adminGenericService, genericService) {

    $scope.q = true;

    console.log('Admin controller started');
    
    

    genericService.getRandomQuote().then(function (promise) {
        
        $scope.quote = promise;
        console.log(promise);
        

        adminGenericService.getNumberOfAdmins().then(function (promise) {
            $scope.noOfAdmins = promise.length;
            console.log(promise.length);
            $scope.q = false;
        });
    });

    $scope.adminInfo = genericService.getUserInfo();

    $scope.days = genericService.getUpdatePasswordStatus($scope.adminInfo.LastUpdate);

    $scope.generatePassword = function () {

    }

    

    $scope.logout = function () {
        genericService.logout();
    }

    

    

}]);