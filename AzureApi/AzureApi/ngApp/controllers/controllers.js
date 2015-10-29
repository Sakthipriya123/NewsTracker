var MyApp;
(function (MyApp) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController(Upload) {
                this.Upload = Upload;
                this.loaded = 0;
                this.max = 0;
            }
            HomeController.prototype.upload = function (file) {
                var _this = this;
                this.Upload.upload({
                    method: 'post',
                    file: file,
                    url: '/api/upload'
                }).progress(function (result) {
                    console.log('progress...');
                    _this.loaded = result['loaded'];
                    _this.max = result['totalSize'];
                }).then(function (result) {
                    console.log('File upload complete.');
                }).catch(function (result) {
                    console.error('Could not upload file!');
                });
            };
            return HomeController;
        })();
        Controllers.HomeController = HomeController;
        var AboutController = (function () {
            function AboutController() {
            }
            return AboutController;
        })();
        Controllers.AboutController = AboutController;
    })(Controllers = MyApp.Controllers || (MyApp.Controllers = {}));
})(MyApp || (MyApp = {}));
//# sourceMappingURL=controllers.js.map