pstuApp.service('loginService', function ($http, $q) {

    this.Login = function (userID, password) {

        var deffered = $q.defer();
        $http.get('/Login/DoLogin?username=' + userID + '&password=' + password)
            .success(deffered.resolve)
            .error(deffered.reject);
        return deffered.promise;

    }
});


