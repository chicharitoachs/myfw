app.controller('HomeController', ['$scope', '$http', '$timeout', '$rootScope',
function($scope, $http, $timeout, $rootScope) {
    $scope.ItemPaging = {};
    $scope.ItemPaging.maxSize = 5;
    $scope.ItemPaging.total = 0;
    $scope.ItemPaging.numPerPage = 10;
    $scope.ItemPaging.currentPage = 1;
    $scope.currentItem = {};

    $scope.MyData = [];
    $scope.loadData = function () {
        $scope.MyData = [];
        var data = {};
        data.page = $scope.ItemPaging.currentPage;
        data.pageSize = $scope.ItemPaging.numPerPage;
        $http({
            method: 'POST',
            url: '/Home/GetList',
            params: data
        }).then(function successCallback(response) {
            $scope.MyData = response.data.Items;
            $scope.ItemPaging.total = response.data.Count;
        }, function errorCallback(response) {

        });
    }
    $scope.loadData();
}]);
