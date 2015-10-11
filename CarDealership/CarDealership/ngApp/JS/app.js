var CarApp;
(function (CarApp) {
    angular.module('CarApp', ['ngRoute', 'ngResource', 'ui.bootstrap']).config(function ($routeProvider) {
        $routeProvider
            .when('/', {
            templateUrl: "/ngApp/Views/home.html",
            controller: CarApp.HomeController,
            controllerAs: "vm"
        })
            .otherwise('/');
    }).constant('carServiceUrl', "http://codercamps-cardealershipapi.azurewebsites.net/api/cars")
        .constant('carMakesUrl', "http://codercamps-cardealershipapi.azurewebsites.net/api/makes");
})(CarApp || (CarApp = {}));
