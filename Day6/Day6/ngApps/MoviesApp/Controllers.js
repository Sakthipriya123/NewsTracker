var MyApp;
(function (MyApp) {
    var Controllers;
    (function (Controllers) {
        var MoviesController = (function () {
            function MoviesController() {
                this.movies = [
                    { title: 'Star Wars' },
                    { title: 'Raiders of the the Lost Ark' },
                    { title: 'King Kong' }
                ];
            }
            return MoviesController;
        })();
        angular.module('MoviesApp').controller('MoviesController', MoviesController);
    })(Controllers = MyApp.Controllers || (MyApp.Controllers = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=Controllers.js.map