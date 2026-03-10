using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericicos_Função
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrecoFinal();
            Console.ReadLine();
        }

        static void PrecoFinal()
        {
            var chocolate = 30f + (30f * 0.25);
            Console.WriteLine("chocolate: " + chocolate);
            var refrigerante = 50f + (50f * 0.25); ;
            Console.WriteLine("refrigerante: " + refrigerante);
            var bolo = 45f + (45f * 0.25); 
            Console.WriteLine("bolo: " + bolo);
            var sorvete = 60f + (60f * 0.25);
            Console.WriteLine("sorvete: " + sorvete);
            var pao = 15f + (15f * 0.25);
            Console.WriteLine("pao: " + pao);


        }

    }
}
