using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_em_Herança
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


        //Polimorfismo de sobrecarga, ter varias funcoes com o mesmo nome, basta a assinatura ser diferente:
        //Desde que seja diferente o Nome, o tipo ou ordem de parametro (se tiver um parametro do tipo string so, e duas funcoes retornarem isso nao funciona)
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



        public void Exibir()
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

        public Aluno(string turno, string nomeParametro, string emailParametro, string senhaParametro) : base(nomeParametro, emailParametro, senhaParametro) //base é uma palavra reservada que faz referencia a classe pai
        { 
            this.turno = turno;

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
