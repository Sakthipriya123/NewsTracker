var CarApp;
(function (CarApp) {
    var HomeController = (function () {
        //public makes;       
        function HomeController(carServiceUrl, $http, carService, $modal) {
            this.carServiceUrl = carServiceUrl;
            this.$http = $http;
            this.carService = carService;
            this.$modal = $modal;
            this.cars = carService.listCars();
            //this.makes = carService.Makes();
        }
        HomeController.prototype.fetch = function () {
            if (this.search) {
                this.items = this.carService.carSearch();
            }
        };
        return HomeController;
    })();
    CarApp.HomeController = HomeController;
})(CarApp || (CarApp = {}));
//    public showModal() {
//        this.$modal.open({
//            templateUrl: '/ngApps/Views/dialog.html',
//            controller: 'DialogController',
//            controllerAs: 'modal',
//        });
//    }
//}
//export class DialogController {
//    public ok() {
//        this.$modalInstance.close();
//    }
//    constructor( private $modalInstance: angular.ui.bootstrap.IModalServiceInstance) { }
//}
//    angular.module('CarApp').controller('DialogController', DialogController);
//doSomething() {
//    this.carService.change();
//}
