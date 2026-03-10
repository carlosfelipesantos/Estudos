//construtor por funcoes é uma forma de imitar classes, criando um molde para objetos utilizando funcoes (pois em 2015, nao existia classes em javascript)


//a funcao recebe parametros que sao passados quando o objeto é criado
function criaCachorro(raca, patas, cor ){
    let cachorro = Object.create({});
    cachorro.raca = raca; //cachorro.raca é a propriedade que vem do objeto, = raca se refere ao parametro da funcao
    cachorro.patas = patas;
    cachorro.cor = cor;
    cachorro.latir = function(){
        console.log("AU AU")
    }
    return cachorro;
}

let doberman = criaCachorro("Doberman", 4, "preta");

console.log(doberman);
doberman.latir();