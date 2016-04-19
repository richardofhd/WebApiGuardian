var NewsApp = angular.module('myAppS', []);

NewsApp.controller('newsCtrlS', function ($scope, NewsService) {

    GetSearch();
    function GetSearch() {
        NewsService.GetSearch()
            .success(function (dataS) {
                ///debugger
                $scope.results = JSON.parse(dataS);
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
    NewsService.GetSearch = function () {
        return $http.get('/Busquedas/GetSearch');
    };
    return NewsService;

}]);
