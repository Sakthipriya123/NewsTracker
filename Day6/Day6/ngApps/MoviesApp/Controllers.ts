namespace MyApp.Controllers {

    class MoviesController {

        movies;
        constructor() {
            this.movies = [
                { title: 'Star Wars' },
                { title: 'Raiders of the the Lost Ark' },
                { title: 'King Kong' }
            ];
        }
    }

    angular.module('MoviesApp').controller('MoviesController', MoviesController);
}