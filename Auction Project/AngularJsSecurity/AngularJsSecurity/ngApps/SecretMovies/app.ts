namespace SecretMovies {
    angular.module('SecretMovies', []);


    angular.module('SecretMovies').factory('authInterceptor', (        $q: ng.IQService,        $window: ng.IWindowService,        $location: ng.ILocationService    ) =>        ({            request: function (config) {                config.headers = config.headers || {};                let token = $window.sessionStorage.getItem('token');                if (token) {                    config.headers.Authorization = 'Bearer ' + token;                }                return config;            },            response: function (response) {                if (response.status === 401) {                    $location.path('/login');                }                return response || $q.when(response);            }        })    );    angular.module('SecretMovies').config(function ($httpProvider) {        $httpProvider.interceptors.push('authInterceptor');    });;
}