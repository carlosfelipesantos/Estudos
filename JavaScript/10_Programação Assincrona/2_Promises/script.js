//Promise é uma promessa criada como um objeto especial

const minhaPromise = new Promise((resolve, reject) =>{
    let estouFazendoDieta = true;

    if (estouFazendoDieta){
        resolve("Dieta seguida!"); //quando a promisse da certo, chamamos o resolve
    } else {
        reject("Dieta falhada"); // quando a promise falha, chamamos o reject
    }
});

minhaPromise
.then(result => console.log(result)) //.then serve para capturar o resultado
.catch(error => console.log(error)); //Garante que se der erro, você consiga detectar, tratar ou ao menos exibir o erro 