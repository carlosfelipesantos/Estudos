function multiplicarTresNumeros(x, y, z){
    return x * y * z;
}

console.log(multiplicarTresNumeros(2, 3, 4));


// funcao para atribuir valor a uma variavel "mult" e utilizar depois [
// no console.log abaixo
const mult = multiplicarTresNumeros(5, 4, 8);

console.log("O valor de mult é " + mult);



//funcao pode dirigir
function podeDirigir (idade, cnh) {
    if(idade >=18 && cnh==true){
        console.log("Pode dirigir");
    }else{
        console.log("Nao pode dirigir")
    }
}

console.log(podeDirigir(19, true));
console.log(podeDirigir(25, true));
console.log(podeDirigir(19, false));
console.log(podeDirigir(17, true));
console.log(podeDirigir(16, false));