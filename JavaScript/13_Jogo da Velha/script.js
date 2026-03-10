let X = document.querySelector(".X");
let o = document.querySelector(".o");
let boxes = document.querySelectorAll(".box");
let buttons = document.querySelectorAll("#buttons-container button");
let messageContainer = document.querySelector("#message");
let messageText = document.querySelector("#message p");
let secondPlayer;

// contador de jogadas
let player1 = 0;
let player2 = 0;


//adicionando o evento de click aos boxes
for (let i = 0; i < boxes.length; i++) {

    //quando usuario clica na caixa
    boxes[i].addEventListener("click", function () {
        let el = checkEl(player1, player2);

        //verifica se ja tem x ou bolinha
        if(this.childNodes.length==0){
            
        let cloneEl = el.cloneNode(true);
        this.appendChild(cloneEl);


        //computar jogadas
        if (player1 == player2) {
            player1++;

        if(secondPlayer=="ai-player"){

            //funcao executar a jogada
            computerPlay();
            player2++;
        }


        } else {
            player2++;
        }

        //checar vencedor
        checkWinCondition();

        }
    })
}


// evento para saber se é 2 players ou IA

for(let i = 0; i <buttons.length; i++){
    buttons[i].addEventListener("click", function(){

        secondPlayer = this.getAttribute("id");

        for(j = 0; j <buttons.length; j++){
            buttons[j].style.display = 'none';
        }

        setTimeout(function(){

            let container = document.querySelector("#container");
            container.classList.remove("hide");

        },150);

    });
}



//verificar a vez de que joga
function checkEl(){

    if(player1 == player2){
        el = X;
    } else{
        el = o;
    }
    return el;
}


function checkWinCondition(){
    let b1 = document.getElementById("block-1");
    let b2 = document.getElementById("block-2");
    let b3 = document.getElementById("block-3");
    let b4 = document.getElementById("block-4");
    let b5 = document.getElementById("block-5");
    let b6 = document.getElementById("block-6");
    let b7 = document.getElementById("block-7");
    let b8 = document.getElementById("block-8");
    let b9 = document.getElementById("block-9");

    //horizontal
    if(b1.childNodes.length>0 && b2.childNodes.length && b3.childNodes.length>0){
        let b1Child = b1.childNodes[0].className;
        let b2Child = b2.childNodes[0].className;
        let b3Child = b3.childNodes[0].className;

        if(b1Child =="X" && b2Child =="X" && b3Child =="X"){
       declararWinner("X")
         return;
        }else if(b1Child =="o" && b2Child =="o" && b3Child =="o"){
        declararWinner("o")
          return;
        }

    }

     //horizontal 2 linha
    if(b4.childNodes.length>0 && b5.childNodes.length && b6.childNodes.length>0){
        let b4Child = b4.childNodes[0].className;
        let b5Child = b5.childNodes[0].className;
        let b6Child = b6.childNodes[0].className;

        if(b4Child =="X" && b5Child =="X" && b6Child =="X"){
       declararWinner("X")
         return;
        }else if(b4Child =="o" && b5Child =="o" && b6Child =="o"){
          declararWinner("o")
            return;
        }

    }

    
     //horizontal 3 linha
    if(b7.childNodes.length>0 && b8.childNodes.length && b9.childNodes.length>0){
        let b7Child = b7.childNodes[0].className;
        let b8Child = b8.childNodes[0].className;
        let b9Child = b9.childNodes[0].className;

        if(b7Child =="X" && b8Child =="X" && b9Child =="X"){
        declararWinner("X")
          return;
        }else if(b7Child =="o" && b8Child =="o" && b9Child =="o"){
          declararWinner("o")
            return;
        }

    }


    
     //vertical
    if(b1.childNodes.length>0 && b4.childNodes.length && b7.childNodes.length>0){
        let b1Child = b1.childNodes[0].className;
        let b4Child = b4.childNodes[0].className;
        let b7Child = b7.childNodes[0].className;

        if(b1Child =="X" && b4Child =="X" && b7Child =="X"){
        declararWinner("X")
          return;
        }else if(b1Child =="o" && b4Child =="o" && b7Child =="o"){
         declararWinner("o")
           return;
        }

    }

     
     //vertical 2 coluna
    if(b2.childNodes.length>0 && b5.childNodes.length && b8.childNodes.length>0){
        let b2Child = b2.childNodes[0].className;
        let b5Child = b5.childNodes[0].className;
        let b8Child = b8.childNodes[0].className;

        if(b2Child =="X" && b5Child =="X" && b8Child =="X"){
       declararWinner("X")
         return;
        }else if(b2Child =="o" && b5Child =="o" && b8Child =="o"){
         declararWinner("o")
           return;
        }

    }

     //vertical 3 coluna
    if(b3.childNodes.length>0 && b6.childNodes.length && b9.childNodes.length>0){
        let b3Child = b3.childNodes[0].className;
        let b6Child = b6.childNodes[0].className;
        let b9Child = b9.childNodes[0].className;

        if(b3Child =="X" && b6Child =="X" && b9Child =="X"){
       declararWinner("X")
         return;
        }else if(b3Child =="o" && b6Child =="o" && b9Child =="o"){
          declararWinner("o")
            return;
        }

    }


     //diagonal
    if(b1.childNodes.length>0 && b5.childNodes.length && b9.childNodes.length>0){
        let b1Child = b1.childNodes[0].className;
        let b5Child = b5.childNodes[0].className;
        let b9Child = b9.childNodes[0].className;

        if(b1Child =="X" && b5Child =="X" && b9Child =="X"){
        declararWinner("X")
          return;
        }else if(b1Child =="o" && b5Child =="o" && b9Child =="o"){
          declararWinner("o")
            return;
        }

    }

     //diagonal 2
    if(b3.childNodes.length>0 && b5.childNodes.length && b7.childNodes.length>0){
        let b3Child = b3.childNodes[0].className;
        let b5Child = b5.childNodes[0].className;
        let b7Child = b7.childNodes[0].className;

        if(b3Child =="X" && b5Child =="X" && b7Child =="X"){
        declararWinner("X")
          return;
        }else if(b3Child =="o" && b5Child =="o" && b7Child =="o"){
         declararWinner("o")
           return;
        }

    }
    
    //deu velha
    let counter = 0;

    for(let i =0; i<boxes.length; i++){
        if(boxes[i].childNodes[0] != undefined){
            counter++;
        }
    }

    if(counter ==9){
       declararWinner("Deu velha");
    }
}



