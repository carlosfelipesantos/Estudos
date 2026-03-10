//verificar quem é o pai do objeto utilizando instanceof


class Mamifero {                //MAMIFERO é a classe pai
    constructor(patas){         //PATAS é a propriedade
        this.patas=patas;
    }
}

//A CLASSE CACHORRO É FILHA DE MAMIFERO
class Cachorro extends Mamifero{   
    constructor(patas, raca){ 
        super(patas);
    }

    latir(){
        console.log("AU AU")
    }
}


console.log(new Cachorro instanceof Mamifero);
