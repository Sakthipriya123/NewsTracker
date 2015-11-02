namespace NewsPage.Controllers {

    export class AccountController {
        public externalLogins;

         public getClaim(type) {
            return this.accountService.getClaim(type);
        }

        public isLoggedIn() {
            return this.accountService.isLoggedIn();
        }

        public logout() {
            this.accountService.logout();
        }

        public getExternalLogins() {
            return this.accountService.getExternalLogins();
        }

        constructor(private accountService: NewsPage.Services.AccountService, private $location: ng.ILocationService) {
            this.getExternalLogins().then((results) => {
                this.externalLogins = results;
            });
        }
    }

    angular.module('NewsPage').controller('AccountController', AccountController);


    export class LoginController {
        public loginUser;
        public validationMessages;

        public login() {
            this.accountService.login(this.loginUser).then(() => {
                this.$location.path('/');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }

        constructor(private accountService: NewsPage.Services.AccountService, private $location: ng.ILocationService) { }
    }


    export class RegisterController {
        public registerUser;
        public validationMessages;

        public register() {
             this.accountService.register(this.registerUser).then(() => {
                //this.registerUser = data;
                this.$location.path('/Signin');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }

        constructor(private accountService: NewsPage.Services.AccountService, private $location: ng.ILocationService) { }
    }



    export class ExternalLoginController {

        constructor($http: ng.IHttpService, private $location: ng.ILocationService, private accountService: NewsPage.Services.AccountService) {
            // if the user is already registered then redirect home else register
            let response = accountService.parseOAuthResponse($location.hash());
            let externalAccessToken = response['access_token'];
            accountService.getUserInfo(externalAccessToken).then((userInfo: any) => {
                if (userInfo.hasRegistered) {
                    accountService.storeUserInfo(response);
                    $location.path('/');
                } else {
                    $location.path('/externalRegister');
                }
            });
        }
    }


    export class ExternalRegisterController {
        private externalAccessToken;
        public registerUser;
        public validationMessages;

        public register() {
            this.accountService.registerExternal(this.registerUser.email, this.externalAccessToken)
                .then((result) => {
                    this.$location.path('/Signin');
                }).catch((result) => {
                    this.validationMessages = result;
                });
        }

        constructor(private accountService: NewsPage.Services.AccountService, private $location: ng.ILocationService) {
            let response = accountService.parseOAuthResponse($location.hash());
            this.externalAccessToken = response['access_token'];
        }

    }

}