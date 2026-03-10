const question = document.querySelector("#question");
const answersBox = document.querySelector("#answers-box");
const quizzContainer = document.querySelector("#quizz-container");
const scoreContainer = document.querySelector("#score-container");

const letters = ["a", "b", "c", "d"];
let points = 0;
let actualQuestion = 0;

const questions = [
  {
    "question": "PHP foi desenvolvido para qual fim?",
    "answers": [
      { "answer": "back-end", "correct": true },
      { "answer": "front-end", "correct": false },
      { "answer": "Sistema operacional", "correct": false },
      { "answer": "Banco de dados", "correct": false },
    ]
  },
  {
    "question": "Uma forma de declarar variável em JavaScript:",
    "answers": [
      { "answer": "$var", "correct": false },
      { "answer": "var", "correct": true },
      { "answer": "@var", "correct": false },
      { "answer": "#let", "correct": false },
    ]
  },
  {
    "question": "Qual o seletor de id no CSS?",
    "answers": [
      { "answer": "#", "correct": true },
      { "answer": ".", "correct": false },
      { "answer": "@", "correct": false },
      { "answer": "/", "correct": false },
    ]
  },
  {
    "question": "Qual linguagem é usada para estruturar páginas da web?",
    "answers": [
      { "answer": "HTML", "correct": true },
      { "answer": "Python", "correct": false },
      { "answer": "CSS", "correct": false },
      { "answer": "SQL", "correct": false },
    ]
  },
  {
    "question": "Qual linguagem é usada para aplicar estilo visual em páginas web?",
    "answers": [
      { "answer": "HTML", "correct": false },
      { "answer": "Java", "correct": false },
      { "answer": "CSS", "correct": true },
      { "answer": "PHP", "correct": false },
    ]
  },
  {
    "question": "Qual é a saída do comando console.log(typeof 'Olá') em JavaScript?",
    "answers": [
      { "answer": "'string'", "correct": true },
      { "answer": "'text'", "correct": false },
      { "answer": "'char'", "correct": false },
      { "answer": "'object'", "correct": false },
    ]
  },
  {
    "question": "Qual desses NÃO é um tipo de dado em JavaScript?",
    "answers": [
      { "answer": "boolean", "correct": false },
      { "answer": "number", "correct": false },
      { "answer": "float", "correct": true },
      { "answer": "string", "correct": false },
    ]
  }
];


// Inicializa o quiz
function init() {
  scoreContainer.classList.add("hide");
  quizzContainer.classList.remove("hide");
  createQuestion(0);
}

// Cria a pergunta na tela
function createQuestion(i) {
  const oldButtons = answersBox.querySelectorAll("button");
  oldButtons.forEach(btn => btn.remove());

  const questionText = question.querySelector("#question-text");
  const questionNumber = question.querySelector("#question-number");

  questionText.textContent = questions[i].question;
  questionNumber.textContent = i + 1;

  questions[i].answers.forEach((answer, index) => {
    const answerTemplate = document.querySelector(".answers-template").cloneNode(true);
    answerTemplate.classList.remove("hide", "answers-template");

    const letterBtn = answerTemplate.querySelector(".btn-letter");
    const answerText = answerTemplate.querySelector(".question-answer");

    letterBtn.textContent = letters[index];
    answerText.textContent = answer.answer;
    answerTemplate.setAttribute("correct-answer", answer.correct);

    answersBox.appendChild(answerTemplate);

    answerTemplate.addEventListener("click", function () {
      checkAnswer(this);
    });
  });

  actualQuestion++;
}

// Checa a resposta do usuário
function checkAnswer(btn) {
  const buttons = answersBox.querySelectorAll("button");

  buttons.forEach(button => {
    if (button.getAttribute("correct-answer") === "true") {
      button.classList.add("correct-answer");

      if (btn === button) {
        points++;
      }
    } else {
      button.classList.add("wrong-answer");
    }
  });

  setTimeout(() => {
    if (actualQuestion >= questions.length) {
      showSuccessMessage();
    } else {
      createQuestion(actualQuestion);
    }
  }, 1500);
}

// Mostra a tela final
function showSuccessMessage() {
  hideOrShowQuizz();

  const score = ((points / questions.length) * 100).toFixed(2);
  document.querySelector("#display-score span").textContent = score;
  document.querySelector("#correct-answers").textContent = points;
  document.querySelector("#questions-qty").textContent = questions.length;
}

// Mostra ou esconde o quiz/resultados
function hideOrShowQuizz() {
  quizzContainer.classList.toggle("hide");
  scoreContainer.classList.toggle("hide");
}

// Botão de reinício
const restartBtn = document.querySelector("#restart");
restartBtn.addEventListener("click", () => {
  actualQuestion = 0;
  points = 0;
  init();
});

// Iniciar
init();
