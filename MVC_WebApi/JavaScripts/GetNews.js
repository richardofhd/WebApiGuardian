var NewsApp = angular.module('myApp', []);

NewsApp.controller('newsCtrl', function ($scope, NewsService) {

    getNews();
    function getNews() {
        NewsService.getNews()
            .success(function (data) {
                ///debugger
                $scope.results =JSON.parse( data);
                // $scope.results = data.results;

            })
        //.error(function (error) {
        //    $scope.status = 'Unable to load customer data: ' + error.message;
        //    console.log($scope.status);
        //});
    };
});

NewsApp.factory('NewsService', ['$http', function ($http) {

    var NewsService = {};
    NewsService.getNews = function () {
        return $http.get('/News/GetNews');
    };
    return NewsService;

}]);
