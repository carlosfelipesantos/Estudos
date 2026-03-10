using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Criação_de_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ecomerce ecomerce = new Ecomerce();

            ecomerce.nome = "Iphone";
            ecomerce.marca = "Apple";
            ecomerce.armazenamento = 1000;


            ecomerce.Ficha();

        }
    }
}
