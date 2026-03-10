//Eventos de tecla/ Key Event

//Sempre que uma tecla é pressionada, são gerados dois eventos:
//keyup e keydown

//Podemos realizar ações nesses eventos

//Keyup é quando soltamos a tecla,

//Keydown é quando apertamos a tecla.



//Keydown
window.addEventListener("keydown", function(e){

    
if(e.key == "q"){ //se a tecla for Q
    console.log("Apertou a letra q") //retorna apertou a letra Q

} else if(e.key == "Enter"){ //se a tecla for enter
    console.log("Apertou enter") //retorna a letra enter
}

});

//Keydown
window.addEventListener("keyup", function(e){

if(e.key="Enter"){ //Se soltar a tecla
    console.log("Soltou o enter");//retorna soltou o enter
}

})
