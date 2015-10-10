pstuApp.controller('loginController', function ($scope, loginService) {
     
    $scope.login = function()
    {
        //var user = {
        //    user_id: $scope.userName,
        //    password: $scope.password
        //};

        if ($scope.userName != null)
        {
            loginService.AddUser($scope.userName, $scope.password);
        }
       
    }

    $scope.init = function()
    {

    }
});
