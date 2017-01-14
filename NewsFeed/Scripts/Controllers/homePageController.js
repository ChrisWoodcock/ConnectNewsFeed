var homePageController = function ($scope, dateService) {
    // TO DO: get a list of categories for navigation
    $scope.currentDate = dateService.formatCurrentDate;

    $scope.loadMore = function () {
        // increment the year of the date to load more articles
        var currentDate = dateService.getCurrentDate();
        currentDate.setFullYear(currentDate.getFullYear() + 1);
        dateService.setCurrentDate(currentDate);
    }
}

homePageController.$inject = ['$scope', 'dateService'];
