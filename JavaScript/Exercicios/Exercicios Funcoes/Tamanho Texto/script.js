function tamanhoTexto(texto) {
    if (texto.length > 10) {
        console.log("Texto muito longo");
     } else {
        console.log("Texto dentro do limite");
     }
}

tamanhoTexto("texto ");
tamanhoTexto("TEXTO LONGO DEMAIS");
