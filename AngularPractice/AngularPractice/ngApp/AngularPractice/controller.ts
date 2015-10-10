namespace MyApp {

    export class HomeController {
    

        public name;
        public cars;
        //constructor() {
        //    this.name = "Super Cool";
        //}
        constructor(private $http: ng.IHttpService) {
            this.name = "Super Cool";
        }

        getCars() {
            this.$http.get("http://codercamps-cardealershipapi.azurewebsites.net/api/cars").success((movies) => {

                this.cars = movies;
            }).error((error) => {
            });
        }

    }

    export class CarsController {

        constructor() {
        }
    }

}