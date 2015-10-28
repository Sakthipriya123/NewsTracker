namespace MyApp.Controllers {

    export class HomeController {
     
        public auction;

        constructor(private auctionService: MyApp.Services.AuctionService) {
            this.auction = auctionService.listItems();

           }
    }

    export class BidController {

        public addBid;  

        public save() {
            this.auctionService.save(this.addBid).then(() => {
                this.$location.path("/");
               });
        }

        constructor(private auctionService: MyApp.Services.AuctionService, private $location: angular.ILocationService, private $routeParams: ng.route.IRouteParamsService) {
            this.addBid = this.auctionService.get($routeParams['id']);
            }

    }


    export class CreateController {

        public addPost;

        public save() {
            this.auctionService.save(this.addPost).then(() => {
                this.$location.path("/");


            });
        }

        constructor(private auctionService: MyApp.Services.AuctionService, private $location: angular.ILocationService) {

        }

    }

     export class AboutController {

    }
}