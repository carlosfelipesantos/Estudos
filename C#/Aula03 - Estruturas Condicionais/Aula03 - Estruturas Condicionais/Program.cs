using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03___Estruturas_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ver valores");
            
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um terceiro número: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("N1 é o maior valor = " + n1);
            }
            else if (n1 < n2 && n2 > n3)
            {
                Console.WriteLine("N2 é o maior valor = " + n2);
            }
            else if (n1 == n3 && n2 == n3)
            {
                Console.WriteLine("Sao iguais");
            }
            else if (n1 == n2 && n2 > n3)
            {
                Console.WriteLine("N1 e N2 são iguais e a maiores que N3, pois n1 e n2 = " + n1);
            }
            else if (n2 == n3 && n2 > n1)
            {
                Console.WriteLine("N2 e N3 são iguais e a maiores que N1, pois n2 e n3 = " + n2);
            }
            else if (n1 == n3 && n3 > n2)
            {
                Console.WriteLine("N1 e N3 são iguais e a maiores que N2, pois n1 e n3 = " + n1);
            }




            else
            {

                Console.WriteLine("N3 é o maior valor = " + n3);
            }









        }
    }
}
