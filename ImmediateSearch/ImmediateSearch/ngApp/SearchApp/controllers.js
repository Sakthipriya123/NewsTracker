var MyApp;
(function (MyApp) {
    var Controllers;
    (function (Controllers) {
        var apiURL = 'http://CoderCamps-MoviesAPI.AzureWebSites.net/api/movies/search/';
        var FoodController = (function () {
            function FoodController($http) {
                this.$http = $http;
            }
            FoodController.prototype.fetch = function () {
                var _this = this;
                if (this.search) {
                    console.log('searching');
                    this.$http.get(apiURL + this.search)
                        .success(function (results) {
                        _this.items = results;
                    });
                }
            };
            return FoodController;
        })();
        angular.module("MyApp").controller('FoodController', FoodController);
    })(Controllers = MyApp.Controllers || (MyApp.Controllers = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=controllers.js.map