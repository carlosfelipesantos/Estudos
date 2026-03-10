using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador <10) //Enquanto for verdade
            {
                contador++;
                Console.WriteLine(contador);

                Console.ReadLine();
            }
        }
    }
}
