app.controller('newUserController',
    ['marketService','setNewService', '$scope', '$state', function (marketService,setNewService, $scope, $state) {
        console.log("new user Controller started");
        //$scope.q = false;
        
        $scope.UserModel = [];
        $scope.showOrganisation = false;
        $scope.header = "Enter your Details";
        
        marketService.fetchData("getOrganisationList").then(function (promise) {
            $scope.organisationList = promise;
            console.log(promise);
        })

        $scope.update = function () {
            $scope.q = true;
            var UserModel = $scope.UserModel;
            var user = {
                'FirstName': UserModel.FirstName,
                'LastName': UserModel.LastName,
                'Email': UserModel.Email,
                'ContactNumber': UserModel.ContactNumber,
                'Gender': UserModel.Gender
            }
       
            setNewService.setNewUser(user, "insertCustomer").then(function (promise) {
                //$scope.organisationList = promise;
                console.log(promise);
                if(promise!= "Error")
                {
                    $state.go('auth.error.pending');
                }
            })
        }

    }]);
