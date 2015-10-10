var MyApp;
(function (MyApp) {
    angular.module('MyApp', ['ngRoute']).config(function ($routeProvider) {
        $routeProvider
            .when('/', {
            templateUrl: "ngApp/AngularPractice/home.html",
            controller: MyApp.HomeController,
            controllerAs: "vm"
        })
            .when('/cars', {
            templateUrl: "ngApp/AngularPractice/cars.html",
            controller: MyApp.CarsController,
            controllerAs: "vm"
        })
            .otherwise('/');
    });
})(MyApp || (MyApp = {}));
