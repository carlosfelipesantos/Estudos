let nomes = ["carlos", "chopp", "schopenhauer", "arthur", "bolinha", ]

let numeros = [1,2,3];

function verificarQuantidade (blabla){
    if (blabla.length<5){
        console.log("Poucos elementos")
    } else {
        console.log("Muitos elementos")
    }
}

console.log(verificarQuantidade(nomes));
console.log(verificarQuantidade(numeros));