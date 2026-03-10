//Arrow Functions cria funções de forma simples
//O this é relacionado ao elemento pai 
// de quem está a executando

//moda antiga
const sum = function sum(a,b){
    return a + b
}

console.log(sum(5,5));


//arrow
const arrowSum = (a, b) =>{
    return a + b
}
console.log(arrowSum(5,5));


//arrow mais curta (e mais comum)
const arrow = (a, b) => a + b

console.log(arrow(5,5));



//arrow com if
const saudacao = (nome)=>{
    if (nome){
        return 'Ola ' + nome + '!'
    } else {
        return 'Ola'
    }
}

console.log(saudacao("Chico"));


//arrow sem argumento/parametro
const testArrow = () => console.log('testou');
testArrow();

