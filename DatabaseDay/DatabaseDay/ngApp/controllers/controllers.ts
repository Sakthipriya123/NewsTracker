namespace MyApp.Controllers {

    export class HomeController {
       
        public movies;


        constructor(movieService: MyApp.Services.MovieService) {
            this.movies = movieService.listMovies();
        }
       
    }


    

    export class AddController {
        private addMovies;


        public save() {
            this.movieService.save(this.addMovies).then(() => {

                this.$location.path('/');

            });
        }



        constructor(private movieService: MyApp.Services.MovieService, private $location: angular.ILocationService) {




        }


    }


    export class  EditController {


        private movieToEdit;


        public save() {
            this.movieService.save(this.movieToEdit).then(() => {

                this.$location.path('/');

            });
        }



        constructor(private movieService: MyApp.Services.MovieService, private $location: angular.ILocationService, $routeParams: angular.route.IRouteParamsService) {
            this.movieToEdit = this.movieService.get($routeParams['id']);
        }


    }


    export class DeleteController {


        private movieToDelete;
        
        public remove() {
            this.movieService.remove(this.movieToDelete.id).then(() => {
                this.$location.path('/');
            });
        }


       constructor(private movieService: MyApp.Services.MovieService, private $location: angular.ILocationService, $routeParams: angular.route.IRouteParamsService) {
            this.movieToDelete = this.movieService.get($routeParams['id']);
        }
    }


        export class AboutController {

    }
}