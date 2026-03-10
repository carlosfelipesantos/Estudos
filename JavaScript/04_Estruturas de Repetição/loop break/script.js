let nome = "Carlos";

for(let i = 0; i < 10; i = i + 1){
  


  if(i==3) {
  nome="Felipe";
  }

  if(i == 5 && nome == "Felipe")  {
    console.log("O nome é Felipe, pode parar");
    break;
  }

  console.log(i, nome);
  

}