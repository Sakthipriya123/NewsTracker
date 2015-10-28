namespace MyApp.Services {

    export class AuctionService {
        private AuctionResource;
        private BidResource;


        public listItems() {
            return this.AuctionResource.query();
        }

        public getAuction(id: number) {
            return this.AuctionResource.get({ id: id }).$promise;
        }

        public save(item) {
            return this.AuctionResource.save(item).$promise;

        }

        public get(id: number) {
            return this.AuctionResource.get({ id: id }).$promise;
        }

        constructor($resource: angular.resource.IResourceService) {
            this.AuctionResource = $resource("/api/auction/:id");
            this.BidResource = $resource("api/bid/:id");

        }
    }
    angular.module("MyApp").service('auctionService', AuctionService);
}