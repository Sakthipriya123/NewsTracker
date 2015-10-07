//namespace prevent leakage that is prevent using by other modules
var MyApp;
(function (MyApp) {
    angular.module('MoviesApp', []);
})(MyApp || (MyApp = {}));
//# sourceMappingURL=app.js.map