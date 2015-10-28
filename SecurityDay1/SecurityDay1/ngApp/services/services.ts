namespace MyApp.Services {

    export class MovieService {
        private MovieResource;
        private adminResource;


        public listMovies() {
            return this.MovieResource.query();
        }

        public listUsers() {
            return this.adminResource.query();
        }

        constructor($resource: angular.resource.IResourceService) {
            this.MovieResource = $resource('/api/movies/:id');
            this.adminResource = $resource('/api/admin/:id');

        }
    }

    angular.module('MyApp').service('movieService', MovieService);

}