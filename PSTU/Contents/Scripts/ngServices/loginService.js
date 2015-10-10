pstuApp.service('loginService', function ($http) {

    // Add User

    this.AddUser = function (userID, password) {

        var response = $http({

            method: "post",

            url: "Login/AddUser",

            data: {

                userID: userID

            }

        });
        return response;

    }
});