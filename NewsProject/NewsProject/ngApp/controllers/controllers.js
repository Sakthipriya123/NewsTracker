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
            function PublishController() {
            }
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
            function NewsDetailController(newsServices, $routeParams, $location) {
                this.newsServices = newsServices;
                this.$location = $location;
                this.article = this.newsServices.getArticle($routeParams['id']);
            }
            return NewsDetailController;
        })();
        angular.module('NewsPage').controller('NewsDetailController', NewsDetailController);
    })(Controllers = NewsPage.Controllers || (NewsPage.Controllers = {}));
})(NewsPage || (NewsPage = {}));
//# sourceMappingURL=controllers.js.map