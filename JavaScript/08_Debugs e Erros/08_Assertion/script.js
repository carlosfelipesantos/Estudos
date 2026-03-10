// FINALLY é executada independente do resultado do try/catch;

try { 

    let a = 2 + b;

}catch(erro){
   console.log(erro); 

} finally{
    console.log("executou");
}

console.log("teste");