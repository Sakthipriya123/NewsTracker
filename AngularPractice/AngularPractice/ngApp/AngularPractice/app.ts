namespace MyApp {
    angular.module('MyApp', ['ngRoute']).config(function ($routeProvider: ng.route.IRouteProvider) {

        $routeProvider
            .when('/', {
                templateUrl: "ngApp/AngularPractice/home.html",
                controller: HomeController,
                controllerAs: "vm"
            })
            .when('/cars', {
                templateUrl: "ngApp/AngularPractice/cars.html",
                controller: CarsController,
                controllerAs: "vm"
            })
             .otherwise('/');     

    });
}