var MyApp;
(function (MyApp) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController(auctionService) {
                this.auctionService = auctionService;
                this.auction = auctionService.listItems();
            }
            return HomeController;
        })();
        Controllers.HomeController = HomeController;
        var BidController = (function () {
            function BidController(auctionService, $location, $routeParams) {
                this.auctionService = auctionService;
                this.$location = $location;
                this.$routeParams = $routeParams;
                this.addBid = this.auctionService.get($routeParams['id']);
            }
            BidController.prototype.save = function () {
                var _this = this;
                this.auctionService.save(this.addBid).then(function () {
                    _this.$location.path("/");
                });
            };
            return BidController;
        })();
        Controllers.BidController = BidController;
        var CreateController = (function () {
            function CreateController(auctionService, $location) {
                this.auctionService = auctionService;
                this.$location = $location;
            }
            CreateController.prototype.save = function () {
                var _this = this;
                this.auctionService.save(this.addPost).then(function () {
                    _this.$location.path("/");
                });
            };
            return CreateController;
        })();
        Controllers.CreateController = CreateController;
        var AboutController = (function () {
            function AboutController() {
            }
            return AboutController;
        })();
        Controllers.AboutController = AboutController;
    })(Controllers = MyApp.Controllers || (MyApp.Controllers = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=controllers.js.map