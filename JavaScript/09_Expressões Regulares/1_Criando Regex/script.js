//criando e testando expressao regular


//testando atraves do .test se testando aparece dentro do texto ttttttestandooooooooo
console.log(/testando/.test("ttttestandooooooo")); //ou  const reg2 = /testando/;




//defini a palavra bola pra buscar
const reg1 = new RegExp('bola');


console.log(reg1.test("Aqui tem bola"));//retorna true
console.log(reg1.test("Aqui não tem"));//retorna false