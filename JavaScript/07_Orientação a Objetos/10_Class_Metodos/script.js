//classe é o molde, ex: classe cachorro: patas, cor, raca
//objeto ex: labrador = new cachorro: 4, marrom, viralata
//o objeto preenche a classe

//propriedades da classe devem ser adiconadas ou por consructor ou prottotype
class Cachorro {
    constructor(raca, patas, cor){ //adicionando propriedades via constructor
        this.raca = raca;
        this.patas = patas;
        this.cor = cor;
    }

    latir(){
        console.log("AU AU")
    }

}

Cachorro.prototype.olhos = 2; //adicionando propriedade via prototype

let labrador = new Cachorro("labrador", 4, "amarelo");
let doberman = new Cachorro("doberman", 4, "preto");

console.log(labrador.olhos);
console.log(doberman);

doberman.latir();

console.log(doberman);
console.log(labrador);