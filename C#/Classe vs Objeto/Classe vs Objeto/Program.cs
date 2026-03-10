using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_vs_Objeto
{
    internal class Program   //Instancia de uma Classe é uma "copia de uma classe"
        //Tudo criado de uma classe é um objeto

    {

        
        static void Main(string[] args)
        {
            //exibindo variavel statica
            Console.WriteLine(Filme.plataforma);
           
            Filme.Pausar();


        /* Usando metodo sem static, necessario instanciar um objeto:          
            Filme filme = new Filme(); // alocando na memória uma variavel(instancia) com a mesma estrutura de uma classe filme
            filme.nome = "Taxi Driver";
            filme.Executar();
        */
            Console.ReadLine();


        }
    }
}
