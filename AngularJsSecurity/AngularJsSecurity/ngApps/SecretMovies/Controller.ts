﻿namespace SecretMovies.Controllers {

    const webAPIURL = 'http://MoviesWebAPIApp.azurewebsites.net/api/secretmovies';
    const authenticateURL = 'http://MoviesWebAPIApp.azurewebsites.net/Token';

    class MovieListController {

        public movies;

        constructor(private $http: ng.IHttpService) {
            $http.get(webAPIURL).success((data) => {
                this.movies = data;
            }).catch((message) => {
                alert(message);
            });
        }
    }
    angular.module('SecretMovies').controller('MovieListController', MovieListController);

    class AccountController {

    angular.module('SecretMovies').controller('AccountController', AccountController);
}