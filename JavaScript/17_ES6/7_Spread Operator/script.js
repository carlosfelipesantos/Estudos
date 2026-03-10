//Spread Operator pode ser utilizado em arrays e objetos
//Constitui novos valores destes dados em outros arrays e objetoss

//Ou seja podemos unir varios arrays de maneira simples
//Ou adicionar valores de um objeto a outro

const a1 = [1, 2, 3];
const a2 = [4, 5, 6];

const a3 = [...a1, ...a2];

console.log(a3);


const a4 = [9, ...a1, 8];
console.log(a4);


const carName = {name: 'gol'}
const carBrand = {brand: 'VW'}
const otherInfo = {km: '10000', price: 50000}

const car = {...carName, ...carBrand, ...otherInfo}

console.log(car);