//CALLBACK é uma função que faz uma ação após algum acontecimento no código

//podemos realizar um callback com a função setTimeout

console.log("1");

//basicamente define um tempo para um comando ser executado
setTimeout(() => {
    console.log("5");
}, 2000); //2000 milisegundos = 2 segundos, após esse tempo, executa a funcao

console.log("2");
console.log("3");
console.log("4");