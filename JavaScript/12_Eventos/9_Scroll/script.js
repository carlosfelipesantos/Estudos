//Eventos por Scroll

//Podemos atrelar evento ao scroll da tela tambem, pelo evento scroll,

//Exemplo:Podemos criar um elemento assim que o scroll atingir uma posicao



window.addEventListener("scroll",function(e){

if(window.pageYOffset>1000){
    console.log("Ativou");
}

});