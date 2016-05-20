(function () {
    'use strict';
    angular
        .module('app')
        .controller('Main', main);
    function main($scope, $http) {
        $http.get('http://localhost:8753/SampleService.svc/GetListOfPerson/').then(function (response) {
            $scope.persons = response.data;
        });
    }
})();