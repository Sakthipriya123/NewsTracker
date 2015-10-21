namespace MyApp.Services {

    export class MovieServices {
        private MovieResource;
        public movie;

        public listMovies() {

            return this.MovieResource.query();
        }

        public saveMovies(movie) {

            return this.MovieResource.save(movie).$promise;
        }

        public deleteMovie(id: number) {

            return this.MovieResource.delete({ id: id }); 
        }

        public getMovie(id: number) {
            return this.MovieResource.get({ id: id });
        }

        public save(movie) {
            return this.MovieResource.save(movie).$promise;
        }

        constructor($resource: angular.resource.IResourceService) {
            this.MovieResource = $resource('/api/movies/:id');
            
        }
        

    }

    angular.module("MyApp").service("movieServices", MovieServices);

}