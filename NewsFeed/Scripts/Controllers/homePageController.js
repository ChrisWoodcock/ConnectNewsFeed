var homePageController = function ($scope, $http, articleService) {
    var vm = this;
    vm.errorMessage = "";
    $scope.channels = [];

    $scope.currentDate = articleService.formatCurrentDate;

    $scope.loadMore = function () {
        // increment the year of the date to load more articles
        var currentDate = articleService.getCurrentDate();
        currentDate.setFullYear(currentDate.getFullYear() + 1);
        articleService.setCurrentDate(currentDate);
    }

    $scope.isChannelActive = function (channel) {
        var activeChannel = articleService.getChannelName();
        if (channel == activeChannel) {
            return true;
        }
        else
            return false
    }

    // TO DO: configuration for deployment
    //var url = "http://newsfeedapi20170115020814.azurewebsites.net/api/channels/" +
    var url = "http://localhost:55762/api/channels/";

    $http.get(url).
        then(function (response) {
            // Success
            angular.copy(response.data, $scope.channels);
        }, function (error) {
            // Failure
            vm.errorMessage = "Failed to load channels:" + error;
        })
        .finally(function () {
        });
}

homePageController.$inject = ['$scope', '$http', 'articleService'];
