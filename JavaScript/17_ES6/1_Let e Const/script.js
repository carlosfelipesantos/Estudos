// 1 - var, let e const


//var = o escopo global é alterado por meio de um if
var x = 10;
var y = 15;

if(y>10){
var x = 5
    console.log(x)
}

console.log(x);




//let/const = escopo gloal nao é alterado por um if
let a = 10;
let b = 15;

if(b>10){
    let a=5
    console.log(a);
}

console.log(a);



