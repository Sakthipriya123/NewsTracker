var MyApp;
(function (MyApp) {
    angular.module('MyApp', ['ngRoute', 'ngResource', 'ui.bootstrap']).config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
            templateUrl: '/ngApp/views/home.html',
            controller: MyApp.Controllers.HomeController,
            controllerAs: 'controller'
        })
            .when('/about', {
            templateUrl: '/ngApp/views/about.html',
            controller: MyApp.Controllers.AboutController,
            controllerAs: 'controller'
        })
            .when('/bid/:id', {
            templateUrl: '/ngApp/views/bid.html',
            controller: MyApp.Controllers.BidController,
            controllerAs: 'controller'
        })
            .when('/Create', {
            templateUrl: '/ngApp/views/Create.html',
            controller: MyApp.Controllers.CreateController,
            controllerAs: 'controller'
        })
            .otherwise({
            templateUrl: '/ngApp/views/notFound.html'
        });
        $locationProvider.html5Mode(true);
    });
})(MyApp || (MyApp = {}));
//# sourceMappingURL=app.js.map