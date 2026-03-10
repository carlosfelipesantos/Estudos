//Filter é um metodo de array para filtrar dados 

const arr = [1, 2, 3, 4, 5]

const highNumbers = arr.filter((n)=>{
    if( n >= 3){
        return n

    }
})

console.log(arr);
console.log(highNumbers);


const users = [
    { name: 'Carlos', avaliable:true},
    { name: 'Pedro', avaliable:false},
    { name: 'Joao', avaliable:true},
    { name: 'Marcos', avaliable:false},
]

const avaliableUsers = users.filter((user)=>user.avaliable);

console.log(avaliableUsers);