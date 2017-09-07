var app = angular.module('store', ['ui.router', 'kendo.directives', 'LocalStorageModule']);

app.run(function ( $rootScope) {
    
    $rootScope.categoryList = ['Gadgets', 'Cars', 'Real Estate', 'Jobs'];
})

app.config(['$locationProvider', function ($locationProvider) {
    $locationProvider.hashPrefix('');
}]);

