var EventsApp;
(function (EventsApp) {
    var Controllers;
    (function (Controllers) {
        var FavouriteColorController = (function () {
            function FavouriteColorController() {
            }
            FavouriteColorController.prototype.submitForm = function () {
                alert(this.newSandwich.eggsalad);
            };
            FavouriteColorController.prototype.pick = function (color) {
                this.selectedColor = color;
            };
            return FavouriteColorController;
        })();
        angular.module('EventsApp').controller('FavouriteColorController', FavouriteColorController);
    })(Controllers = EventsApp.Controllers || (EventsApp.Controllers = {}));
})(EventsApp || (EventsApp = {}));
//# sourceMappingURL=Controllers.js.map