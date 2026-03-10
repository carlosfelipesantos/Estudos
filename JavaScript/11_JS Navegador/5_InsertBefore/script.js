//Alterando o DOM com insertBefore

//Precisamos de 3 coisas para inserir,




// 1° Um novo elemento
let novoElemento = document.createElement("p");


//2° Elemento Alvo
let elementoAlvo = document.querySelector("#titulo-principal");


//3°Elemento Pai
let elementoPai =document.querySelector("#container-principal");


//Agora podemos usar o insertBefore
elementoPai.insertBefore(novoElemento, elementoAlvo);
