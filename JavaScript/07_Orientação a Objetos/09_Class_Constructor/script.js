class Cachorro {
    constructor(raca, patas, cor){
        this.raca = raca;
        this.patas = patas;
        this.cor = cor;
    }
}

let labrador = new Cachorro("labrador", 4, "amarelo");
let doberman = new Cachorro("doberman", 4, "preto");

console.log(labrador);
console.log(doberman);