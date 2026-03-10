//Generators funcionam semelhante as Promises

//Onde ações podem ser pausadas e continuadas depois

//Caracterizados pelo function* e yield

function* genTest(){
    let id=0;
    while(true){
        yield id++;
    }
}

let criarId= genTest();

console.log(criarId.next().value);
console.log(criarId.next().value);
console.log(criarId.next().value);