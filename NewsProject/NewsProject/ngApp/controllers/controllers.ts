namespace NewsPage.Controllers {
    let fname: string = "";
  

    export class HomeController {
        public news;

        public showModal(id) {
            this.$modal.open({
                templateUrl: '/ngApp/views/Details.html',
                controller: 'DialogController',
                controllerAs: 'modal',
                size: 'lg',
                resolve: {
                    newsArticleId: () => id 

                },
            });
        }


        constructor(private $routeParams: ng.route.IRouteParamsService,private $modal: angular.ui.bootstrap.IModalService, private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService) {
            this.news =this.newsServices.listNews();
           
        }
       
    }
    angular.module('NewsPage').controller('HomeController', HomeController);


    export class PublishController {
        private addArticle;
        private categories;
        public loaded: number = 0;
        public max: number = 100;
        //public bar;
        //public showProgress(e) {
        //    if (e = true) {
        //        this.bar = false;
        //    }
        //}
        

        public save() {            
 
            this.addArticle.image = "https://myimagedata.blob.core.windows.net/mycontainer/\"" + fname + "\"";
            var select = <HTMLSelectElement>document.getElementById("sel1");
            this.addArticle.categoryId = this.categories[select.selectedIndex].id;
            this.newsServices.save(this.addArticle).then(() => {
                this.$location.path('/');
            });
        }

        public upload(file: File) {
            fname = file.name;
            this.Upload.upload({
                method: 'post',
                file: file,
                url: '/api/upload'
            }).progress((result) => {
                console.log('progress...');
                this.loaded = result['loaded'];
                console.log(this.loaded);
                this.max = result['total'];
                console.log(this.max);
            }).then((result) => {
                console.log('File upload complete.');
            }).catch((result) => {
                console.error('Could not upload file!');
            });

        }

                    
        constructor(private Upload: angular.angularFileUpload.IUploadService, private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService) {
            this.categories = newsServices.getCategories();
            //this.newsServices.change(this.selectedCategory).then((data) => {
                
                
            //});
        }


    }


    angular.module('NewsPage').controller('PublishController', PublishController);


   export class CategoriesController {
       public categories;
       private selectedCategory;

       constructor(private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService, private $routeParams: ng.route.IRouteParamsService) {
           this.categories = this.newsServices.listCategories();
           this.categories = this.newsServices.getCategory($routeParams['id']);
           
           
                  }

    }

    angular.module('NewsPage').controller('CategoriesController', CategoriesController);


    export class SingleCategoriesController {
        public scategories;
        public article

        public showModal(id: number) {
            this.$modal.open({
                templateUrl: '/ngApp/views/Details.html',
                controller: 'DialogController',
                controllerAs: 'modal',
                size:'lg',
                resolve: {
                    newsArticleId:() => id 

                },
            });
        }

        


        constructor(private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService, private $routeParams: ng.route.IRouteParamsService, private $modal: angular.ui.bootstrap.IModalService) {
            this.scategories = this.newsServices.getCategory($routeParams['id']);
           
        }

    }

    angular.module('NewsPage').controller('SingleCategoriesController', SingleCategoriesController);

    class DialogController {
        public articleToView

        public ok() {
            this.$modalInstance.close();
        }

        constructor(private newsArticleId, private newsServices: NewsPage.Services.NewsServices, private $routeParams: ng.route.IRouteParamsService, private $modalInstance: angular.ui.bootstrap.IModalServiceInstance) {
             this.newsServices.getArticle(newsArticleId).then((data) => {
                 this.articleToView = data;
            });
        }
    }

    angular.module('NewsPage').controller('DialogController', DialogController);

    class SignInController {


    }

    angular.module('NewsPage').controller('SignInController', SignInController);

    class NewsListController {



    }
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


    export class AdminController {
        public users;

        constructor
            (
            private newsServices: NewsPage.Services.NewsServices) {
            this.users = this.newsServices.listnews();
        }
    }
    
    angular.module('NewsPage').controller('AdminController', AdminController);
}