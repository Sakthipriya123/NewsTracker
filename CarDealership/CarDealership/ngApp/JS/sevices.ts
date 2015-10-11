namespace CarApp.Services {


    export class CarService {
        private carResource;
        private search1;
       
        private carMakes;
        //private selectedCar;
        //private cars;

        public listCars() {
            return this.carResource.query();
        }


       public carSearch() {

           return this.carMakes.query(); 
                    
        }

        //public Makes() {
        //    return this.carMakes.query();
        //}
            

        //change() {
        //    this.carResource.get(+ '/' + this.selectedCar.id).success((data: any) => {
        //        this.cars = data[0].cars;
        //    }).catch(() => { alert('Failure!'); });

        //}

       constructor(private carServiceUrl: string, private carMakesUrl: string,$resource: ng.resource.IResourceService) {
            this.carResource = $resource(carServiceUrl);
            this.carMakes = $resource(carMakesUrl);
        }
    }
    angular.module('CarApp').service('carService', CarService);
}