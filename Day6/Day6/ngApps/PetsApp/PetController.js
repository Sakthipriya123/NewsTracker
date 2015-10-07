var MyApp;
(function (MyApp) {
    var Controllers;
    (function (Controllers) {
        var PetsController = (function () {
            function PetsController() {
                this.pets = [
                    {
                        name: 'Dog', animals: [
                            { name: 'Pinky', src: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSoEDfeoGNFgnT5v6y4ar_VhrMeTmSh9hf-befDorN9oeEgC--A_Q' },
                            { name: 'Lora', src: 'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQqLPj2q6DFSn4kRc2Jon1jbtOC1f94fPUaOt2lQE9JfdEVVhpq' }
                        ]
                    },
                    {
                        name: 'Bunnies', animals: [
                            { name: 'Rilo', src: 'http://www.jubed.com/youthgames/images/bunnies.jpg' },
                            { name: 'SnowBall', src: 'http://ctboom.com/wp-content/uploads/177002767.jpg' }
                        ]
                    }
                ];
            }
            return PetsController;
        })();
        angular.module('PetsApp').controller('PetsController', PetsController);
    })(Controllers = MyApp.Controllers || (MyApp.Controllers = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=PetController.js.map