var MyApp;
(function (MyApp) {
    var Services;
    (function (Services) {
        var MovieServices = (function () {
            function MovieServices($resource) {
                this.MovieResource = $resource('/api/movies/:id');
            }
            MovieServices.prototype.listMovies = function () {
                return this.MovieResource.query();
            };
            MovieServices.prototype.saveMovies = function (movie) {
                return this.MovieResource.save(movie).$promise;
            };
            MovieServices.prototype.deleteMovie = function (id) {
                return this.MovieResource.delete({ id: id });
            };
            MovieServices.prototype.getMovie = function (id) {
                return this.MovieResource.get({ id: id });
            };
            MovieServices.prototype.save = function (movie) {
                return this.MovieResource.save(movie).$promise;
            };
            return MovieServices;
        })();
        Services.MovieServices = MovieServices;
        angular.module("MyApp").service("movieServices", MovieServices);
    })(Services = MyApp.Services || (MyApp.Services = {}));
})(MyApp || (MyApp = {}));
