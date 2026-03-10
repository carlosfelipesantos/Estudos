using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_de_Sobreposicao
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;


        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }


       
        public void Logar()
        {
            Console.WriteLine("Logando...");
        }

        //Assinatura Logar (string)
        public void Logar(string codigo)
        {
            Console.WriteLine("Logando com codigo...");
        }

        //Assinatura Logar (string, string)
        public void Logar(string codigo, string senha)
        {
            Console.WriteLine("Logando com codigo...");
        }

        //Assinatura Logar (string, int)
        public void Logar(string codigo, int pin)
        {
            Console.WriteLine("Logando com codigo...");
        }



        public virtual void Exibir() //Virtual: esse metodo pode ser sobreescrito nas classes filhas
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Senha: {senha}");
        }


    }





    class Aluno : Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

        public Aluno(string turno, string nomeParametro, string emailParametro, string senhaParametro) : base(nomeParametro, emailParametro, senhaParametro) 
        {
            this.turno = turno;

        }

        //"Refiz o metodo"
        public override void Exibir()//Override: sobrepor o metodo exibir da classe pai (Usuario)
        {
            Console.WriteLine("Dados do aluno: ");
            base.Exibir();//quando eu chamar o metodo exibir pela classe filha (Aluno), primeiramente vai rodar o metodo da classe pai(Usuario)
            Console.WriteLine("Turno: " + turno);

        }

    }

    class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();
        public string salario = "100";

        public Zelador(string salario, string nomeParametro, string emailParametro, string senhaParametro) : base(nomeParametro, emailParametro, senhaParametro)
        {
            this.salario = salario;
        }

    }



}
