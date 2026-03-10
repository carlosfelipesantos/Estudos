using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Lógicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)

            {
                Console.WriteLine("Criança");
            }
            else if (idade >= 12 && idade <= 17)
            {
                Console.WriteLine("Adolescente");
            }
            else 
            {
                Console.WriteLine("Adulto");
            }

            Console.ReadLine();
        }
    }
}
