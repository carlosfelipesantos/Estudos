//Get: serve para resgatar o valor de uma propriedade
//Set: serve para alterar o valor de uma propriedade

//sao metodos que setam/alteram propriedades de objetos

class Cachorro {
    constructor(raca,cor){
        this.raca = raca;
        this.cor = cor;
    }

    get verCor(){ //mostrar a Cor pra quem consultar
        return `A cor do cachorro é : ${this.cor}`;
    }

    set novaCor(cor){ //alterando para uma nova Cor
        this.cor = cor;
    }

}

//por padrao o Cachorro esta sem cor
let pastor = new Cachorro('Pastor Alemao', 'Sem cor');
console.log(pastor);

//usando o set para altarar a cor
pastor.novaCor = "Marrom";

//usando o get para consultar a cor
console.log(pastor.verCor);