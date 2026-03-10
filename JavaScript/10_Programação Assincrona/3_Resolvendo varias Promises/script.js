//Com o método all, podemos resolver várias promisses de uma vez 

//Passamos ela por um array e quando a ultima for resolvida, receberemos a resposta

//3 formas de criar uma Promise

//1° Forma
const p1 = new Promise(function(resolve, reject){
    setTimeout(() => {
        resolve(10);
    }, 5000);


})

//2°Forma
const p2 = Promise.resolve(10);

//3°Forma
const p3 = new Promise((resolve, reject)=>{
    resolve(10);
});

Promise.all([p1,p2,p3]).then((values)=>console.log("Promises Sucedidas"))