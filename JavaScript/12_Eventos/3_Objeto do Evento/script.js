//O OBJETO DO EVENTO

//Quando criamos eventos, temos a opcao de utilizar um argumento opcional, chamado objeto do evento

//Contem propriedades que podem ser utilizadas ao nosso favor

//O objeto é criado pelo JavaScript automaticamente



let btn1 = document.querySelector("#btn1");
let btn2 = document.querySelector("#btn2");


function msg(e){
    console.log(e);
}
btn1.addEventListener("click",msg);



//A MESMA COISA ESCRITA DE FORMA DIFERENTE
btn2.addEventListener("click", function(event){
    console.log(event);
});