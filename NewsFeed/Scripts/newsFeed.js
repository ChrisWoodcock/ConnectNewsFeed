var newsFeed =
   angular.module("newsFeed", ['ngRoute'])
       .config(function ($routeProvider) {
           $routeProvider.
               when("/", {
                 controller: "articlesController",
                 controllerAs: "vm",
                 templateUrl: "/content/views/viewArticles.html",
                 paramShowByChannel: false
               }).
               when("/articles/:channelName", {
                 controller: "articlesController",
                 controllerAs: "vm",
                 templateUrl: "/content/views/viewArticles.html",
                 paramShowByChannel: true
               }).
               when("/details/:articleId", {
                 controller: "articleDetailsController",
                 controllerAs: "vm",
                 templateUrl: "/content/views/articleDetailView.html"
               }).
               otherwise({ redirectTo: "/" });
       })
       .service('articleService', [function () {
           var currentDate = new Date(2015, 0, 1); // Jan 01 2015
           var channelName = null;
           return {
               getCurrentDate: function () { return currentDate; },
               setCurrentDate: function (value) { currentDate = value; },
               getChannelName: function () { return channelName; },
               setChannelName: function (value) { channelName = value; },
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