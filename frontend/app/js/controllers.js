angular.module("Nuvem3").controller("Nuvem3Ctrl", function($scope,$http){
    $scope.teste="de boa";
    $scope.clientes = [];
    
    $scope.carregarClientes=function(){
        $http.get("https://localhost:44306/api/teste/get").then(function(data){
            $scope.clientes=data.data;
        });
    };
    $scope.carregarClientes();
})