﻿namespace MyApp.Controllers {

    export class HomeController {
        public movies;

        constructor
        (
            private movieService: MyApp.Services.MovieService,
            private $location: angular.ILocationService
        ) {
            this.movies = this.movieService.listMovies();
        }
    }

    export class  AdminController {
        public users;

        constructor
            (
            private movieService: MyApp.Services.MovieService) {
            this.users = this.movieService.listUsers();
        }
    }



    export class AboutController {

    }
}