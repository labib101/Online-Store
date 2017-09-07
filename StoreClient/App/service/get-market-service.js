app.service('getMarketService', ['ServerRequestService','$q', function (ServerRequestService,$q) {

    var deferred = $q.defer();

    this.getAllProducts = function () {
        ServerRequestService.getMarketItems("getAllProducts").then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

    this.getSelectedProduct = function () {
        ServerRequestService.getMarketItems("getSelectedProduct").then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

    this.getOrganisationList = function () {
        ServerRequestService.getMarketItems("getOrganisationList").then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

    this.getPremiumAds = function () {
        ServerRequestService.getMarketItems("getPremiumAds").then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

    this.getCategoryList = function () {
        ServerRequestService.getMarketItems("getCategoryList").then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

    this.getSubCategoryList = function () {
        ServerRequestService.getMarketItems("getSubCategoryList").then(function (response) {
            deferred.resolve(response.data);
        });
        return deferred.promise;
    }

}])