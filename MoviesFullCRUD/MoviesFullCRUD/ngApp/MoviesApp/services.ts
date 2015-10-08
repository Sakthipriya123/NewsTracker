namespace MoviesApp.Services {

    export class ProductService {
        public calculateTax(price: number) {
            return price * .08;
        }
        public randomQuote() {

            let movieName: string[] = ['Your focus determines your reality.', 'It is true that those we meet can change us, sometimes so profoundly that we are not the same afterwards, even unto our names.', 'Enough! You are, all of you are beneath me! I am a god, you dull creature, and I will not be bullied by...'];

             return movieName[Math.floor(Math.random() * movieName.length)];
            
        
        }
    }

    angular.module('MoviesApp').service('productService', ProductService);


          
}