using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___Abstração  // É recomendado que se crie uma classe por arquivo
{
    internal class Program //classe principal do programa
    {
        static void Main(string[] args)
        {
            //criando novo filme
            Filme filme = new Filme();

            filme.nome = "Clube da Luta";
            filme.Executar();

            Filme filme2 = new Filme();
            filme2.nome = "Homem Aranha";
            filme2.Executar();


            Console.ReadLine();

        }
    }
}
