let nums = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

//precisa definir um fim de intervalo, mas ele para 1 antes
// ou seja, aqui quero pegar o index 4, entao coloco de 4 a 5
console.log(nums.slice(4,5));


//ja aqui quero pegar 4 e 5, 
//entao defino o fim do intervalo como 6, pq para 1 antes
console.log(nums.slice(4, 6));


//se eu nao definir um indice final
//ele pega ate o fim do array
console.log(nums.slice(2));


// de tras para frente
console.log(nums.slice(-2));


//do indice 3 ate o final exceto com os 2 ultimos
// sem o 8 e 9
console.log(nums.slice(3, -2));
