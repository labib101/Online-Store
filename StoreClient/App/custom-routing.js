app.config(function ($stateProvider, $urlRouterProvider) {

    var home = {
        name: 'home',
        url: '/welcome',
        templateUrl: 'templates/market/market-container.html',
        controller: 'marketBaseController'
    };

    var marketView = {
        name: 'home.market',
        url: '/store',
        templateUrl: 'templates/market/market-home.html',
        controller: 'marketController'
    };

    var products = {
        name: 'home.marketProductList',
        url: '/products',
        templateUrl: 'templates/market/market-product-container.html',
        controller: 'productBaseController'
    };

    var productsByCategory = {
        name: 'home.marketProductList.category',
        url: '/:categoryId',
        templateUrl: 'templates/market/market-product-list-by-category.html',
        controller: 'productBaseController'
    };

    var listOfProducts = {
        name: 'home.marketProductList.marketProductList',
        url: '/',
        templateUrl: 'templates/market/market-product-list.html',
        controller: 'marketProductListController'
    };

    var ProductDetails = {
        name: 'home.marketProductList.productDetails',
        url: '/details/:productId',
        templateUrl: 'templates/market/market-product-list.html',
        controller: 'marketProductDetailsController'
    };

    var Login = {
        name: 'auth',
        url: '/authenticate',
        abstract: true,
        templateUrl: 'templates/auth/auth-container.html',
        controller: 'authController'
    };

    var LoginPage = {
        name: 'auth.login',
        url: '/signin',
        templateUrl: 'templates/auth/login.html',
        controller: 'authController'
    };

    var newUser = {
        name: 'auth.new',
        url: '/new',
        templateUrl: 'templates/shared/update-user.html',
        controller: 'newUserController'
    };

    var adminBase = {
        name: 'auth.admin',
        url: '/admin',
        abstract: true,
        templateUrl: 'templates/admin/admin-base-container.html',
        controller: 'adminBaseController'
    };

    var userBase = {
        name: 'auth.user',
        url: '/user',
        abstract: true,
        templateUrl: 'templates/user/user-base-container.html',
        controller: 'userBaseController'
    };

    var admindash = {
        name: 'auth.admin.home',
        url: '/home',
        
        templateUrl: 'templates/admin/admin-base-dash.html',
        controller: 'adminBaseController'
    };

    var userdash = {
        name: 'auth.user.home',
        url: '/home',
        
        templateUrl: 'templates/user/user-base-dash.html',
        controller: 'userBaseController'
    };

    var error = {
        name: 'auth.error',
        url: '/error',
        templateUrl: 'templates/shared/error.html',
        controller: 'authController'
    };

    var pendingUser = {
        name: 'auth.error.pending',
        url: '/pending',
        templateUrl: 'templates/user/user-pending.html',
        controller: 'authController'
    };

    var blockedUser = {
        name: 'auth.error.blocked',
        url: '/blocked',
        templateUrl: 'templates/user/user-blocked.html',
        controller: 'authController'
    };

    //Registering States
    $stateProvider.state(home);
    $stateProvider.state(marketView);
    $stateProvider.state(products);
    $stateProvider.state(productsByCategory);
    $stateProvider.state(listOfProducts);
    $stateProvider.state(ProductDetails);
    $stateProvider.state(Login);
    $stateProvider.state(LoginPage);
    $stateProvider.state(newUser);
    $stateProvider.state(adminBase);
    $stateProvider.state(userBase);
    $stateProvider.state(admindash);
    $stateProvider.state(userdash);
    $stateProvider.state(error);
    $stateProvider.state(pendingUser);
    $stateProvider.state(blockedUser);
    $urlRouterProvider.otherwise('welcome/store');
})