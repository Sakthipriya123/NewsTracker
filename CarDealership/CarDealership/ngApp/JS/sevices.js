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
            function CarService(carServiceUrl, carMakesUrl, $resource) {
                this.carServiceUrl = carServiceUrl;
                this.carMakesUrl = carMakesUrl;
                this.carResource = $resource(carServiceUrl);
                this.carMakes = $resource(carMakesUrl);
            }
            //private selectedCar;
            //private cars;
            CarService.prototype.listCars = function () {
                return this.carResource.query();
            };
            CarService.prototype.carSearch = function () {
                return this.carMakes.query();
            };
            return CarService;
        })();
        Services.CarService = CarService;
        angular.module('CarApp').service('carService', CarService);
    })(Services = CarApp.Services || (CarApp.Services = {}));
})(CarApp || (CarApp = {}));
//# sourceMappingURL=sevices.js.map