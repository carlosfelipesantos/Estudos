function retornarNumeroPar(n){
    if(n % 2 ==0){
        console.log("n agora sendo par: " + n);
    } else {
        console.log(n);
        retornarNumeroPar(n - 1);
    }
}

retornarNumeroPar(37);




function recursao(n){

    if(n - 1 < 2){
        console.log("Recursao parou");
    
    
    } else if(n % 2 != 0){
        console.log("Numero impar " + n);
        recursao(n-1);
    
    
    } else{
        console.log("Numero par " + n);
        recursao(n-2);
    }

}

recursao(39);
recursao(10);
recursao(55);