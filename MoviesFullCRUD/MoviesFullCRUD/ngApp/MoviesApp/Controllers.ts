namespace MoviesApp.Controllers {

    const movieServiceUrl = 'http://MoviesWebAPIApp.azurewebsites.net/api/movies/:id';
    const authenticateURL = 'http://MoviesWebAPIApp.azurewebsites.net/Token';

    class MoviesListController {

        public movies;

        constructor(private $resource: ng.resource.IResourceService) {
            let MovieResource = $resource(movieServiceUrl);
            this.movies = MovieResource.query();
        }
    }
    angular.module('MoviesApp').controller('MoviesListController', MoviesListController);


    class MoviesAddController {

        public movieToCreate;
        public MovieResource;

        addMovie() {
            this.MovieResource.save(this.movieToCreate).$promise.then(() => {
                this.$location.path('/');
            });
        }
        constructor(private $resource: ng.resource.IResourceService, private $location: ng.ILocationService) {
            this.MovieResource = $resource(movieServiceUrl);
        }

    }

    angular.module('MoviesApp').controller('MoviesAddController', MoviesAddController);


    class MoviesDeleteController {
        public movieToDelete;
        private MovieResource;

        deleteMovie() {
            this.MovieResource.delete({ id: this.$routeParams['id'] }).$promise.then(() => {
                this.$location.path('/');
            });
        }

        constructor(private $routeParams: ng.route.IRouteParamsService, $resource: ng.resource.IResourceService, private $location: ng.ILocationService) {

            this.MovieResource = $resource(movieServiceUrl);
            this.movieToDelete = this.MovieResource.get({
                id: $routeParams['id']
            });

        }


    }

    angular.module('MoviesApp').controller('MoviesDeleteController', MoviesDeleteController);

    class MoviesEditController {

        public movieToEdit;
        private MovieResource;

        editMovie() {
            this.MovieResource.save(this.movieToEdit).$promise.then(() => {
                this.$location.path('/');
            });
        }

        constructor(private $routeParams: ng.route.IRouteParamsService, $resource: ng.resource.IResourceService, private $location: ng.ILocationService) {

            this.MovieResource = $resource(movieServiceUrl);
            this.movieToEdit = this.MovieResource.get({
                id: $routeParams['id']
            });

        }
    }

        angular.module('MoviesApp').controller('MoviesEditController', MoviesEditController);
    
        



    class AccountController {        username: string        password: string        loginMessage: string        login() {            let data = "grant_type=password&username=" + this.username + "&password=" + this.password;            this.$http.post(authenticateURL, data,                {                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' }                }).success((result: any) => {                    this.$window.sessionStorage.setItem('token', result.access_token);                    this.$location.path('/');                }).error(() => {                    this.loginMessage = 'Invalid user name/password';                });        }        logout() {            this.$window.sessionStorage.removeItem('token');        }        isLoggedIn() {            return this.$window.sessionStorage.getItem('token');        }        constructor(private $http: ng.IHttpService, private $window: ng.IWindowService, private $location: ng.ILocationService) { }    }    angular.module('MoviesApp').controller('AccountController', AccountController);


}