//limpar o jogo, declarar vencedor e atualizar placar
function declararWinner(winner){

    let scoreboardX = document.querySelector("#scoreboard-1");
    let scoreboardO = document.querySelector("#scoreboard-2");
    let msg = '';

    if(winner == "X"){
        scoreboardX.textContent = parseInt(scoreboardX.textContent) +1;
        msg = "O jogador 1 venceu!";
   
    } else if(winner == "o"){
        scoreboardO.textContent = parseInt(scoreboardO.textContent) +1;
        msg = "O jogador 2 venceu!";
    } else {
        msg ="Deu velha!";
    }

 //exibir mensagem
 messageText.innerHTML=msg;
 messageContainer.classList.remove("hide");


//esconde mensagem
setTimeout(() => {
    messageContainer.classList.add("hide");
}, (3000));

//zerar jogadas
player1=0;
player2=0;

let boxesToRemove = document.querySelectorAll(".box div");

for(let i =0; i<boxesToRemove.length; i++){
    boxesToRemove[i].parentNode.removeChild(boxesToRemove[i]);
}


}

//executar a logica da jogada da IA
function computerPlay(){

    let clone0 = o.cloneNode(true);
    counter = 0;
    filled = 0;

    for(let i =0; i <boxes.length; i++){

    let randomNumber = Math.floor(Math.random()*5);

    //só preencher se estiver vazio o filho
    if(boxes[i].childNodes[0]==undefined){
        if(randomNumber <=1){
           boxes[i].appendChild(clone0);
           counter++;
           break;
        }
    //checagem de quantas estao preenchidas
    }else{
        filled++;
    }

    }

    if (counter==0 && filled <9){
        computerPlay();
    }

}



const toggleDark = document.getElementById("toggle-dark");

toggleDark.addEventListener("click", () => {
    document.body.classList.toggle("dark-mode");

    // Alternar texto do botão
    if (document.body.classList.contains("dark-mode")) {
        toggleDark.textContent = "☀️ Modo Claro";
    } else {
        toggleDark.textContent = "🌙 Modo Escuro";
    }
});
