//criei um objeto cachorro, que recebe como propriedade raca
// e tem dois metodos(tipo funcoes) que fazem acoes como uivar/rosnar
const cachorro = {
    raca:'SRD',
    uivar:function(){
        console.log("AUUUUU");
    },
    rosnar:function(){
        console.log("GRRRRRR");
    },
    setRaca: function(raca){    
//esse setRaca é uma funcao, em que o valor informado nela, é atribuido como propriedade para o objeto cachorro
        this.raca=raca;
    },
    getRaca: function(){
        return "A raça é " + this.raca;
    }
}

//exibindo a raca predefinida (SRD)
console.log(cachorro.raca);

//usando a setRaca para atribuir Pastor Alemao a propriedade raca
cachorro.setRaca("Pastor Alemao");

//exibindo a raca atual (Pastor Alemao)
console.log(cachorro.raca);

console.log(cachorro.getRaca());