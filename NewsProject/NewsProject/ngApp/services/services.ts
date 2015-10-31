namespace NewsPage.Services {

    export class NewsServices {
        public newsResource;
        public categories;
        public categoryResource;
        private adminResource;


        public listNews() {
            return this.newsResource.query();
        }
        public listCategories()
        {
            return this.categoryResource.query();
        }

        public save(news) {
            return this.newsResource.save(news).$promise;
        }

        public getArticle(id: number) {
            return this.newsResource.get({id: id}).$promise;
        }

        public getCategories() {
            return this.categoryResource.query();
        }
        public getCategory(id: number) {
            return this.categoryResource.get({id: id });
        }

         public listnews() {
            return this.adminResource.query();
        }


        constructor($resource: angular.resource.IResourceService) {
            this.newsResource = $resource('/api/newsapp/:id');
            this.categoryResource = $resource('/api/categories/:id');
            this.adminResource = $resource('/api/admin/:id');       

           
        }

    }

    angular.module("NewsPage").service("newsServices", NewsServices);
}
