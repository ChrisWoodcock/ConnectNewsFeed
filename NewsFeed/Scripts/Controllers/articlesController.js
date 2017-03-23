var articlesController = function ($scope, $routeParams, $http, articleService) {
    var vm = this;
    
    vm.errorMessage = "";
    vm.articles = [];

    if (typeof $routeParams.channelName !== 'undefined') {
        articleService.setChannelName($routeParams.channelName);
    }
        
    vm.channelName = articleService.getChannelName();

    // add 1 to month as months are 0-11 in javascript
    var date = articleService.getCurrentDate().getFullYear() + "/" +
            parseInt(articleService.getCurrentDate().getMonth()) + 1 + "/" +
            articleService.getCurrentDate().getDate();

    // TO DO: configuration for deployment
    var url = "http://newsfeedapi20170115020814.azurewebsites.net"
    //var url = "http://localhost:55762"
        + "/api/articles/date/";

    if (vm.channelName != null) {
        url = url + vm.channelName + "/" + date;
    }
    else {
        url = url + "/" + date;
    }
    
    $http.get(url).
        then(function (response) {
          // Success
          angular.copy(response.data, vm.articles);
        }, function (error) {
          // Failure
          vm.errorMessage = "Failed to load data:" + error;
        }).finally(function () {
        });
}

articlesController.$inject = ['$scope', '$routeParams', '$http', 'articleService'];
