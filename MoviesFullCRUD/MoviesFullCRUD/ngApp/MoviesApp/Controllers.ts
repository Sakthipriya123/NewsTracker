namespace MoviesApp.Controllers {

    //const movieServiceUrl = 'http://MoviesWebAPIApp.azurewebsites.net/api/movies/:id';
    //const authenticateURL = 'http://MoviesWebAPIApp.azurewebsites.net/Token';

    class MoviesListController {

        public movies;
        //public taxAmount;
        //public randomQuotes;

        constructor(productService: MoviesApp.Services.ProductService, movieService: MoviesApp.Services.MovieService) {
            
            this.movies = movieService.listMovies();

            //this.taxAmount = productService.calculateTax(120000);

            //this.randomQuotes = productService.randomQuote();

        }
    }
    angular.module('MoviesApp').controller('MoviesListController', MoviesListController);


    class MoviesAddController {

        public movieToCreate;
        

        addMovie() {
            this.movieService.save(this.movieToCreate).then(() => {
                this.$location.path('/');
            });
        }
        constructor(private movieService: MoviesApp.Services.MovieService, private $location: ng.ILocationService) {
            
        }

    }

    angular.module('MoviesApp').controller('MoviesAddController', MoviesAddController);


    class MoviesDeleteController {
        public movieToDelete;
        deleteMovie(){
            this.movieService.deleteMovie(this.movieToDelete.id).then(() => {
                this.$location.path('/');
            });
        }

        constructor(
            private movieService: MoviesApp.Services.MovieService,
            private $location: ng.ILocationService,
            private $routeParams: ng.route.IRouteParamsService) {

           this.movieToDelete = this.movieService.getMovie($routeParams['id']);
        
        }

    }

    angular.module('MoviesApp').controller('MoviesDeleteController', MoviesDeleteController);

    class MoviesEditController {

        public movieToEdit;
        

        editMovie() {
            this.movieService.save(this.movieToEdit).then(() => {
                this.$location.path('/');
            });
        }

        constructor(private $routeParams: ng.route.IRouteParamsService, private movieService: MoviesApp.Services.MovieService, private $location: ng.ILocationService, movieServiceUrl: string) {


            this.movieToEdit = this.movieService.getMovie($routeParams['id']);
               

        }
    }

        angular.module('MoviesApp').controller('MoviesEditController', MoviesEditController);
  


    class AccountController {
        username: string
        password: string
        loginMessage: string
        login() {
            let data = "grant_type=password&username=" + this.username + "&password=" + this.password;
            this.$http.post(this.authenticateURL, data,
                {
                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                }).success((result: any) => {
                    this.$window.sessionStorage.setItem('token', result.access_token);
                    this.$location.path('/');
                }).error(() => {
                    this.loginMessage = 'Invalid user name/password';
                });
        }
        logout() {
            this.$window.sessionStorage.removeItem('token');
        }
        isLoggedIn() {
            return this.$window.sessionStorage.getItem('token');
        }
        constructor(private authenticateURL: string,private $http: ng.IHttpService, private $window: ng.IWindowService, private $location: ng.ILocationService) { }
    }
    angular.module('MoviesApp').controller('AccountController', AccountController);


}