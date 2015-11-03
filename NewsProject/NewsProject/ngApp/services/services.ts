namespace NewsPage.Services {

    export class NewsServices {
        public newsResource;
        public categories;
        public categoryResource;
        private adminResource;
        private commentResource;


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

    export class CommentService {
        private commentResource;

        public save(comment){
            return this.commentResource.save(comment).$promise;
        }

        public getComment(id: number) {
            return this.commentResource.get({ id: id }).$promise;
        }
               

        constructor($resource: ng.resource.IResourceService) {
            this.commentResource = $resource('/api/comments');
        }

    }
    angular.module("NewsPage").service("commentService", CommentService);
}
