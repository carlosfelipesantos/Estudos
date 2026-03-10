class Carrinho {
    constructor(total, valor) {
        this.itens = [];
        this.total = total;
        this.valor = valor;
    }
 
    adicionar(item, valor) {
        this.itens.push(item);
        this.total = this.itens.length;
        this.valor = this.valor + valor;
    }
 
    remover(item,valor) {
        this.itens.splice(item, 1);
        this.total -= 1;
        this.valor -= valor;
    }
}

//começa em 0, pois quando um carrinho é criado, ele ainda não tem nenhum item
const meuCarrinho = new Carrinho(0, 0);

// Adicionando itens, camiseta é para o parametro item, e 50 para o valor
meuCarrinho.adicionar("camiseta", 50);
meuCarrinho.adicionar("tenis", 200);

console.log(meuCarrinho); 
// Deve mostrar: itens: ["camiseta", "tenis"], total: 2, valor: 250

// Removendo o primeiro item (índice 0) e 50 por causa do valor
meuCarrinho.remover(0, 50);

console.log(meuCarrinho);
// Deve mostrar: itens: ["tenis"], total: 1, valor: 200

