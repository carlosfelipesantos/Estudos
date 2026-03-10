using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 3;
            //Do While funciona da mesma forma, porem mesmo que a condição seja falsa, o codigo sera executado pelo menos 1 vez
            do
            {
                Console.WriteLine("DO WHILE");
            }
            while (contador < 1);
            

        }
    }
}
