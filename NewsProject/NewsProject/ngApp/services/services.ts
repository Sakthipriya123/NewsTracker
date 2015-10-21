namespace NewsPage.Services {

    export class NewsServices {
        public newsResource;


        public listNews() {
            return this.newsResource.query();
        }

       

        public getArticle(id: number) {
            return this.newsResource.get({ id: id });
        }

        constructor($resource: angular.resource.IResourceService) {
            this.newsResource = $resource('/api/NewsApp/:id');

        }

    }

    angular.module("NewsPage").service("newsServices", NewsServices);
}
