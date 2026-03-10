//podemos mudar a propriedade do prototype mesmo depois da classe instanciada, tendo uma constante como valor do prototype

//por exemplo, podemos deixar como "padrao" no prototype que o cachrro tem 4 patas, mas podendo mudar caso alguns tenham 3
class Cachorro {
    constructor(raca, patas, cor){
        this.raca = raca;
        this.patas = patas;
        this.cor = cor;
    }

    latir(){
        console.log("AU AU")
    }

}

//valor padrao no prototype para propriedade "raca"
Cachorro.prototype.raca ="SRD";
Cachorro.prototype.patas = 4;

//valores novos para propriedadea raca (caso n tenha ficaria o SRD)
let labrador = new Cachorro("labrador", 4, "amarelo");
let doberman = new Cachorro("doberman", 4, "preto");

console.log(labrador.olhos);
console.log(doberman);

doberman.latir();

console.log(Cachorro.prototype.raca);
console.log(labrador.raca);