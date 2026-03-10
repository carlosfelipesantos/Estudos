//Destructuring é um recurso para arrays e objetos
//transformando-os em variaveis

const fruits = ["Maça", "Laranja", "Uva"]

const [f1, f2, f3] = fruits;

console.log(f1);
console.log(f2);
console.log(f3);


const productDetails = {
    name:"Teclado", 
    price: 30.99,
    category:"Perifericos",
    color:"Cinza"
}

const {name:productName, price, category:productCategory, color}=productDetails;

console.log(`O nome do produto é ${productName}, custa R$ ${price}, pertence a categoria ${productCategory}, e é da cor ${color}`)