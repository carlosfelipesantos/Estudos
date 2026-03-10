        //CARACTERES ESPECIAIS

//      \d - Qualquer digito de caractere que contenha numero

//      \w - Um caractere alfanumerico ("teste")

//      \s - Qualquer caractere de espaço em branco

//      \D - Caracteres que nao sao digitos numericos

//      \W - Caractere nao=alfanumerico

//      \S - Caractere que nao seja espaco em branco

//      . - Qualquer caractere, menos nova linha



let letrasMaisculas = /[A-Z]/;  
console.log(letrasMaisculas.test("Ola"));
console.log(letrasMaisculas.test("joao"));
console.log(letrasMaisculas.test("JOAO"));