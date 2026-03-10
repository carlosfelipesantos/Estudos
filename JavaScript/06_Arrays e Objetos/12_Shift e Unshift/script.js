let carros = ["BMW", "AUDI", "VW","FIAT"];

let removerPrimeiroCarro = carros.shift();

console.log(removerPrimeiroCarro);
console.log(carros);

carros.unshift("Chevrolet");

console.log(carros);
console.log(carros[0]);