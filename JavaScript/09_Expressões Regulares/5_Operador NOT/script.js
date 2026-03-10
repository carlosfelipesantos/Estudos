const notab = /[^ab]/;

console.log(notab.test("a")); //retorna false, pois nega o A, ou seja retorna o oposto
console.log(notab.test("aqui tem a")); 


const nottoaz = /[^a-z]/;
console.log(nottoaz.test("asd")); //é negado, pois nega tudo do a - z