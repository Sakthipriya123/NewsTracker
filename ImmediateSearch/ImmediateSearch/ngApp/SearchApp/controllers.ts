namespace MyApp.Controllers {

    const apiURL = 'http://CoderCamps-MoviesAPI.AzureWebSites.net/api/movies/search/';

    class FoodController {
        search: string;
        items;

        fetch() {
            if (this.search) {
                console.log('searching');
                this.$http.get(apiURL + this.search)
                    .success((results) => {
                        this.items = results;
                    });
            }
        }

        constructor(private $http: ng.IHttpService) { }
    }

    angular.module("MyApp").controller('FoodController', FoodController);
}