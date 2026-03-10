// Map é um metodo de array que percorre elementos
//Usamos quando queremos modificar os dados do array


const produtos = [
    {name: 'Camisa', preço: 10.99, category: 'Roupas'},
    {name: 'Chaleira', preço: 49.99, category: 'Eletro'},
    {name: 'Fogão', preço: 400, category: 'Eletro'},
    {name: 'Jeans', preço: 50.99, category: 'Roupas'},
]

produtos.map((produto) => {
    if(produto.category === 'Roupas'){
        produto.onSale = true
    }
})

console.log(produtos);

