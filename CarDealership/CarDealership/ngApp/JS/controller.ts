namespace CarApp {

    export class HomeController {

        public cars;
        //public makes;

        constructor(private carService: CarApp.Services.CarService, private $modal: angular.ui.bootstrap.IModalService) {

            this.cars = carService.listCars();
            //this.makes = carService.Makes();

        }


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
    
}


