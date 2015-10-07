namespace MoviesApp.Controllers {

    const webAPIURL = 'http://movieswebapiapp.azurewebsites.net/api/genres';


    class MoviesListController {

        public movies;
        public selectedGenre;
        public genres;

        change() {
            this.$http.get(webAPIURL + '/' + this.selectedGenre.id).success((data:any) => {
                this.movies = data[0].movies;
            }).catch(() => { alert('Failure!'); });

        }


        constructor(private $http: ng.IHttpService) {
            this.$http.get(webAPIURL).success((data) => {
                this.genres = data;
            }).catch(() => { alert('Failure!'); });

            
            //This will cause an asynchronous funcion and movies will not equal anything because the
            //server never had a chance to get the information
            //this.movies = $http.get(webAPIURL);

        }
    }

    angular.module('MoviesApp').controller('MoviesListController', MoviesListController);
}