//deixa algo opcional como o x do abacaxi, que qualquer coisa no lugar da ? retorna true
const padrao = /Abacax?i/;

console.log(padrao.test("Abacaxi"));
console.log(padrao.test("Abacai"));

const padrao2 = /\d+\w?/;
console.log(padrao2.test("123"));
console.log(padrao2.test("123ab"));
console.log(padrao2.test("123 "));