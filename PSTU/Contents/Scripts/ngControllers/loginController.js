pstuApp.controller('loginController', function ($scope,$window, loginService) {
    $scope.isLoggedIn = false;

    $scope.login = function () {
        if ($scope.username != null && $scope.password != null) {
            loginService.Login($scope.username, $scope.password).then(function (val) {
                $scope.isLoggedIn = val;
                if ($scope.isLoggedIn == "True") {
                    $window.location.href = '/Steps/Step/1';

                }

            });

        }

    }

    $scope.init = function () {

    }
});
