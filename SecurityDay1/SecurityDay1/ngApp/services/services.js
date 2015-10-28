var MyApp;
(function (MyApp) {
    var Services;
    (function (Services) {
        var MovieService = (function () {
            function MovieService($resource) {
                this.MovieResource = $resource('/api/movies/:id');
                this.adminResource = $resource('/api/admin/:id');
            }
            MovieService.prototype.listMovies = function () {
                return this.MovieResource.query();
            };
            MovieService.prototype.listUsers = function () {
                return this.adminResource.query();
            };
            return MovieService;
        })();
        Services.MovieService = MovieService;
        angular.module('MyApp').service('movieService', MovieService);
    })(Services = MyApp.Services || (MyApp.Services = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=services.js.map