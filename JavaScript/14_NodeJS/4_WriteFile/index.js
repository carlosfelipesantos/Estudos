//escrevendo arquivos

let {writeFile, readFile} = require('fs');

readFile("arquivo.txt", "utf8", (error, texto) =>{
    if(error){
        throw error;
    } else{
        console.log(texto);
    }
});


writeFile("arquivo.txt", "Texto por writefile", (error)=>{

    if(error){
        throw error;
    }else{
        console.log("Escreveu com sucesso");
    }
});