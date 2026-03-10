//criando a classe
class Banco{
    constructor(saldo){ //atribuindo a propriedade saldo
    this.saldo = saldo;
    }
    deposito(valor){    //criando metodo deposito
       this.saldo += valor;
    }
    saque(valor){       //criando metodo saque
        this.saldo -= valor;
    }
}
    
//instanciando a classe
let nubank = new Banco(2000);

//testando metodo deposito
nubank.deposito(1000);

console.log(nubank.saldo);

//testando metodo saque
nubank.saque(500);

console.log(nubank.saldo);
