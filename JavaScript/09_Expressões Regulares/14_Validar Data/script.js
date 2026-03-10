let validarData = /[0-9]{2}[/][0-9]{2}[/][0-9]{4}/;

console.log(validarData.test("24/08/2004"));
console.log(validarData.test("4/8/2004"));
console.log(validarData.test("4/08/2005"));
console.log(validarData.test("24/08/2004"));