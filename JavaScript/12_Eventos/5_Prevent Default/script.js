//AÇÕES DEFAULT

//Muitos elementos/teclas ja tem ações predefinidas, como clicar em um link redirecionar

//Podemos parar este vento default, e criar uma lógica diferente


let btn1 = document.querySelector("#btn1");
let btn2 = document.querySelector("#btn2");
let p = document.querySelector("p");
let a = document.querySelector("a");


function msg(e){
    console.log("Clicou no button");
    e.stopPropagation();
}

btn1.addEventListener("click",msg);



//A MESMA COISA ESCRITA DE FORMA DIFERENTE
btn2.addEventListener("click", function(event){
    console.log(event);
});



p.addEventListener("click",function(){
    console.log("Clicou no paragrafo")
})



//Parei o evento default do A de levar para um link
a.addEventListener("click",function(e){
    e.preventDefault();

    console.log("Nao vai mudar de link");
})