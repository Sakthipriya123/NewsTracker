namespace CarApp {

    export class HomeController {

        public cars;
        public search: string;
        public items;
        
        //public makes;       

        constructor(private carServiceUrl: string, private $http: ng.IHttpService, private carService: CarApp.Services.CarService, private $modal: angular.ui.bootstrap.IModalService) {

            this.cars = carService.listCars();
                 //this.makes = carService.Makes();
           
        }

        public fetch() {
            if (this.search) {
                this.items = this.carService.carSearch();
            }
        }
        

        
    }
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
    
    


