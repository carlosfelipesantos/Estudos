using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Construtor //É uma funcao que é chamada no momento da alocação do objeto d=na memória
{
    internal class Program
    {
        static void Main(string[] args)
        {   //alocando um novo objeto do tipo Filme na memoria. Construtor é justamente essa funcao que é chamada quando cria o objeto " = new Filme()"
            Filme filme = new Filme("Ta dando onda", "Surf de pinguim", 2009, "DreamWorks"); //Dentro dos parenteses eu preencho os valores do construtor 

            filme.Executar();

           

            //Qual a utilidade de criar um construtor em uma classe?

            /* Nao precisar digitar tudo isso manualmente
            filme.nome = "aaaa";
            filme.ano = 2011;
            filme.descr = "Filme de aventura";
            filme.studio = "NenhumCO"; */


            Console.ReadLine();
        }
    }
}
