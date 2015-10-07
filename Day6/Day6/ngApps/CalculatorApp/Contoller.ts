namespace MyApp.Controller {

    class CalculatorController {

        public num1: number;
        public num2: number;
        public num: number;

        submitForm() {
           this.num= this.num1 + this.num2;
        }

    }



    angular.module('CalculatorApp').controller('CalculatorController', CalculatorController);
}