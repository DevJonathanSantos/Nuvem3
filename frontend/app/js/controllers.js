angular.module("Nuvem3").controller("Nuvem3Ctrl", function($scope,$http){
    $scope.teste="de boa";
    $scope.clientes = [];
    $scope.modal=[];
    
    $scope.carregarClientes=function(){
        $http.get("https://localhost:44306/api/cliente/buscar").then(function(data){
            $scope.clientes=data.data;
        });
    };

    $scope.salvarAlteracoes=function(cliente){
        console.log(cliente);
        $http.post("https://localhost:44306/api/cliente/editar",cliente).then(function(data){
            $scope.carregarClientes();
        });
    };

    $scope.cadastrarCliente=function(cliente){
        console.log(cliente);
        $http.post("https://localhost:44306/api/cliente/cadastrar",cliente).then(function(data){
            $scope.carregarClientes();
        });
    };

    $scope.removerCliente=function(id){
        console.log(cliente);
        $http.post("https://localhost:44306/api/cliente/remover",cliente).then(function(data){
            $scope.carregarClientes();
        });
    };

    $scope.carregarModal=function(id){
        $scope.modal=$scope.clientes.find(f=>f.Id==id)
    };

    $scope.carregarClientes();
})