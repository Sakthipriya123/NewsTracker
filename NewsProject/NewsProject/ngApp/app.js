var NewsPage;
(function (NewsPage) {
    'use strict';
    angular.module('NewsPage', ['ngRoute', 'ngResource', 'ui.bootstrap']).config(function ($routeProvider, $locationProvider) {
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
            .when('/Signin', {
            templateUrl: '/ngApp/views/Signin.html',
            controller: NewsPage.Controllers.LoginController,
            controllerAs: 'controller'
        })
            .when('/Categories', {
            templateUrl: '/ngApp/views/Categories.html',
            controller: 'CategoriesController as vm'
        })
            .when('/Details/:id', {
            templateUrl: '/ngApp/views/Details.html',
            controller: 'NewsDetailController as vm'
        })
            .when('/SingleCategory/:id', {
            templateUrl: '/ngApp/views/SingleCategory.html',
            controller: 'SingleCategoriesController as vm'
        })
            .when('/Admin', {
            templateUrl: '/ngApp/views/Admin.html',
            controller: NewsPage.Controllers.AdminController,
            controllerAs: 'controller'
        })
            .when('/Signup', {
            templateUrl: '/ngApp/views/Signup.html',
            controller: NewsPage.Controllers.RegisterController,
            controllerAs: 'controller'
        })
            .when('/externalLogin', {
            templateUrl: '/ngApp/views/externalLogin.html',
            controller: NewsPage.Controllers.ExternalLoginController,
            controllerAs: 'controller'
        })
            .when('/externalRegister', {
            templateUrl: '/ngApp/views/externalRegister.html',
            controller: NewsPage.Controllers.ExternalRegisterController,
            controllerAs: 'controller'
        })
            .otherwise('/');
        $locationProvider.html5Mode(true);
    });
    angular.module('NewsPage').factory('authInterceptor', function ($q, $window, $location) {
        return ({
            request: function (config) {
                config.headers = config.headers || {};
                var token = $window.sessionStorage.getItem('token');
                if (token) {
                    config.headers.Authorization = 'Bearer ' + token;
                }
                return config;
            },
            response: function (response) {
                if (response.status === 401) {
                    $location.path('/Signin');
                }
                return response || $q.when(response);
            }
        });
    });
    angular.module('NewsPage').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });
    ;
})(NewsPage || (NewsPage = {}));
//# sourceMappingURL=app.js.map