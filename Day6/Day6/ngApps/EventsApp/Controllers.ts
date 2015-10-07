namespace EventsApp.Controllers {

    class FavouriteColorController {

        public newSandwich: any;

        submitForm() {
            alert(this.newSandwich.eggsalad);
        }
        public selectedColor: string;

        pick(color: string) {

            this.selectedColor = color;
        }
        
    }

    angular.module('EventsApp').controller('FavouriteColorController', FavouriteColorController);
}