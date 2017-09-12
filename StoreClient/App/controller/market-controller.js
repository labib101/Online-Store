app.controller('marketBaseController', ['getMarketService', '$scope', 'ServerRequestService',
    function (getMarketService, $scope, ServerRequestService) {
    console.log("marketBaseController Loaded");

    $scope.premiumAds = [];
    $scope.productList = [];

    getMarketService.getCategoryList().then(function (promise) {
        console.log(promise);
        $scope.categoryList = promise;
    });

    ServerRequestService.getMarketItems('test').then(function (response) {
        console.log(response);
    });

}]);

app.controller('marketController', [function () {
    console.log("marketController Loaded");
}]);