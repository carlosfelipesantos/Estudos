// TRY tenta executar o codigo, caso nao consiga, ele cai no catch(pegar), retornando o erro
//let b = 2;

try { 

    let a = 2 + b;

}catch(erro){
   // console.log(erro); se usar assim, o try catch nao para o codigo por um erro
    throw new Error(erro); // ja assim ele trava o codigo


}

console.log("teste");