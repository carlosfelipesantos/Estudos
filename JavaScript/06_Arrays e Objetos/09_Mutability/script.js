let pessoa ={
    nome: "Carlos"
}

let pessoa2 = pessoa;

console.log(pessoa == pessoa2); //true, pois sao iguais

//por eu ter mudado o nome de pessoa2 para Pedro
// pessoa1 tambem muda o nome para Pedro
// pois o 2 é referencia do 1, esse é o conceito de mutação
pessoa2.nome = "Pedro";

console.log(pessoa.nome);

//ou seja independente do objeto pessoa que eu mudar o nome
// mudara no referenciado e vice versa


let pessoa3 = {
    nome:" Pedro"
};

console.log(pessoa2==pessoa3);//apesar de ser o mesmo nome, nao sao referenciados
console.log(pessoa==pessoa3);