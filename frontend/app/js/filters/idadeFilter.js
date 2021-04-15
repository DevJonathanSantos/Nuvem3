angular.module("Nuvem3").filter("idade",function(){
    return function(input){
        console.log(input);
        var birthday = +new Date(input);
        return ~~((Date.now() - birthday) / (31557600000));
    };
});