pstuApp.controller('stepController', function ($scope, $window) {

    $scope.registration_no = Math.floor((Math.random() * 100000) + 01);
    $scope.admit_date = getCurrentFullDate();

    //return current date
    function getCurrentFullDate()
    {
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!
        var yyyy = today.getFullYear();

        if (dd < 10) {
            dd = '0' + dd
        }

        if (mm < 10) {
            mm = '0' + mm
        }

        return dd + '-' + mm + '-' + yyyy;
    }

    $scope.init = function () {
        //console.log('goo')
    }
})