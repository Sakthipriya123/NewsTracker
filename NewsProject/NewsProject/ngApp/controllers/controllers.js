var NewsPage;
(function (NewsPage) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController(newsServices, $location) {
                this.newsServices = newsServices;
                this.$location = $location;
                this.news = newsServices.listNews();
            }
            return HomeController;
        })();
        Controllers.HomeController = HomeController;
        angular.module('NewsPage').controller('HomeController', HomeController);
        var PublishController = (function () {
            function PublishController(newsServices, $location) {
                this.newsServices = newsServices;
                this.$location = $location;
                this.categories = newsServices.getCategories();
                //this.newsServices.change(this.selectedCategory).then((data) => {
                //});
            }
            PublishController.prototype.save = function () {
                var _this = this;
                this.newsServices.save(this.addArticle).then(function () {
                    _this.$location.path('/');
                });
            };
            return PublishController;
        })();
        Controllers.PublishController = PublishController;
        angular.module('NewsPage').controller('PublishController', PublishController);
        var CategoriesController = (function () {
            function CategoriesController(newsServices, $location, $routeParams) {
                this.newsServices = newsServices;
                this.$location = $location;
                this.$routeParams = $routeParams;
                this.categories = this.newsServices.listCategories();
                this.categories = this.newsServices.getCategory($routeParams['id']);
            }
            return CategoriesController;
        })();
        Controllers.CategoriesController = CategoriesController;
        angular.module('NewsPage').controller('CategoriesController', CategoriesController);
        var SingleCategoriesController = (function () {
            function SingleCategoriesController(newsServices, $location, $routeParams) {
                this.newsServices = newsServices;
                this.$location = $location;
                this.$routeParams = $routeParams;
                this.scategories = this.newsServices.getCategory($routeParams['id']);
            }
            return SingleCategoriesController;
        })();
        Controllers.SingleCategoriesController = SingleCategoriesController;
        angular.module('NewsPage').controller('SingleCategoriesController', SingleCategoriesController);
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
            function NewsDetailController(newsServices, $routeParams, $location) {
                this.newsServices = newsServices;
                this.$location = $location;
                this.article = this.newsServices.getArticle($routeParams['id']);
            }
            return NewsDetailController;
        })();
        angular.module('NewsPage').controller('NewsDetailController', NewsDetailController);
        var AdminController = (function () {
            function AdminController(newsServices) {
                this.newsServices = newsServices;
                this.users = this.newsServices.listnews();
            }
            return AdminController;
        })();
        Controllers.AdminController = AdminController;
        angular.module('NewsPage').controller('AdminController', AdminController);
    })(Controllers = NewsPage.Controllers || (NewsPage.Controllers = {}));
})(NewsPage || (NewsPage = {}));
//# sourceMappingURL=controllers.js.map