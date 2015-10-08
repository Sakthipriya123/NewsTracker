var SecretMovies;
(function (SecretMovies) {
    var Controllers;
    (function (Controllers) {
        var webAPIURL = 'http://MoviesWebAPIApp.azurewebsites.net/api/secretmovies';
        var authenticateURL = 'http://MoviesWebAPIApp.azurewebsites.net/Token';
        var MovieListController = (function () {
            function MovieListController($http) {
                var _this = this;
                this.$http = $http;
                $http.get(webAPIURL).success(function (data) {
                    _this.movies = data;
                }).catch(function (message) {
                    alert(message);
                });
            }
            return MovieListController;
        })();
        angular.module('SecretMovies').controller('MovieListController', MovieListController);
        var AccountController = (function () {
            function AccountController($http, $window, $location) {
                this.$http = $http;
                this.$window = $window;
                this.$location = $location;
            }
            AccountController.prototype.login = function () {
                var _this = this;
                var data = "grant_type=password&username=" + this.username + "&password=" + this.password;
                this.$http.post(authenticateURL, data, {
                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                }).success(function (result) {
                    _this.$window.sessionStorage.setItem('token', result.access_token);
                    //this.$location.path('/');
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
        angular.module('SecretMovies').controller('AccountController', AccountController);
    })(Controllers = SecretMovies.Controllers || (SecretMovies.Controllers = {}));
})(SecretMovies || (SecretMovies = {}));
//# sourceMappingURL=Controller.js.map