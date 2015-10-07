var MyApp;
(function (MyApp) {
    var Controller;
    (function (Controller) {
        var CalculatorController = (function () {
            function CalculatorController() {
            }
            CalculatorController.prototype.submitForm = function () {
                this.num = this.num1 + this.num2;
            };
            return CalculatorController;
        })();
        angular.module('CalculatorApp').controller('CalculatorController', CalculatorController);
    })(Controller = MyApp.Controller || (MyApp.Controller = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=Contoller.js.map