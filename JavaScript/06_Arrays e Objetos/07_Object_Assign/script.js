let carro = {
    portas: 4,
    portamalas: 200,
    cor: "PRATA",
}
 
let adicionais ={
    tetoSolar: true,
    arCondicionado: true,
}

Object.assign(carro, adicionais);

console.log(carro);
