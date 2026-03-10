using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtragem_e_Busca_em_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> clientes = new List<string>();
            clientes.Add("Victor");
            clientes.Add("Jose");
            clientes.Add("Maria");
            clientes.Add("Eva");

            foreach (string i in clientes)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("==============================");

            //Buscar um dado dentro da lista, utilizando predicados
            string busca = clientes.Find(cliente => cliente.Length > 4);

          
            Console.WriteLine(busca);


            //Buscar mais de um dado dentro da lista, e retorna uma lista filtrada
            List<string> buscaAll = clientes.FindAll(cliente => cliente.Length > 4);



            Console.WriteLine("================================");

            //percorrendo elementos na "nova lista" filtrada
            foreach(string i in buscaAll)
            {
                Console.WriteLine(i);
            }
           

           

        }
    }
}
