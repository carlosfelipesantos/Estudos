// Verificando altura e largura do elemento

//Com o JS tambem é possivel verificar propriedades do elemento como altura e largura


let elemento = document.querySelector("#titulo-principal");

console.log("largura: ", elemento.offsetWidth);//considera as bordas
console.log("altura: ", elemento.offsetHeight);

console.log("largura: ", elemento.clientWidth);//Nao considera as bordas
console.log("altura: ", elemento.clientHeight);