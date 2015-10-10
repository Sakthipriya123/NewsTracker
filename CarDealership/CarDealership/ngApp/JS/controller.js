var CarApp;
(function (CarApp) {
    var HomeController = (function () {
        //public makes;
        function HomeController(carService, $modal) {
            this.carService = carService;
            this.$modal = $modal;
            this.cars = carService.listCars();
            //this.makes = carService.Makes();
        }
        return HomeController;
    })();
    CarApp.HomeController = HomeController;
})(CarApp || (CarApp = {}));
