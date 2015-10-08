var MoviesApp;
(function (MoviesApp) {
    var Services;
    (function (Services) {
        var ProductService = (function () {
            function ProductService() {
            }
            ProductService.prototype.calculateTax = function (price) {
                return price * .08;
            };
            ProductService.prototype.randomQuote = function () {
                var movieName = ['Your focus determines your reality.', 'It is true that those we meet can change us, sometimes so profoundly that we are not the same afterwards, even unto our names.', 'Enough! You are, all of you are beneath me! I am a god, you dull creature, and I will not be bullied by...'];
                return movieName[Math.floor(Math.random() * movieName.length)];
            };
            return ProductService;
        })();
        Services.ProductService = ProductService;
        angular.module('MoviesApp').service('productService', ProductService);
    })(Services = MoviesApp.Services || (MoviesApp.Services = {}));
})(MoviesApp || (MoviesApp = {}));
