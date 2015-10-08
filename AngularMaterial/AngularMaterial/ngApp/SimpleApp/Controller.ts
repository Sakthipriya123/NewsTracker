alert("!")
namespace SimpleApp.Controllers {
   
    class HomeController {
        public favoriteColor;

        public openDialog() {

            this.$mdDialog.show({
                //hit ctrl + space
                controller: DialogController,
                controllerAs: 'dialog',
                templateUrl: 'dialog.html',
                clickOutsideToClose: true

            }).then((favoriteColor) => {
                this.favoriteColor = favoriteColor;
            });
        }

        constructor(private $mdDialog: angular.material.IDialogService) { }
    }

    angular.module('SimpleApp').controller('HomeController', HomeController);

    class DialogController {

        public pickColor(favoriteColor: string) {
            this.$mdDialog.hide(favoriteColor);
        }

        constructor(private $mdDialog: angular.material.IDialogService) { }

    }

    }