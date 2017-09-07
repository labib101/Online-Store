app.controller('authController',
    ['loginService', '$scope', '$state', 'localStorageService', function (loginService, $scope, $state, localStorageService) {
        console.log("Controller started");
        
        loginService.checkLog();

        $scope.login = true;

        $scope.forgot = function () {

            $scope.login = false;
        }

        $scope.back = function () {

            $scope.login = true;
        }

        

        $scope.submit = function () {

            $scope.q = true;
            var user = 'Email=' + $scope.email + '&Password=' + $scope.password;

            loginService.getAuthentication(user, "login").then(function (promise) {

                var resp = promise;
                console.log(resp);
                if (resp != "Incorrect User Name or password")
                {
                    localStorageService.set('storeAccessData', resp);
                    loginService.redirectService(resp);
                }
                else {
                    $scope.q = false;
                    $scope.errormsg = resp;
                }
                
            });

        }

        $scope.retrieve = function () {

            $scope.q = true;
            var user = 'Email=' + $scope.email;

            loginService.getAuthentication(user, "forgetPassward").then(function (promise) {

                var resp = promise;
                console.log(resp);
                $scope.q = false;
                $scope.errormsg = resp;
            });
        }


        $scope.goHome = function () {
            $state.go('home');
        }

    }]);
