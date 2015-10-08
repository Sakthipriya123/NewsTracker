namespace NewsPage.Controllers {
    class HomeController {


    }

    angular.module('NewsPage').controller('HomeController', HomeController);

    class PublishController {

        products;

        constructor() {

            this.products = [

                { name: 'Red and Light Beige Art Silk', src: 'http://img5.utsavfashion.com/lbf/lbf1/lbf1-thumbnail.jpg', price: "$140" },
                { name: 'Red and Cream Faux Georgette', src: 'http://img6.utsavfashion.com/sxz/sxz2306/sxz2306-thumbnail.jpg', price: "$150" },
                { name: 'Fuchsia and Blue Net Lehenga Style Saree', src: 'http://img5.utsavfashion.com/sga/sga5813/sga5813-thumbnail.jpg', price: "$110" },
                { name: 'Red Georgette', src: 'http://img7.utsavfashion.com/lxw/lxw88/lxw88-thumbnail.jpg', price: "$150" },
                { name: 'Beige and Pink Art Silk', src: 'http://img7.utsavfashion.com/skk/skk21487/skk21487-thumbnail.jpg', price: "$210" },
                { name: 'Fuchsia Art Banarasi Silk', src: 'http://img7.utsavfashion.com/sspa/sspa177/sspa177-thumbnail.jpg', price: "$270" },
            ];



        }

        addCart() {
            return this.products;

        }


    }


    angular.module('NewsPage').controller('PublishController', PublishController);


    class CatagoriesController {


    }

    angular.module('NewsPage').controller('CatagoriesController', CatagoriesController);


    class SignInController {


    }

    angular.module('NewsPage').controller('SignInController', SignInController);

    class NewsListController {

            public news;

            constructor(private $http: ng.IHttpService) {
                $http.get('ngAPP/NewsApp/Products.json').success((data : any) => {
                    this.news = data;
                }).catch((message) => {
                    alert(message);
                });
            }
        }
    angular.module('NewsPage').controller('NewsListController', NewsListController);

    class NewsDetailController {

        public article;

        constructor(private $http: ng.IHttpService, $routeParams: ng.route.IRouteParamsService) {
            $http.get('ngAPP/NewsApp/Products.json').success((data: any) => {
                this.article = data.filter((item) => {
                    return item.ID == $routeParams["id"];
                })[0];
            }).catch((message) => {
                alert(message);
            });
        }
    }
    angular.module('NewsPage').controller('NewsDetailController', NewsDetailController);
}