﻿namespace NewsPage {
    'use strict';

    angular.module('NewsPage', ['ngRoute', 'ngResource', 'ui.bootstrap']).config(
        (
            $routeProvider: ng.route.IRouteProvider,
            $locationProvider: ng.ILocationProvider
        ) => {
            $routeProvider
                .when('/', {
                    templateUrl: '/ngApp/views/HomePage.html',
                    controller: 'HomeController as vm'
                })
                .when('/HomePage', {
                    templateUrl: '/ngApp/views/HomePage.html',
                    controller: 'HomeController as vm'
                })
                .when('/Publish', {
                    templateUrl: '/ngApp/views/Publish.html',
                    controller: 'PublishController as vm'
                })
                .when('/Catagories', {
                    templateUrl: '/ngApp/views/Catagories.html',
                    controller: 'PublishController as vm'
                })
                .when('/Signin', {
                    templateUrl: '/ngApp/views/Signin.html',
                    controller: 'SignInController as vm'
                })
                .when('/Catagories', {
                    templateUrl: '/ngApp/views/Categories.html',
                    controller: 'NewsListController as vm'
                })
                .when('/Details/:id', {
                    templateUrl: '/ngApp/views/Details.html',
                    controller: 'NewsDetailController as vm'
                })
                .otherwise('/');
            $locationProvider.html5Mode(true);
        });

    angular.module('NewsPage').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                let token = $window.sessionStorage.getItem('token');
                if (token) {
                    config.headers.Authorization = 'Bearer ' + token;
                }
                return config;
            },
            response: function (response) {
                if (response.status === 401) {
                    $location.path('/Products.json');
                }
                return response || $q.when(response);
            }
        })
    );
    angular.module('NewsPage').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });;
}