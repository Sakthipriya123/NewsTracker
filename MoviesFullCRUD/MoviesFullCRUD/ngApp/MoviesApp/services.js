var MoviesApp;
(function (MoviesApp) {
    var Services;
    (function (Services) {
        var MovieService = (function () {
            function MovieService(movieServiceUrl, $resource) {
                this.MovieResource = $resource(movieServiceUrl);
            }
            MovieService.prototype.listMovies = function () {
                return this.MovieResource.query();
            };
            MovieService.prototype.save = function (movie) {
                return this.MovieResource.save(movie).$promise;
            };
            MovieService.prototype.getMovie = function (id) {
                return this.MovieResource.get({ id: id });
            };
            MovieService.prototype.deleteMovie = function (id) {
                return this.MovieResource.delete({ id: id }).$promise;
            };
            return MovieService;
        })();
        Services.MovieService = MovieService;
        angular.module('MoviesApp').service('movieService', MovieService);
        var ProductService = (function () {
            function ProductService() {
            }
            ProductService.prototype.calculateTax = function (price) {
                return price * .08;
            };
            ProductService.prototype.randomQuote = function () {
                var movieQuote = ['Your focus determines your reality.', 'It is true that those we meet can change us, sometimes so profoundly that we are not the same afterwards, even unto our names.', 'Enough! You are, all of you are beneath me! I am a god, you dull creature, and I will not be bullied by...'];
                return movieQuote[Math.floor(Math.random() * movieQuote.length)];
            };
            return ProductService;
        })();
        Services.ProductService = ProductService;
        angular.module('MoviesApp').service('productService', ProductService);
    })(Services = MoviesApp.Services || (MoviesApp.Services = {}));
})(MoviesApp || (MoviesApp = {}));
//# sourceMappingURL=services.js.map