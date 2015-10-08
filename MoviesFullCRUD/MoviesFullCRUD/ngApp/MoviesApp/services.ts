namespace MoviesApp.Services {


    export class MovieService {
        private MovieResource;

        public listMovies() {
            return this.MovieResource.query();
        }

        public save(movie) {
            return this.MovieResource.save(movie).$promise;
        }

        public getMovie(id) {
            return this.MovieResource.get({id:id});
        }

        public deleteMovie(id: number) {
            return this.MovieResource.delete({ id: id }).$promise;
        }

        constructor(movieServiceUrl:string, $resource: ng.resource.IResourceService) {
            this.MovieResource = $resource(movieServiceUrl);
        }
    }

    angular.module('MoviesApp').service('movieService', MovieService);

    export class ProductService {
        public calculateTax(price: number) {
            return price * .08;
        }
        public randomQuote() {

            let movieQuote: string[] = ['Your focus determines your reality.', 'It is true that those we meet can change us, sometimes so profoundly that we are not the same afterwards, even unto our names.', 'Enough! You are, all of you are beneath me! I am a god, you dull creature, and I will not be bullied by...'];

             return movieQuote[Math.floor(Math.random() * movieQuote.length)];
            
        
        }
    }

    angular.module('MoviesApp').service('productService', ProductService);


          
}