namespace NewsPage.Controllers {

    export class HomeController {

        public news;


        constructor(private newsServices: NewsPage.Services.NewsServices, private $location: ng.ILocaleService) {
            this.news = newsServices.listNews();

        }
    }
    angular.module('NewsPage').controller('HomeController', HomeController);


    class PublishController {
        
        


    }


    angular.module('NewsPage').controller('PublishController', PublishController);


    class CatagoriesController {




    }

    angular.module('NewsPage').controller('CatagoriesController', CatagoriesController);


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
}