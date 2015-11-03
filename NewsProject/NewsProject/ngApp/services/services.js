var NewsPage;
(function (NewsPage) {
    var Services;
    (function (Services) {
        var NewsServices = (function () {
            function NewsServices($resource) {
                this.newsResource = $resource('/api/newsapp/:id');
                this.categoryResource = $resource('/api/categories/:id');
                this.adminResource = $resource('/api/admin/:id');
            }
            NewsServices.prototype.listNews = function () {
                return this.newsResource.query();
            };
            NewsServices.prototype.listCategories = function () {
                return this.categoryResource.query();
            };
            NewsServices.prototype.save = function (news) {
                return this.newsResource.save(news).$promise;
            };
            NewsServices.prototype.getArticle = function (id) {
                return this.newsResource.get({ id: id }).$promise;
            };
            NewsServices.prototype.getCategories = function () {
                return this.categoryResource.query();
            };
            NewsServices.prototype.getCategory = function (id) {
                return this.categoryResource.get({ id: id });
            };
            NewsServices.prototype.listnews = function () {
                return this.adminResource.query();
            };
            return NewsServices;
        })();
        Services.NewsServices = NewsServices;
        angular.module("NewsPage").service("newsServices", NewsServices);
        var CommentService = (function () {
            function CommentService($resource) {
                this.commentResource = $resource('/api/comments');
            }
            CommentService.prototype.save = function (comment) {
                return this.commentResource.save(comment).$promise;
            };
            CommentService.prototype.getComment = function (id) {
                return this.commentResource.get({ id: id }).$promise;
            };
            return CommentService;
        })();
        Services.CommentService = CommentService;
        angular.module("NewsPage").service("commentService", CommentService);
    })(Services = NewsPage.Services || (NewsPage.Services = {}));
})(NewsPage || (NewsPage = {}));
//# sourceMappingURL=services.js.map