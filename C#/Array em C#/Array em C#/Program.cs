using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando array de maneira mais complexa
            string[] produtos = new string[5] { 
                "Sea of thieves",
                "FIFA", 
                "Mortal kombat",
                "League of Legends",
                "Portal"
            };

            produtos[1] = "FIFA 2026";

            Console.WriteLine(produtos[1]);


            //criando array de forma mais fácil
            int[] valores = {40, 50, 60};

       

            Console.ReadLine();
        }



    }
}
