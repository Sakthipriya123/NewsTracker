var MyApp;
(function (MyApp) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController(movieService, $location) {
                this.movieService = movieService;
                this.$location = $location;
                this.movies = this.movieService.listMovies();
            }
            return HomeController;
        })();
        Controllers.HomeController = HomeController;
        var AdminController = (function () {
            function AdminController(movieService) {
                this.movieService = movieService;
                this.users = this.movieService.listUsers();
            }
            return AdminController;
        })();
        Controllers.AdminController = AdminController;
        var AboutController = (function () {
            function AboutController() {
            }
            return AboutController;
        })();
        Controllers.AboutController = AboutController;
    })(Controllers = MyApp.Controllers || (MyApp.Controllers = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=controllers.js.map