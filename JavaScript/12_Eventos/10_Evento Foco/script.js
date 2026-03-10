//Eventos por foco

//Quando focamos em um elemento ou saimos dele
//Podemos atrelar um evento a esta ação,

//Focus para quando o elemento recebe foco e blur quando ele perde;

let input = document.querySelector("#input1");

input.addEventListener("focus", function(){

    console.log("Entrou no input");

})


input.addEventListener("blur", function(){

    console.log("Saiu do input");

})

