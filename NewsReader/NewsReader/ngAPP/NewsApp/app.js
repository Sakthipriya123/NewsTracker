var NewsPage;
(function (NewsPage) {
    angular.module('NewsPage', ['ngRoute']).config(function ($routeProvider, $locationProvider) {
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
            .otherwise('/');
        $locationProvider.html5Mode(true);
    });
})(NewsPage || (NewsPage = {}));
//# sourceMappingURL=app.js.map