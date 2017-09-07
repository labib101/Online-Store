app.controller('marketBaseController', ['getMarketService','$scope', function (getMarketService,$scope) {
    console.log("marketBaseController Loaded");

    $scope.premiumAds = [];
    $scope.productList = [];

    getMarketService.getCategoryList().then(function (promise) {
        console.log(promise);
        $scope.categoryList = promise;
    });

    

}]);

app.controller('marketController', [function () {
    console.log("marketController Loaded");
}]);