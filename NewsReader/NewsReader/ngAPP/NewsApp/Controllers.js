var NewsPage;
(function (NewsPage) {
    var Controllers;
    (function (Controllers) {
        var HomePageImage = (function () {
            function HomePageImage($http) {
                var _this = this;
                this.$http = $http;
                $http.get('ngAPP/NewsApp/Products.json').success(function (data) {
                    _this.news = data;
                }).catch(function (message) {
                    alert(message);
                });
            }
            return HomePageImage;
        })();
        angular.module('NewsPage').controller('HomeController', HomePageImage);
        var PublishController = (function () {
            function PublishController() {
                this.products = [
                    { name: 'Red and Light Beige Art Silk', src: 'http://img5.utsavfashion.com/lbf/lbf1/lbf1-thumbnail.jpg', price: "$140" },
                    { name: 'Red and Cream Faux Georgette', src: 'http://img6.utsavfashion.com/sxz/sxz2306/sxz2306-thumbnail.jpg', price: "$150" },
                    { name: 'Fuchsia and Blue Net Lehenga Style Saree', src: 'http://img5.utsavfashion.com/sga/sga5813/sga5813-thumbnail.jpg', price: "$110" },
                    { name: 'Red Georgette', src: 'http://img7.utsavfashion.com/lxw/lxw88/lxw88-thumbnail.jpg', price: "$150" },
                    { name: 'Beige and Pink Art Silk', src: 'http://img7.utsavfashion.com/skk/skk21487/skk21487-thumbnail.jpg', price: "$210" },
                    { name: 'Fuchsia Art Banarasi Silk', src: 'http://img7.utsavfashion.com/sspa/sspa177/sspa177-thumbnail.jpg', price: "$270" },
                ];
            }
            PublishController.prototype.addCart = function () {
                return this.products;
            };
            return PublishController;
        })();
        angular.module('NewsPage').controller('PublishController', PublishController);
        var CatagoriesController = (function () {
            function CatagoriesController() {
            }
            return CatagoriesController;
        })();
        angular.module('NewsPage').controller('CatagoriesController', CatagoriesController);
        var SignInController = (function () {
            function SignInController() {
            }
            return SignInController;
        })();
        angular.module('NewsPage').controller('SignInController', SignInController);
        var NewsListController = (function () {
            function NewsListController() {
            }
            return NewsListController;
        })();
        angular.module('NewsPage').controller('NewsListController', NewsListController);
        var NewsDetailController = (function () {
            function NewsDetailController($http, $routeParams) {
                var _this = this;
                this.$http = $http;
                $http.get('ngAPP/NewsApp/Products.json').success(function (data) {
                    _this.article = data.filter(function (item) {
                        return item.ID == $routeParams["id"];
                    })[0];
                }).catch(function (message) {
                    alert(message);
                });
            }
            return NewsDetailController;
        })();
        angular.module('NewsPage').controller('NewsDetailController', NewsDetailController);
    })(Controllers = NewsPage.Controllers || (NewsPage.Controllers = {}));
})(NewsPage || (NewsPage = {}));
//# sourceMappingURL=Controllers.js.map