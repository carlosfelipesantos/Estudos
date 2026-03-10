//Repoe uma antigo elemento no DOM, com um novo;


let novoElemento = document.createElement("p"); //novoElemento é um novo paragrafo
let texto = document.createTextNode("NOVO TITULO QUE TIRA O ANTIGO");;//texto é criado na memoria

novoElemento.appendChild(texto); //adiciona texto dentro do paragrafo NovoElemento


let heading = document.querySelector("#titulo-principal");//pai
let paiHeading = heading.parentNode;//elemento alvo

paiHeading.replaceChild(novoElemento, heading);

