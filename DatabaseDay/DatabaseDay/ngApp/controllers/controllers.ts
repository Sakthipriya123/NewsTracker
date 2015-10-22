namespace MyApp.Controllers {

    export class HomeController {
        private MovieResource;
        public movies;

        constructor($resource: angular.resource.IResourceService) {
            this.MovieResource = $resource('/api/movies/:id');
            this.movies = this.MovieResource.query();
        }
    }


    export class AboutController {

    }
}