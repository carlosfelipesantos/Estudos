        //CARACTERES ESPECIAIS

//      \d - Qualquer digito de caractere que contenha numero

//      \w - Um caractere alfanumerico ("teste")

//      \s - Qualquer caractere de espaço em branco

//      \D - Caracteres que nao sao digitos numericos

//      \W - Caractere nao=alfanumerico

//      \S - Caractere que nao seja espaco em branco

//      . - Qualquer caractere, menos nova linha


const pontoRegex = /./;
const dRegex = /\d/;

console.log(pontoRegex.test("asd"));
console.log(pontoRegex.test(" "));
console.log(pontoRegex.test("123"));


console.log(dRegex.test("123"));
console.log(dRegex.test(" "))
console.log(dRegex.test("asd "))