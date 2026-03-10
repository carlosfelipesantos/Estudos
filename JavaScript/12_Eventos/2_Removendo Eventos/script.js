//Da mesma forma que podemos adicionar eventos, podemos remover 

//Utilizamos o metodo removeEventListener, onde passamos o evento e a funcao que o evento esta escutando


let btn1 = document.querySelector("#btn1");
let btn2 = document.querySelector("#btn2");


//Para utilizar o remove, a funcao que sera removida PRECISA ser externa

//funcao externa de evento click
function msg(){
    console.log("Clicou em mim!");
}

//quando clico em btn1 chama a funcao click
btn1.addEventListener("click",msg);

//quando clico em btn2 remove a funcao externa click de btn1
btn2.addEventListener("click", function(){
    btn1.removeEventListener("click", msg);
});