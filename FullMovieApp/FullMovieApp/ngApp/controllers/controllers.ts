namespace MyApp.Controllers {

    export class HomeController {

        public movies;

        constructor(private movieServices: MyApp.Services.MovieServices, private $location: ng.ILocationService) {

            this.movies = movieServices.listMovies();
        }

    }

    angular.module("MyApp").controller("HomeController", HomeController);


    export class AddNewMovieController {

        public moviesToCreate;
        public validationErrors;

        addMovie() {
            if (this.moviesToCreate) {
                this.movieServices.saveMovies(this.moviesToCreate).then(() => {
                    this.$location.path('/');
                }).catch((results) => {
                    let errors = [];
                    for (let prop in results.data.modelState) {
                        errors = errors.concat(results.data.modelState[prop]);

                    }
                    this.validationErrors = errors;
                });
            }
        }
        constructor(private movieServices: MyApp.Services.MovieServices, private $location: ng.ILocationService) {

        }


    }

    angular.module("MyApp").controller("AddNewMovieController", AddNewMovieController);


    export class DeleteMovieController {
        public moviesToDelete;

        deleteMovie() {
            this.movieServices.deleteMovie(this.moviesToDelete.id).then(() => {
                this.$location.path('/');

            });
        }

        constructor(private $routeParams: ng.route.IRouteParamsService,private movieServices: MyApp.Services.MovieServices, private $location: ng.ILocationService) {
            this.moviesToDelete = this.movieServices.getMovie($routeParams['id']);
        }

    }

    angular.module("MyApp").controller("DeleteMovieController", DeleteMovieController);




    export class EditMovieController {

        public movieToEdit;

        editMovie() {
            this.movieServices.save(this.movieToEdit).then(() => {
                this.$location.path('/');

            });
        }

        constructor(private $routeParams: ng.route.IRouteParamsService,private movieServices: MyApp.Services.MovieServices, private $location: ng.ILocationService) {

            this.movieToEdit = this.movieServices.getMovie($routeParams['id']);

        }

    }

    angular.module("MyApp").controller("DeleteMovieController", DeleteMovieController);
}

