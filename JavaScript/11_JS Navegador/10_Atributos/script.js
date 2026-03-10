//MODIFICANDO E LENDO ATRIBUTOS

//Podemos resgatar o valor de um atributo ou trocar com o JS;

//Por exemplo o HREF de um A, ou SRC de um elemento IMG;

//getAttribute pega o valor,
//setAttribute atualiza o valor.


let a = document.querySelector("footer a");

console.log(a.getAttribute("href")); //pegando o valor de a

let link = 'https://www.horadecodar.com.br';

a.setAttribute('href', link); //atualizo o valor 
