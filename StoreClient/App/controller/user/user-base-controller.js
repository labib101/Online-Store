app.controller('userBaseController', ['$scope', 'localStorageService', 'genericService', 'userGenericService',
    function ($scope, localStorageService, genericService, userGenericService) {

        $scope.q = true;
        $scope.changePassword = false;
        console.log('user controller started');

        genericService.getRandomQuote().then(function (promise) {

            $scope.quote = promise;
            console.log(promise);
            $scope.q = false;
        });

        $scope.UserInfo = genericService.getUserInfo();

        $scope.days = genericService.getUpdatePasswordStatus($scope.UserInfo.LastUpdate);

        $scope.togglePassword = function()
        {
            $scope.errorMsg = null;
            $scope.changePassword = !$scope.changePassword;
            
        }

        $scope.generatePassword = function () {
            if ($scope.OldPassword != $scope.UserInfo.Password)
            {
                
                $scope.errorMsg = "Old Password Not Matched";
            }
            else {
                $scope.q = true;
                $scope.togglePassword();
                var data = {
                    'Email': $scope.UserInfo.Email,
                    'OldPassword': $scope.OldPassword,
                    'NewPassword': $scope.NewPassword
                }
                genericService.updatePassword(data).then(function (promise) {
                    console.log(promise);
                    $scope.q = false;
                    $scope.confirmation = true;
                })

            }
            
        }

        $scope.logout = function () {
            genericService.logout();
        }
}]);