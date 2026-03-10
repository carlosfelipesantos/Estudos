class Carro {
    constructor(marca,cor,gasolinaRestante, consumo){
        this.marca=marca;
        this.cor=cor;
        this.gasolinaRestante=gasolinaRestante;
        this.consumo=consumo;
    }

    dirigir(km){

        let litrosCosumidos = km / this.consumo;
        this.gasolinaRestante -= litrosCosumidos;
    }

     abastecer(litros) {
        this.gasolinaRestante += litros;
    }

}



let carro = new Carro("Corsa", "Prata", 200, 14)




console.log(carro);

carro.dirigir(100);

console.log(carro);

carro.abastecer(10);