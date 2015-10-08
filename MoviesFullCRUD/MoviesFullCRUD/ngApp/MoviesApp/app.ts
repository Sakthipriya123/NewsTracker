namespace MoviesApp {

    angular.module('MoviesApp', ['ngRoute', 'ngResource']).config((
        $locationProvider: ng.ILocationProvider,
        $routeProvider: ng.route.IRouteProvider
    ) => {

        $routeProvider
            .when('/', {
                templateUrl: '/ngApp/MoviesApp/home.html',
                controller: 'MoviesListController as vm'
            })
            .when('/login', {
                templateUrl: '/ngApp/MoviesApp/login.html',
                //controller: 'AccountController as vm'
            })
            .when('/add', {
                templateUrl: '/ngApp/MoviesApp/add.html',
                controller: 'MoviesAddController as vm'
            })
        //here id in the delete is the parameter
            .when('/delete/:id', {
                templateUrl: '/ngApp/MoviesApp/delete.html',
                controller: 'MoviesDeleteController as vm'
            })
            .when('/edit/:id', {
                templateUrl: '/ngApp/MoviesApp/edit.html',
                controller: 'MoviesEditController as vm'
            });

        $locationProvider.html5Mode(true);

    }).constant('movieServiceUrl', 'http://MoviesWebAPIApp.azurewebsites.net/api/movies/:id')
        .constant('authenticateURL', 'http://MoviesWebAPIApp.azurewebsites.net/Token');

    angular.module('MoviesApp').factory('authInterceptor', (        $q: ng.IQService,        $window: ng.IWindowService,        $location: ng.ILocationService    ) =>        ({            request: function (config) {                config.headers = config.headers || {};                let token = $window.sessionStorage.getItem('token');                if (token) {                    config.headers.Authorization = 'Bearer ' + token;                }                return config;            },            response: function (response) {                if (response.status === 401) {                    $location.path('/login');                }                return response || $q.when(response);            }        })    );    angular.module('MoviesApp').config(function ($httpProvider) {        $httpProvider.interceptors.push('authInterceptor');    });;

}