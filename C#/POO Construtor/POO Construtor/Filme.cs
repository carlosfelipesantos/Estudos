using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Construtor
{
    internal class Filme
    {
        public string nome;
        public string descr;
        public int ano;
        public string studio;
        public List<string> atores = new List<string>();

        static public string plataforma = "Netflix";

        //Criando meu construtor, deve se utilizar exatamente o mesmo nome da classe, construtor é uma funcao especial para preencher os dados da classe em um novo objeto instanciado
        //Pode se colocar parametros no construtor, igual qualquer outra funcao
        public Filme(string nome, string descr, int ano, string studio) 
        {
            //this serve para dizer que o atributo da classe, recebe o valor do parametro do constructor(funcao)
            this.nome = nome;
            this.descr = descr;
            this.ano = ano;
            this.studio = studio;


            //Dentro do construtor nao é limitado a somente passar valores, pode executar qualquer logica
            Console.WriteLine("C# é muito legal");
            //Sempre que um novo objeto é instanciado, o construtor é chamado e a mensagem é exibida


        } 



        public void Executar()
        {
            Console.WriteLine("Rodando Filme: " + nome);

        }

    }
}
