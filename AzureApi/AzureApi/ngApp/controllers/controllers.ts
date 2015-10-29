namespace MyApp.Controllers {

    export class HomeController {
        public loaded: number = 0;
        public max: number = 0;

        public upload(file: File) {
            this.Upload.upload({
                method: 'post',
                file: file,
                url: '/api/upload'
            }).progress((result) => {
                console.log('progress...');
                this.loaded = result['loaded'];
                this.max = result['totalSize'];
            }).then((result) => {
                console.log('File upload complete.');
            }).catch((result) => {
                console.error('Could not upload file!');
            });

        }

        constructor(private Upload: angular.angularFileUpload.IUploadService) { }
    }



    export class AboutController {

    }
}