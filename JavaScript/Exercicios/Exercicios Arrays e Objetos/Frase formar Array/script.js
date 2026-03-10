let ditado = "Ola sou o carlos";

cortado = ditado.split(" ");

function imprimirMensagem(...frase){
    for(let i=0;i<frase.length;i++){
        console.log(frase[i])
    }
}

imprimirMensagem(cortado);
imprimirMensagem(ditado);