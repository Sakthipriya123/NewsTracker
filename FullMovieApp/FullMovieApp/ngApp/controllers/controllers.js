var MyApp;
(function (MyApp) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController(movieServices, $location) {
                this.movieServices = movieServices;
                this.$location = $location;
                this.movies = movieServices.listMovies();
            }
            return HomeController;
        })();
        Controllers.HomeController = HomeController;
        angular.module("MyApp").controller("HomeController", HomeController);
        var AddNewMovieController = (function () {
            function AddNewMovieController(movieServices, $location) {
                this.movieServices = movieServices;
                this.$location = $location;
            }
            AddNewMovieController.prototype.addMovie = function () {
                var _this = this;
                if (this.moviesToCreate) {
                    this.movieServices.saveMovies(this.moviesToCreate).then(function () {
                        _this.$location.path('/');
                    }).catch(function (results) {
                        var errors = [];
                        for (var prop in results.data.modelState) {
                            errors = errors.concat(results.data.modelState[prop]);
                        }
                        _this.validationErrors = errors;
                    });
                }
            };
            return AddNewMovieController;
        })();
        Controllers.AddNewMovieController = AddNewMovieController;
        angular.module("MyApp").controller("AddNewMovieController", AddNewMovieController);
        var DeleteMovieController = (function () {
            function DeleteMovieController($routeParams, movieServices, $location) {
                this.$routeParams = $routeParams;
                this.movieServices = movieServices;
                this.$location = $location;
                this.moviesToDelete = this.movieServices.getMovie($routeParams['id']);
            }
            DeleteMovieController.prototype.deleteMovie = function () {
                var _this = this;
                this.movieServices.deleteMovie(this.moviesToDelete.id).then(function () {
                    _this.$location.path('/');
                });
            };
            return DeleteMovieController;
        })();
        Controllers.DeleteMovieController = DeleteMovieController;
        angular.module("MyApp").controller("DeleteMovieController", DeleteMovieController);
        var EditMovieController = (function () {
            function EditMovieController($routeParams, movieServices, $location) {
                this.$routeParams = $routeParams;
                this.movieServices = movieServices;
                this.$location = $location;
                this.movieToEdit = this.movieServices.getMovie($routeParams['id']);
            }
            EditMovieController.prototype.editMovie = function () {
                var _this = this;
                this.movieServices.save(this.movieToEdit).then(function () {
                    _this.$location.path('/');
                });
            };
            return EditMovieController;
        })();
        Controllers.EditMovieController = EditMovieController;
        angular.module("MyApp").controller("DeleteMovieController", DeleteMovieController);
    })(Controllers = MyApp.Controllers || (MyApp.Controllers = {}));
})(MyApp || (MyApp = {}));
