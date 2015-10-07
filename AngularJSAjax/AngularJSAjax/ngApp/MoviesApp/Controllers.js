var MoviesApp;
(function (MoviesApp) {
    var Controllers;
    (function (Controllers) {
        var webAPIURL = 'http://movieswebapiapp.azurewebsites.net/api/genres';
        var MoviesListController = (function () {
            function MoviesListController($http) {
                var _this = this;
                this.$http = $http;
                this.$http.get(webAPIURL).success(function (data) {
                    _this.genres = data;
                }).catch(function () { alert('Failure!'); });
                //This will cause an asynchronous funcion and movies will not equal anything because the
                //server never had a chance to get the information
                //this.movies = $http.get(webAPIURL);
            }
            MoviesListController.prototype.change = function () {
                var _this = this;
                this.$http.get(webAPIURL + '/' + this.selectedGenre.id).success(function (data) {
                    _this.movies = data[0].movies;
                }).catch(function () { alert('Failure!'); });
            };
            return MoviesListController;
        })();
        angular.module('MoviesApp').controller('MoviesListController', MoviesListController);
    })(Controllers = MoviesApp.Controllers || (MoviesApp.Controllers = {}));
})(MoviesApp || (MoviesApp = {}));
