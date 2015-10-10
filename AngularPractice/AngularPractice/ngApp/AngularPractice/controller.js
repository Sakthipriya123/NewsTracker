var MyApp;
(function (MyApp) {
    var HomeController = (function () {
        //constructor() {
        //    this.name = "Super Cool";
        //}
        function HomeController($http) {
            this.$http = $http;
            this.name = "Super Cool";
        }
        HomeController.prototype.getCars = function () {
            var _this = this;
            this.$http.get("http://codercamps-cardealershipapi.azurewebsites.net/api/cars").success(function (movies) {
                _this.cars = movies;
            }).error(function (error) {
            });
        };
        return HomeController;
    })();
    MyApp.HomeController = HomeController;
    var CarsController = (function () {
        function CarsController() {
        }
        return CarsController;
    })();
    MyApp.CarsController = CarsController;
})(MyApp || (MyApp = {}));
