namespace SecretMovies.Controllers {

    const webAPIURL = 'http://MoviesWebAPIApp.azurewebsites.net/api/secretmovies';
    const authenticateURL = 'http://MoviesWebAPIApp.azurewebsites.net/Token';

    class MovieListController {

        public movies;

        constructor(private $http: ng.IHttpService) {
            $http.get(webAPIURL).success((data) => {
                this.movies = data;
            }).catch((message) => {
                alert(message);
            });
        }
    }
    angular.module('SecretMovies').controller('MovieListController', MovieListController);

    class AccountController {        username: string        password: string        loginMessage: string        login() {            let data = "grant_type=password&username=" + this.username + "&password=" + this.password;            this.$http.post(authenticateURL, data,                {                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' }                }).success((result: any) => {                    this.$window.sessionStorage.setItem('token', result.access_token);                    //this.$location.path('/');                }).error(() => {                    this.loginMessage = 'Invalid user name/password';                });        }        logout() {            this.$window.sessionStorage.removeItem('token');        }        isLoggedIn() {            return this.$window.sessionStorage.getItem('token');        }        constructor(private $http: ng.IHttpService, private $window: ng.IWindowService, private $location: ng.ILocationService) { }    }

    angular.module('SecretMovies').controller('AccountController', AccountController);
}