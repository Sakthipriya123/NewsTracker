var CarApp;
(function (CarApp) {
    var Services;
    (function (Services) {
        var CarService = (function () {
            //public Makes() {
            //    return this.carMakes.query();
            //}
            //change() {
            //    this.carResource.get(+ '/' + this.selectedCar.id).success((data: any) => {
            //        this.cars = data[0].cars;
            //    }).catch(() => { alert('Failure!'); });
            //}
            function CarService(carServiceUrl, $resource) {
                this.carResource = $resource(carServiceUrl);
                //this.carMakes = $resource(carMakesUrl);
            }
            //private carMakes;
            //private selectedCar;
            //private cars;
            CarService.prototype.listCars = function () {
                return this.carResource.query();
            };
            return CarService;
        })();
        Services.CarService = CarService;
        angular.module('CarApp').service('carService', CarService);
    })(Services = CarApp.Services || (CarApp.Services = {}));
})(CarApp || (CarApp = {}));
