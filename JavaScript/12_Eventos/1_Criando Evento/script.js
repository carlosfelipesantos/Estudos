//Como acionar um evento

//Devemos atrelar o evento a um elemento, por exemplo um botao

//O elemento respondera por esse evento, ja os outros da pagina nao


let btn = document.querySelector("button");

btn.addEventListener("click", function() {
    console.log("Clicou em mim!");
});