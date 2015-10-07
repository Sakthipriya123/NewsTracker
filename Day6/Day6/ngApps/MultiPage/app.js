var MultiPage;
(function (MultiPage) {
    angular.module('MultiPage', ['ngRoute']).config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
            templateUrl: '/ngApps/MultiPage/HomePage.html',
            controller: 'HomeController as vm'
        })
            .when('/HomePage', {
            templateUrl: '/ngApps/MultiPage/HomePage.html',
            controller: 'HomeController as vm'
        })
            .when('/Product', {
            templateUrl: '/ngApps/MultiPage/Product.html',
            controller: 'ProductController as vm'
        })
            .otherwise('/');
        $locationProvider.html5Mode(true);
    });
})(MultiPage || (MultiPage = {}));
//# sourceMappingURL=app.js.map