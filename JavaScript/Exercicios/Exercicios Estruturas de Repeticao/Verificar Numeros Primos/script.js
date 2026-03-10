let num =6;
let divisoes = 0;

for (let i =1; i<= num; i++){

    if(num % i == 0){
        divisoes++;
    }
}

if(divisoes ==2){
    console.log(`O numero ${num} e primo`);
}else {
    console.log(`O numero ${num} nao e primo`);
}














