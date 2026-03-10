using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remoção_de_Elementos_de_uma_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            clientes.Add("Victor");
            clientes.Add("Jose");
            clientes.Add("Maria");

            //Percorrer elementos da lista/array
            foreach (string i in clientes)
            {
                Console.WriteLine(i);
            }

            //Exibir quantos elementos existe dentro da lista
            Console.WriteLine("Quantidade de elementos: " + clientes.Count());

            //Removendo elemento por indice
            clientes.RemoveAt(0);

            Console.WriteLine("----------------");

            //Exibindo elementos depois da remocao
            foreach (string i in clientes)
            {
                Console.WriteLine(i);
            }

            //remover todos elementos da lista que correspondem ao predicado
            clientes.RemoveAll( cliente => cliente == "Maria" );

            
            Console.ReadLine();

        }
    }
}
