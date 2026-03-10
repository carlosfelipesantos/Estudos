let pessoa = {
    "nome": "carlos",
    "idade": 20,
    "sexo": "masculino",
    "profissao": "programador",
    "hobbies": ["jogar", "estudar", "correr"]
}

let pessoaTexto = JSON.stringify(pessoa);

console.log(pessoaTexto);

//nao aparece a propriedade nome pois pessoa agora é uma string
console.log(pessoa.nome); 


//volta a ser JSON e se torna possivel consultar propriedades
let pessoaJSON = JSON.parse(pessoaTexto);
console.log(pessoaJSON);
console.log(pessoaJSON.hobbies[0])
