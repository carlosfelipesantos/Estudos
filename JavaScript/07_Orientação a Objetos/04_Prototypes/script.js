//o prototype de pessoa, a hierarquia é o Object
let pessoa = {
    maos: 2,
}

//o prototpye de pessoaNova é pessoa, seguindo a ordem Object>pessoa>pessoaNova
let pessoaNova = Object.create(pessoa);


//pessoaNova acessa os mesmos metodos e propriedades de pessoa e de object
console.log(pessoaNova.maos);
console.log(Object.getPrototypeOf(pessoaNova) == pessoa);

// mesmo sem ter a propriedade maos, pessoaNova consegue buscar no prototype pessoa
//e esse hasOwnProperty, quando vai escrever nao aparece a recomendacao, pois ele é um metodo de object e mesmo assim pessoaNova consegue usar devido ao prototype
console.log(pessoaNova.hasOwnProperty('maos'));