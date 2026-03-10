//Para selecionar diversos elementos com o query, podemos utilizar o método querySelectorAll,

//Em vez de um, podemos pegar todos os elementos semelhantes com o seletor do CSS,

let itens = document.querySelectorAll('.itens-vermelhos');

console.log(itens);

itens[0].style.color="red"
itens[1].style.color="red"


let itens2 = document.querySelectorAll('.itensAzuis');

console.log(itens2);