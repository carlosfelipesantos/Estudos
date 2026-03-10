function checarNumer0(num){
    let number = Number(num);
    if(Number.isNaN(number)){
        alert("Por favor, passe somente numeros para o programa")
    }else{
        return number;
    }
}


checarNumer0(5);
checarNumer0("ola");

let number = prompt("Digite um numero");

checarNumer0(number);