<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Angular.WebForm" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Get Data Via Angular</title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.2.5/angular.min.js"></script>
</head>

<body ng-app="webFormDemoApp">

    <div ng-controller="webFormController">
        <button ng-click="webFormData.HandleUserClick(item, $event)">Get Data</button>
        <div>
            Data : {{webFormData.response}}
        </div>
    </div>

    <script type="text/javascript">
        (function () {
        
        angular.module("webFormDemoApp", [])
            .controller("webFormController",
                function($scope, $http) {
                    $scope.webFormData = {};
                    $scope.webFormData.HandleUserClick = function(item, event) {

                        $http.post('WebForm.aspx/GetWebFormData', { data: {} })
                            .success(function(data) {
                                $scope.webFormData.response = data.d;
                            })
                            .error(function(data, status) {
                                $scope.status = status;
                            });
                    }
                });

        })();
    </script>

</body>

</html>
