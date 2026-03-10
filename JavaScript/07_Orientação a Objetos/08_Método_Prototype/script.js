//maneira correta de criar metodo em classe/objeto, no prototype

function Cachorro(raca, cor, patas){
    this.raca=raca;
    this.cor=cor;
    this.patas=patas;
}


//as classes ficam apenas com as propriedades, e o prototype separa os metodos
//deixando mais limpo e organizado

Cachorro.prototype.uivar = function(){
    console.log("AUUUUUU");
}

let husky = new Cachorro('Husky', 4, 'cinza');

husky.uivar();