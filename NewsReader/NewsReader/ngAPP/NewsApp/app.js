var NewsPage;
(function (NewsPage) {
    angular.module('NewsPage', ['ngRoute', 'ngResource']).config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
            templateUrl: '/ngApp/NewsApp/HomePage.html',
            controller: 'HomeController as vm'
        })
            .when('/HomePage', {
            templateUrl: '/ngApp/NewsApp/HomePage.html',
            controller: 'HomeController as vm'
        })
            .when('/Publish', {
            templateUrl: '/ngApp/NewsApp/Publish.html',
            controller: 'PublishController as vm'
        })
            .when('/Catagories', {
            templateUrl: '/ngApp/NewsApp/Catagories.html',
            controller: 'PublishController as vm'
        })
            .when('/Signin', {
            templateUrl: '/ngApp/NewsApp/Signin.html',
            controller: 'SignInController as vm'
        })
            .when('/Catagories', {
            templateUrl: '/ngApp/NewsApp/Catagories.html',
            controller: 'NewsListController as vm'
        })
            .when('/Details/:id', {
            templateUrl: '/ngApp/NewsApp/Details.html',
            controller: 'NewsDetailController as vm'
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
                    $location.path('/Products.json');
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