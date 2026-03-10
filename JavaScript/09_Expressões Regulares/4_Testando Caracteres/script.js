        //CARACTERES ESPECIAIS

//      \d - Qualquer digito de caractere que contenha numero

//      \w - Um caractere alfanumerico ("teste")

//      \s - Qualquer caractere de espaço em branco

//      \D - Caracteres que nao sao digitos numericos

//      \W - Caractere nao=alfanumerico

//      \S - Caractere que nao seja espaco em branco

//      . - Qualquer caractere, menos nova linha



let ano = /\d\d\d\d/;  //basicamente impoe que ano terá 4 digitos e todos serao alfanumericos, caso cumpra esses requisitos retorna true
console.log(ano.test("05"));
console.log(ano.test("2019") && "2019".length == 4);//impoe mais um requisito, ter 4 caracteres
console.log(ano.test("201999") && "201999".length == 4);


let palavrasTresLetras = /\w\w\w/; 
console.log(palavrasTresLetras.test("Ola"));
console.log(palavrasTresLetras.test("oi"));
console.log(palavrasTresLetras.test("falso") && "falso".length==3); //sem esse &&, retornaria true, ele serve como mais uma condicao a ser atendida