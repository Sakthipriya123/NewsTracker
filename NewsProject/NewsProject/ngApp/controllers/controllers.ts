namespace NewsPage.Controllers {

    export class HomeController {
        public news;


        constructor(private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService) {
            this.news = newsServices.listNews();

        }
       
    }
    angular.module('NewsPage').controller('HomeController', HomeController);


    export class PublishController {
        private addArticle;
        private selectedCategory;
        private categories;

        public save() {
            this.newsServices.save(this.addArticle).then(() => {
                this.$location.path('/');
            });
        }

              
        constructor(private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService) {
            this.categories = newsServices.getCategories();
            //this.newsServices.change(this.selectedCategory).then((data) => {
                
                
            //});
        }


    }


    angular.module('NewsPage').controller('PublishController', PublishController);


   export class CategoriesController {
       public categories;

       constructor(private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService, private $routeParams: ng.route.IRouteParamsService) {

           this.categories = this.newsServices.listCategories();
           this.categories = this.newsServices.getCategory($routeParams['id']);
           
                  }

    }

    angular.module('NewsPage').controller('CategoriesController', CategoriesController);


    export class SingleCategoriesController {
        public scategories;

        constructor(private newsServices: NewsPage.Services.NewsServices, private $location: angular.ILocationService, private $routeParams: ng.route.IRouteParamsService) {
            this.scategories = this.newsServices.getCategory($routeParams['id']);
                       
        }

    }

    angular.module('NewsPage').controller('SingleCategoriesController', SingleCategoriesController);

    class SignInController {


    }

    angular.module('NewsPage').controller('SignInController', SignInController);

    class NewsListController {



    }
    angular.module('NewsPage').controller('NewsListController', NewsListController);

    class NewsDetailController {

        public article;

        constructor(private newsServices: NewsPage.Services.NewsServices, $routeParams: ng.route.IRouteParamsService, private $location: ng.ILocationService) {
            this.article = this.newsServices.getArticle($routeParams['id']);
                
            }
    }
      
    angular.module('NewsPage').controller('NewsDetailController', NewsDetailController);

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