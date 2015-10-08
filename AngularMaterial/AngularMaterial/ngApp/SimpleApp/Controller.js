alert("!");
var SimpleApp;
(function (SimpleApp) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController($mdDialog) {
                this.$mdDialog = $mdDialog;
            }
            HomeController.prototype.openDialog = function () {
                var _this = this;
                this.$mdDialog.show({
                    //hit ctrl + space
                    controller: DialogController,
                    controllerAs: 'dialog',
                    templateUrl: 'dialog.html',
                    clickOutsideToClose: true
                }).then(function (favoriteColor) {
                    _this.favoriteColor = favoriteColor;
                });
            };
            return HomeController;
        })();
        angular.module('SimpleApp').controller('HomeController', HomeController);
        var DialogController = (function () {
            function DialogController($mdDialog) {
                this.$mdDialog = $mdDialog;
            }
            DialogController.prototype.pickColor = function (favoriteColor) {
                this.$mdDialog.hide(favoriteColor);
            };
            return DialogController;
        })();
    })(Controllers = SimpleApp.Controllers || (SimpleApp.Controllers = {}));
})(SimpleApp || (SimpleApp = {}));
