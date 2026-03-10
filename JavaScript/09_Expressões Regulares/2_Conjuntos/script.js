//definir um conjunto de caracteres e ver se existe

//os colchetes [], representam intervalos
console.log(/[123]/.test("Existe 123 aqui: ")); //retorno true

//o tracinho é para um intervalo maior
console.log(/[0-9]/.test("O numero 8 esta presente aqui ")); //retorno true


const reg1 = /[123]/;

console.log(reg1.test(" 123 Estao presentes: "))