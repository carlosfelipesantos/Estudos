class Conta {
    constructor(saldoCC,saldoCP,jurosP){
        this.saldoCC=saldoCC;
        this.saldoCP=saldoCP;
        this.jurosP=jurosP;
    }

    depositoCC(valor){
        this.saldoCC += valor;
    }

     saqueCC(valor) {
        this.saldoCC -= valor;
    }

    
    depositoCP(valor){
        this.saldoCP += valor;
    }

     saqueCP(valor) {
        this.saldoCP -= valor;
    }


    transferirCP(valor) {
        this.saldoCC -= valor;
        this.saldoCP += valor;
    }

    transferirCC(valor){
        this.saldoCP -= valor;
        this.saldoCC +=valor;
    }


}

class ContaEspecial extends Conta{
    constructor(saldoCC, saldoCP, jurosP){
    super(saldoCC, saldoCP, jurosP*2)
        }
}




let conta = new Conta(1000, 500, 1);

console.log(conta);

conta.transferirCC(500);

console.log(conta);


let conta2 = new ContaEspecial(10000, 50000, 1);

console.log(conta2);