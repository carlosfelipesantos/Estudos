const validarMarca = /Marca: (Nike|Adidas|Puma)/;

console.log(validarMarca.test("Marca: Nike"));
console.log(validarMarca.test("Marca: Puma"));
console.log(validarMarca.test("Marca: Nenhuma"));