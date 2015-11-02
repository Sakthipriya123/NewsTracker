var NewsPage;
(function (NewsPage) {
    var Controllers;
    (function (Controllers) {
        var fname = "";
        var HomeController = (function () {
            function HomeController($routeParams, $modal, newsServices, $location) {
                this.$routeParams = $routeParams;
                this.$modal = $modal;
                this.newsServices = newsServices;
                this.$location = $location;
                this.news = this.newsServices.listNews();
            }
            HomeController.prototype.showModal = function (id) {
                this.$modal.open({
                    templateUrl: '/ngApp/views/Details.html',
                    controller: 'DialogController',
                    controllerAs: 'modal',
                    size: 'lg',
                    resolve: {
                        newsArticleId: function () { return id; }
                    },
                });
            };
            return HomeController;
        })();
        Controllers.HomeController = HomeController;
        angular.module('NewsPage').controller('HomeController', HomeController);
        var PublishController = (function () {
            function PublishController(Upload, newsServices, $location) {
                this.Upload = Upload;
                this.newsServices = newsServices;
                this.$location = $location;
                this.loaded = 0;
                this.max = 100;
                this.categories = newsServices.getCategories();
                //this.newsServices.change(this.selectedCategory).then((data) => {
                //});
            }
            //public bar;
            //public showProgress(e) {
            //    if (e = true) {
            //        this.bar = false;
            //    }
            //}
            PublishController.prototype.save = function () {
                var _this = this;
                this.addArticle.image = "https://myimagedata.blob.core.windows.net/mycontainer/\"" + fname + "\"";
                var select = document.getElementById("sel1");
                this.addArticle.categoryId = this.categories[select.selectedIndex].id;
                this.newsServices.save(this.addArticle).then(function () {
                    _this.$location.path('/');
                });
            };
            PublishController.prototype.upload = function (file) {
                var _this = this;
                fname = file.name;
                this.Upload.upload({
                    method: 'post',
                    file: file,
                    url: '/api/upload'
                }).progress(function (result) {
                    console.log('progress...');
                    _this.loaded = result['loaded'];
                    console.log(_this.loaded);
                    _this.max = result['total'];
                    console.log(_this.max);
                }).then(function (result) {
                    console.log('File upload complete.');
                }).catch(function (result) {
                    console.error('Could not upload file!');
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
            function SingleCategoriesController(newsServices, $location, $routeParams, $modal) {
                this.newsServices = newsServices;
                this.$location = $location;
                this.$routeParams = $routeParams;
                this.$modal = $modal;
                this.scategories = this.newsServices.getCategory($routeParams['id']);
            }
            SingleCategoriesController.prototype.showModal = function (id) {
                this.$modal.open({
                    templateUrl: '/ngApp/views/Details.html',
                    controller: 'DialogController',
                    controllerAs: 'modal',
                    size: 'lg',
                    resolve: {
                        newsArticleId: function () { return id; }
                    },
                });
            };
            return SingleCategoriesController;
        })();
        Controllers.SingleCategoriesController = SingleCategoriesController;
        angular.module('NewsPage').controller('SingleCategoriesController', SingleCategoriesController);
        var DialogController = (function () {
            function DialogController(newsArticleId, newsServices, $routeParams, $modalInstance) {
                var _this = this;
                this.newsArticleId = newsArticleId;
                this.newsServices = newsServices;
                this.$routeParams = $routeParams;
                this.$modalInstance = $modalInstance;
                this.newsServices.getArticle(newsArticleId).then(function (data) {
                    _this.articleToView = data;
                });
            }
            DialogController.prototype.ok = function () {
                this.$modalInstance.close();
            };
            return DialogController;
        })();
        angular.module('NewsPage').controller('DialogController', DialogController);
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
        //class NewsDetailController {
        //    public article;
        //    public articleId;   
        //    public showModal(articleId) {
        //        this.$uibModal.open({
        //            templateUrl: '/ngApp/views/Details.html',
        //            controller: 'DialogController',
        //            controllerAs: 'modal',
        //            resolve: {
        //                newsArticleId: () => { articleId }
        //            },
        //        });
        //    }
        //    constructor(private newsServices: NewsPage.Services.NewsServices, $routeParams: ng.route.IRouteParamsService, private $location: ng.ILocationService, private $uibModal: angular.ui.bootstrap.IModalService) {
        //        this.articleId = $routeParams['id'];
        //        this.article = this.newsServices.getArticle($routeParams['id']);
        //        }
        //}
        //angular.module('NewsPage').controller('NewsDetailController', NewsDetailController);
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
