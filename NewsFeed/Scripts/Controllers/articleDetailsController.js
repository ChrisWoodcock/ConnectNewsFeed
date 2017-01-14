var articleDetailsController = function ($sce, $routeParams, $http) {
    var vm = this;
    vm.articleDetails = {};
    vm.articleId = $routeParams.articleId;
    vm.errorMessage = "";
    vm.isBusy = true;

    var url = "http://localhost:55762/api/articles/" + vm.articleId + "/details"

    $http.get(url).
        then(function (response) {
            // Success
            angular.copy(response.data, vm.articleDetails);
            vm.articleDetails.Body = $sce.trustAsHtml(vm.articleDetails.Body);
        }, function (error) {
            // Failure
            vm.errorMessage = "Failed to load data:" + error;
        })
    .finally(function () {
        vm.isBusy = false;
    });
}

articlesController.$inject = ['$sce', '$routeParams', '$http'];
