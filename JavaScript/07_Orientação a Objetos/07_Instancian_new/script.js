//construtor por new, new serve para instanciar classes

//a primeira letra maiuscula (convenção) em Cachorro, determina que essa funcao é uma classe
function Cachorro(raca, patas, cor ){
    let Cachorro = Object.create({});
    this.raca = raca;
    this.patas = patas;
    this.cor = cor;
    this.latir = function(){
        console.log("AU AU")
    }
  
}

let doberman = new Cachorro("doberman", 4, "preta");

console.log(doberman);
doberman.latir();