//Alterando o DOM com appendChild,

//adiciona um nó após todos os elementos do elemento pai;


let novoElemento = document.createElement("p"); //novoElemento é um novo paragrafo
let texto = document.createTextNode("TEXTO CRIADO POR JS");;//texto é criado na memoria

novoElemento.appendChild(texto); //adiciona texto dentro do paragrafo NovoElemento

let p = document.querySelector("#paragrafo-principal"); //p recebe o elemento com ID paragrafo principal
let pai = p.parentNode; //pai busca atraves do parentNodee o elemento pai de p(paragrafo principal)

pai.appendChild(novoElemento);//o elemento pai recebe atraves do appendChild o paragrafo novoElemento ja com o texto inserido