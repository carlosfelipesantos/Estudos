let frutas = /\d+ (bananas|maças|laranjas)/;

console.log(frutas.test("10 bananas"));
console.log(frutas.test("20 batatas"));
console.log(frutas.test("4 laranjas"));