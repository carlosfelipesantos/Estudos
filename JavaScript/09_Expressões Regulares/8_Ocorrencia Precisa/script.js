const cep = /\d{5}-\d{3}/;

console.log(cep.test("15700-759"));
console.log(cep.test("15700-2"));

const telefone = /\(\d{2}\)\d{4,5}-\d{4}/;

console.log(telefone.test("(17)9999-9999"))