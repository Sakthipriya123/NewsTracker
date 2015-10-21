var NewsPage;
(function (NewsPage) {
    var Services;
    (function (Services) {
        var NewsServices = (function () {
            function NewsServices($resource) {
                this.newsResource = $resource('/api/NewsApp/:id');
            }
            NewsServices.prototype.listNews = function () {
                return this.newsResource.query();
            };
            NewsServices.prototype.getArticle = function (id) {
                return this.newsResource.get({ id: id });
            };
            return NewsServices;
        })();
        Services.NewsServices = NewsServices;
        angular.module("NewsPage").service("newsServices", NewsServices);
    })(Services = NewsPage.Services || (NewsPage.Services = {}));
})(NewsPage || (NewsPage = {}));
