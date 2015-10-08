﻿namespace MoviesApp {

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

    });

    angular.module('MoviesApp').factory('authInterceptor', (

}