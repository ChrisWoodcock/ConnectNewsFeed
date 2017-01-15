var newsFeed =
   angular.module("newsFeed", ['ngRoute'])
       .config(function ($routeProvider) {
           $routeProvider.when("/", {
               controller: "articlesController",
               controllerAs: "vm",
               templateUrl: "/content/views/viewArticles.html"
           });

           $routeProvider.when("/details/:articleId", {
               controller: "articleDetailsController",
               controllerAs: "vm",
               templateUrl: "/content/views/articleDetailView.html"
           });

           $routeProvider.otherwise({ redirectTo: "/" });
       })
       .service('dateService', [function () {
           var currentDate = new Date(2015, 0, 1); // Jan 01 2015
           return {
               getCurrentDate: function () { return currentDate; },
               setCurrentDate: function (value) { currentDate = value; },
               formatCurrentDate: function () { return moment(currentDate).format("ddd D MMM YYYY"); }
           }
       }]);

newsFeed.controller('homePageController', homePageController);
newsFeed.controller('articlesController', articlesController);

var onResize = function () {
    // apply dynamic padding at the top of the body according to the fixed navbar height
    $("body").css("padding-top", $(".navbar-fixed-top").height() + 20);
    $("body").css("padding-bottom", $(".navbar-fixed-bottom").height() + 20);
};

// attach the function to the window resize event
$(window).resize(onResize);

// call it also when the page is ready after load or reload
$(function () {
    onResize();
});