(function() {
    'use strict';

    angular
    // naming module myApp
        .module('myApp')
        // naming controller mainController
        .controller('mainController', mainController);

    mainController.$inject = ['$http'];

    /* @ngInject */
    function mainController($http) {
        var vm = this;
        vm.title = 'mainController';

        activate();

        ////////////////
// function that gets the json data
        function activate() {
            $http({
                method:"GET",
                url:"http://localhost:64375/api/TopSpots"
            }).then(function(response) {
                vm.topSpots = response.data;
            });
        }
    }
})();