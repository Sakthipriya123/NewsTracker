namespace NewsPage {


    angular.module('NewsPage', ['ngRoute']).config(
        (
            $routeProvider: ng.route.IRouteProvider,
            $locationProvider: ng.ILocationProvider
        ) => {
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
}