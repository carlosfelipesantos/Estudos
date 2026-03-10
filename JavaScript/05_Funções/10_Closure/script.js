function lembrarSoma(x){
    return function(y){
        return x + y;
    }
}
// criei a funcao lembrar soma e atribui X como primeiro parametro
// usei um return pra essa function com Y como segundo paramtro
// outro return só ue para somar os 2 parametros
let soma1 = lembrarSoma(2);

console.log(soma1(5));

//"divide" a soma de x + y em duas linhas de codigo, cria bifurcações no codigo

let soma2 = lembrarSoma(5);

console.log(soma2(5));






//Closure é quando uma função lembra das variáveis 
// do local onde foi criada,
// mesmo depois que esse local deixou de existir.





function contador(i){ //numero fica escondido dentro de Contador().
    let cont = i;
    let somarContador = function(){
        console.log(cont);
        cont++; //vai somar 1 quando chamar um numero mais abaixo
    }
    return somarContador;
}

//iniciara o contador em 5
let meuContador = contador(5);
meuContador(); //Toda vez que chamamos meucontador(),
meuContador(); // ele lembra do último valor e soma +1
meuContador();
meuContador();
meuContador();
meuContador();

//iniciara o contador em 1
let meuContador2 = contador(1);
meuContador2();
meuContador2();
meuContador2();
meuContador2();
 

