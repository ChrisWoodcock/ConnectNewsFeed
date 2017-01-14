var articlesController = function ($scope, $http, dateService) {
    var vm = this;
    vm.errorMessage = "";
    vm.articles = [];

    var url = "http://localhost:55762/api/articles/date/" +
        dateService.getCurrentDate().getFullYear() + "/" +
        parseInt(dateService.getCurrentDate().getMonth()) + 1 + "/" +
        dateService.getCurrentDate().getDate();

    $http.get(url).
        then(function (response) {
            // Success
            angular.copy(response.data, vm.articles);
        }, function (error) {
            // Failure
            vm.errorMessage = "Failed to load data:" + error;
        })
        .finally(function () {
    });
}

articlesController.$inject = ['$scope', '$http', 'dateService'];
