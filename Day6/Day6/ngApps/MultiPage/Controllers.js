var MultiPage;
(function (MultiPage) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController() {
            }
            return HomeController;
        })();
        angular.module('MultiPage').controller('HomeController', HomeController);
        var ProductController = (function () {
            function ProductController() {
                this.products = [
                    { name: 'Red and Light Beige Art Silk', src: 'http://img5.utsavfashion.com/lbf/lbf1/lbf1-thumbnail.jpg', price: "$140" },
                    { name: 'Red and Cream Faux Georgette', src: 'http://img6.utsavfashion.com/sxz/sxz2306/sxz2306-thumbnail.jpg', price: "$150" },
                    { name: 'Fuchsia and Blue Net Lehenga Style Saree', src: 'http://img5.utsavfashion.com/sga/sga5813/sga5813-thumbnail.jpg', price: "$110" },
                    { name: 'Red Georgette', src: 'http://img7.utsavfashion.com/lxw/lxw88/lxw88-thumbnail.jpg', price: "$150" },
                    { name: 'Beige and Pink Art Silk', src: 'http://img7.utsavfashion.com/skk/skk21487/skk21487-thumbnail.jpg', price: "$210" },
                    { name: 'Fuchsia Art Banarasi Silk', src: 'http://img7.utsavfashion.com/sspa/sspa177/sspa177-thumbnail.jpg', price: "$270" },
                ];
            }
            ProductController.prototype.addCart = function () {
                return this.products;
            };
            return ProductController;
        })();
        angular.module('MultiPage').controller('ProductController', ProductController);
    })(Controllers = MultiPage.Controllers || (MultiPage.Controllers = {}));
})(MultiPage || (MultiPage = {}));
//# sourceMappingURL=Controllers.js.map