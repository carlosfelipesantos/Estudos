//SYMBOLS = propriedades unicas que nao podem ser alteradas e nem criadas duas vezes
//podemos utilizar como uma constante, so que para propriedade de objeto

class Cachorro {
    constructor(raca,cor){
        this.raca = raca;
        this.cor = cor;

    }

    latir(){
        console.log("AU AU")
    }

}

Cachorro.prototype.raca ="SRD"


//criando syymbol
let patas = Symbol();

Cachorro.prototype[patas] = 4;

let labrador = new Cachorro("labrador", "amarelo");
let doberman = new Cachorro("doberman", "preto");


console.log(doberman);

doberman.latir();

console.log(Cachorro.prototype.raca);
console.log(labrador.raca);


//acessando symbol nao para evitar valores duplicados
// mas sim para evitar que valores sejam subescritos
console.log(Cachorro.prototype[patas]);

console.log(labrador[patas]);