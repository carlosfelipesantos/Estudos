using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_em_Herança
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;

        //Construtor na classe pai
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
    

      //Se tiver construtor na classe pai, deve se ter na classe filho
    public Aluno(string turno, string nomeParametro, string emailParametro, string senhaParametro) : base(nomeParametro, emailParametro, senhaParametro) //base é uma palavra reservada que faz referencia a classe pai
        {   //Quando eu passar os valores para essas variaveis, da classe aluno, o construtor da classe pai var ser rodado tambem
            this.turno = turno;

        }

    }
    

} 
