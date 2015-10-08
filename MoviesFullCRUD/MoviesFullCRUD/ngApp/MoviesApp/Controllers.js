var MoviesApp;
(function (MoviesApp) {
    var Controllers;
    (function (Controllers) {
        //const movieServiceUrl = 'http://MoviesWebAPIApp.azurewebsites.net/api/movies/:id';
        //const authenticateURL = 'http://MoviesWebAPIApp.azurewebsites.net/Token';
        var MoviesListController = (function () {
            //public taxAmount;
            //public randomQuotes;
            function MoviesListController(productService, movieService) {
                this.movies = movieService.listMovies();
                //this.taxAmount = productService.calculateTax(120000);
                //this.randomQuotes = productService.randomQuote();
            }
            return MoviesListController;
        })();
        angular.module('MoviesApp').controller('MoviesListController', MoviesListController);
        var MoviesAddController = (function () {
            function MoviesAddController(movieService, $location) {
                this.movieService = movieService;
                this.$location = $location;
            }
            MoviesAddController.prototype.addMovie = function () {
                var _this = this;
                this.movieService.save(this.movieToCreate).then(function () {
                    _this.$location.path('/');
                });
            };
            return MoviesAddController;
        })();
        angular.module('MoviesApp').controller('MoviesAddController', MoviesAddController);
        var MoviesDeleteController = (function () {
            function MoviesDeleteController(movieService, $location, $routeParams) {
                this.movieService = movieService;
                this.$location = $location;
                this.$routeParams = $routeParams;
                this.movieToDelete = this.movieService.getMovie($routeParams['id']);
            }
            MoviesDeleteController.prototype.deleteMovie = function () {
                var _this = this;
                this.movieService.deleteMovie(this.movieToDelete.id).then(function () {
                    _this.$location.path('/');
                });
            };
            return MoviesDeleteController;
        })();
        angular.module('MoviesApp').controller('MoviesDeleteController', MoviesDeleteController);
        var MoviesEditController = (function () {
            function MoviesEditController($routeParams, movieService, $location, movieServiceUrl) {
                this.$routeParams = $routeParams;
                this.movieService = movieService;
                this.$location = $location;
                this.movieToEdit = this.movieService.getMovie($routeParams['id']);
            }
            MoviesEditController.prototype.editMovie = function () {
                var _this = this;
                this.movieService.save(this.movieToEdit).then(function () {
                    _this.$location.path('/');
                });
            };
            return MoviesEditController;
        })();
        angular.module('MoviesApp').controller('MoviesEditController', MoviesEditController);
        var AccountController = (function () {
            function AccountController(authenticateURL, $http, $window, $location) {
                this.authenticateURL = authenticateURL;
                this.$http = $http;
                this.$window = $window;
                this.$location = $location;
            }
            AccountController.prototype.login = function () {
                var _this = this;
                var data = "grant_type=password&username=" + this.username + "&password=" + this.password;
                this.$http.post(this.authenticateURL, data, {
                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                }).success(function (result) {
                    _this.$window.sessionStorage.setItem('token', result.access_token);
                    _this.$location.path('/');
                }).error(function () {
                    _this.loginMessage = 'Invalid user name/password';
                });
            };
            AccountController.prototype.logout = function () {
                this.$window.sessionStorage.removeItem('token');
            };
            AccountController.prototype.isLoggedIn = function () {
                return this.$window.sessionStorage.getItem('token');
            };
            return AccountController;
        })();
        angular.module('MoviesApp').controller('AccountController', AccountController);
    })(Controllers = MoviesApp.Controllers || (MoviesApp.Controllers = {}));
})(MoviesApp || (MoviesApp = {}));
//# sourceMappingURL=Controllers.js.map