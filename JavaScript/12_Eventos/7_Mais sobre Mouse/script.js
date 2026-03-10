//No mouse temos tambem eventos como mousedown e mouseup, semelhante aos das teclas

//Dblclick para ativar com dois cliques;

let btn1 = document.querySelector("#btn1");

let btn2 = document.querySelector("#btn2");

//Apertou o Botao
btn1.addEventListener("mousedown", function(){
    console.log("Apertou o botao")
});

//Soltar o Botao
btn1.addEventListener("mouseup", function(){
    console.log("Soltou o botao")
});

//Double Click
btn2.addEventListener("dblclick", function(){
    console.log("Clicou duas vezes");
})


//Pegando botao direito (Precisa desse gambiarra)
btn2.addEventListener("contextmenu", function(e){
//contextmenu nao é um click normal, aparece o menu do navegador (inspecionar, etc)

e.preventDefault();//prevent default desativa esse menu do navegador na area do botao
console.log("Botao direito"); //passamos a nova funcionalidade

})