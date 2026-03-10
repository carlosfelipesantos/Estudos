//Propagação/ Propagation

//Quando nao definimos um elemento muito bem (seletor brando)
//Ou um elemento que esta dentro de outro evento

//Pode acontecer a propagação, o outro elemento ativar um evento tambem,
//gerando uma duplicação

//Temos um meotodo que para esta propagação e resolve, stopPropagation






//Abaxio criamos um problema de propagação, pois o btn1 esta dentro do p

//E quando clicamos no btn1, executa seu evento + o evento de p


let btn1 = document.querySelector("#btn1");
let btn2 = document.querySelector("#btn2");
let p = document.querySelector("p");


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