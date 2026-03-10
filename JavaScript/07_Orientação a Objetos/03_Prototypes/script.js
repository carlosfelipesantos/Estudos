//https://www.youtube.com/watch?v=yke9m4V9UWQ

//PROPRIEDADE = VALOR DE UM OBJETO
//METODO = PROPRIEDADE COM FUNCAO ATRIBUIDA
//PROTOTYPE = CONSULTA LISTA DE METODOS PARA UM OBJETO SEJA ELE ARRAY OU OBJETO CRIADO POR MIM MESMO 

//PROTOTYPE SERIA UM ESQUEMA DE HERANÇA DE METODOS

// METODO EM STRING blablabla.toUpperCase (é algo reservado na linguagem para deixar strings maiusculas)



//isso é uma funcao construtora em que retorna a propriedade nome + o metodo "fez login"
function student(nome, email){
    this.nome =nome
    this.email=email

//o método login esta dentro da funcao construtora e cada vez que ela é chamanda, ele é criado NOVAMENTE dentro do objeto, ocupando muito espao na memória
 
/*/   this.login = function(){
        return `${this.nome} fez login` 
    }
/*/

}

//para de declarar um metodo nos objetos que a funcao construtoria ira criar, sem ocupar espaço igual acima, é criado o metodo no prototype, sem armazenar no objeto varias vezes
student.prototype.login = function(){
    return`${this.nome} fez login`
}

//aqui ele atribui = new student (ou seja, a funcao usa os valores nas aspas para seus parametros)
const gabrielFialho = new student('Gabriel Fialho', 'gabriel@gmail.com')
const brenoLemos = new student('Breno Lemos', 'brenolemos@gmail.com')

//aqui mostra que mesmo os dois usando o mesmo metodo (login), nao sao iguais, nao pelos valores informados serem diferentes, mas sim por ter criado "2 logins"
console.log(gabrielFialho, brenoLemos)

//se o objeto nao contem o metodo login como no caso, automaticamente o javascript procura no prototype do objeto
console.log(gabrielFialho.login === brenoLemos.login)





//NESSE EXEMPLO ABAIXO USAREI O PROTOTYPE PARA HERDAR COMPORTAMENTO

const animal = {
    som:"um som generico de animal",
    tipo:'animal',
    emitirSom: function(){  //essa funcao emitirSom basicamente verifica se tem a propriedade SOM no objeto cujo ela esta atraves do "this", caso tenha ela retorna oq estiver em som
        console.log(this.som) // por exemplo, em animal tem som, entao retorna "um som generico de animal
    }
}

const gato = {
    tipo: "gato",
    som:"miau"
}

//esse comando diz que o prototype (pai) de gato é o objeto animal
Object.setPrototypeOf(gato, animal)


gato.emitirSom() // como eu disse da funcao anteriormente, ela verifica se tem som no objeto, agora no objeto gato tem o som "MIAU" que sera retornado, 
// mas caso eu nao tenha colocado som no objeto gato, retornara o som do prototype de gato que é animal, retorando "um som generico de animal"


const gatoRaivoso = {
    tipo: "gatoRaivoso",
    miarForte: function(){
        console.log(this.som.toUpperCase())// como ele nao tem som, vai pegar o som do objeto prototpye dele (gato) e adicionei o Upper pra deixar o som "mais forte"
    }
}

Object.setPrototypeOf(gatoRaivoso, gato) //gatoRaivoso é  filho do prototype gato
gatoRaivoso.miarForte() 

