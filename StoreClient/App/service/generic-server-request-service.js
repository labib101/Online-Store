app.service('ServerRequestService', ['$http', function ($http) {
    
    this.getMarketItems = function (path) {
        return $http({ method: "get", url: "http://localhost/mobilestore/api/market/" + path });
    }

    this.getLoginRoute = function (path,user) {
        return $http({
            method: "Post",
            url: "http://localhost/mobilestore/api/Authentication/" + path,
            data: user,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
        });
    }

    this.setNewEntity = function (path, user) {
        console.log(user);
        return $http.post(
            'http://localhost/mobilestore/api/Profile/' + path,
            user
        );
    }

    this.getRandomQuote = function () {
        
        return $http.get(
            'http://quotesondesign.com/wp-json/posts?filter[orderby]=rand&filter[posts_per_page]=1'
            );
    }

    this.getAdminResources = function (path) {
        return $http.get(
            'http://localhost/mobilestore/api/admin/' + path
            );
    }

    this.updatePassword = function (data, path) {
        return $http.post(
            'http://localhost/mobilestore/api/Authentication/' + path,
            data
        );
    }

}])