using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        private string teste; //privado limita o campo apenas a classe que ele foi criado, ou seja me, com heranca ele é passado, serve para ser um campo unico na classe pai 
       
        protected string coisa; //o campo é privado, porem tambe pode ser acessado pela classe dos filhos


        public void Logar()
        {
            Console.WriteLine(teste);
            Console.WriteLine("Logando...");
        }
    }

    //Projeto real utiliza uma classe por arquivo, aqui é so pra estudos vai ser no mesmo

    class Aluno: Usuario //Classe aluno herda de Usuario (no C# a classe so pode ter um pai)
        {
            public List<string> turmas = new List<string>();
            public string turno = "Matutino";
        }



  
}
