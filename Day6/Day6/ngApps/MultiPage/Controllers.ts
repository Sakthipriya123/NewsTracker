namespace MultiPage.Controllers {
    class HomeController {

        
    }

    angular.module('MultiPage').controller('HomeController', HomeController);

    class ProductController {

        products;

        constructor() {            this.products = [
                { name: 'Red and Light Beige Art Silk', src: 'http://img5.utsavfashion.com/lbf/lbf1/lbf1-thumbnail.jpg' , price : "$140" },
                { name: 'Red and Cream Faux Georgette', src: 'http://img6.utsavfashion.com/sxz/sxz2306/sxz2306-thumbnail.jpg', price: "$150" },                { name: 'Fuchsia and Blue Net Lehenga Style Saree', src: 'http://img5.utsavfashion.com/sga/sga5813/sga5813-thumbnail.jpg', price: "$110" },                { name: 'Red Georgette', src: 'http://img7.utsavfashion.com/lxw/lxw88/lxw88-thumbnail.jpg', price: "$150" },                { name: 'Beige and Pink Art Silk', src: 'http://img7.utsavfashion.com/skk/skk21487/skk21487-thumbnail.jpg', price: "$210" },                { name: 'Fuchsia Art Banarasi Silk', src: 'http://img7.utsavfashion.com/sspa/sspa177/sspa177-thumbnail.jpg', price: "$270" },            ];
                                       
        }

        addCart() {
            return this.products;

        }
        

    }
    

    angular.module('MultiPage').controller('ProductController', ProductController);
}