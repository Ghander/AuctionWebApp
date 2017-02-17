namespace AuctionWebsite.Controllers {

    export class HomeController {
        public items;
        constructor(public $http: ng.IHttpService, public $state: ng.ui.IStateService) {
            $http.get('api/auctionItems').then((res) => {
                this.items = res.data;
            })
        }

        public postItem(item) {
            this.$http.post('api/auctionItems', item).then((res) => {
                this.$state.reload();
            })
        }
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
