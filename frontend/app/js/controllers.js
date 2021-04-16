angular.module("Nuvem3").controller("Nuvem3Ctrl", function($scope,$http){
    $scope.teste="de boa";
    $scope.clientes = [];
    $scope.modal=[];
    
    $scope.carregarClientes=function(){
        $http.get("https://localhost:44306/api/teste/get").then(function(data){
            $scope.clientes=data.data;
        });
    };

    $scope.carregarModal=function(id){
        console.log(id);
        $scope.modal=$scope.clientes.find(f=>f.Id==id)
    }
    $scope.carregarClientes();
})