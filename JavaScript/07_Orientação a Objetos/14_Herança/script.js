//Uma classee pode herdar propriedades e métodos de outra classe por herança
//parecido com prototype

//Para isso utilizamos o extends

class Mamifero {                //MAMIFERO é a classe pai
    constructor(patas){         //PATAS é a propriedade
        this.patas=patas;
    }
}

//A CLASSE CACHORRO É FILHA DE MAMIFERO
class Cachorro extends Mamifero{   
    constructor(patas, raca){ 
        super(patas); //usamos o super para informar que se trata sobrea a patas da Classe Cachrorro
        this.raca=raca; //raca de parametro recebe a raca informada aqui          
    }

    latir(){
        console.log("AU AU")
    }
}

let pug = new Cachorro(4, "PUG");

console.log(pug.patas);

