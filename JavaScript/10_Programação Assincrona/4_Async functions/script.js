//Podemos criar funcoes assincronas com a palavra reservada async,

//Retornam uma promise,

//Se retornar algo a promessa é resolvida, se der alguma exception, a promessa é rejeitada;

async function somar(a, b) {
    return a + b;
}

console.log(somar(2,4));

somar (2,4).then(value => console.log(value));