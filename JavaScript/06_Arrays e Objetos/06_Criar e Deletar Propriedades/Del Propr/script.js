let pessoa = {
    nome: "Matheus",
    idade: 29,
    profissao: "Programador", 
}

console.log(pessoa.nome);

//deletando
delete pessoa.nome;

//apos deletado aparece undefined
console.log(pessoa.nome);

console.log(pessoa);

//adicionando
pessoa.casado = true;

//aparece como uma nova propriedade
console.log(pessoa.casado);


console.log(pessoa)