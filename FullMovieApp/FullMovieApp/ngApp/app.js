var MyApp;
(function (MyApp) {
    angular.module('MyApp', ['ngRoute', 'ngResource']).config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
            templateUrl: '/ngApp/views/home.html',
            controller: MyApp.Controllers.HomeController,
            controllerAs: 'controller'
        })
            .when('/Create', {
            templateUrl: '/ngApp/views/Create.html',
            controller: MyApp.Controllers.AddNewMovieController,
            controllerAs: 'controller'
        })
            .when('/Delete/:id', {
            templateUrl: '/ngApp/views/Delete.html',
            controller: MyApp.Controllers.DeleteMovieController,
            controllerAs: 'controller'
        })
            .when('/Edit/:id', {
            templateUrl: '/ngApp/views/Edit.html',
            controller: MyApp.Controllers.EditMovieController,
            controllerAs: 'controller'
        })
            .otherwise({
            templateUrl: '/ngApp/views/notFound.html'
        });
        $locationProvider.html5Mode(true);
    });
})(MyApp || (MyApp = {}));
