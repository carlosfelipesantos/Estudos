using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Criação_de_Classes
{
    internal class Ecomerce
    {
        public string nome;
        public int armazenamento;
        public string marca;


        public void Ficha()
        {
            Console.WriteLine("O celular " + nome);
            Console.WriteLine("Da marca: " + marca);
            Console.WriteLine("Tem: " + armazenamento + "GB");
        }


    }
}
