//Debounce

//Um evento ocorrer varias vezes pode ser um problema para o usuario

//Por isso podemos fazer um debounce, que é um suavizador de evento,
//para nao chamar o mesmo tantas vezes.

let timeout;
window.addEventListener("mousemove", function(e){
    clearTimeout(timeout);
     timeout =  setTimeout(function(){

       console.log(e.x);

    },100);
})
