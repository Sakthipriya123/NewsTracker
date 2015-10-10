namespace CarApp {

    angular.module('CarApp', ['ngRoute', 'ngResource', 'ui.bootstrap']).config(function ($routeProvider: ng.route.IRouteProvider ) {

        $routeProvider

            .when('/', {
                templateUrl: "/ngApp/Views/home.html",
                controller: HomeController,
                controllerAs: "vm"              

            })
            //.when('/dialog', {
            //    templateUrl: "/ngApp/Views/dialog.html",
            //    controller: DialogController,
            //    controllerAs: "modal"
            //})

            .otherwise('/')

        

    }).constant('carServiceUrl', "http://codercamps-cardealershipapi.azurewebsites.net/api/cars")
        //.constant('carMakesUrl',"http://codercamps-cardealershipapi.azurewebsites.net/api/makes")
    

}