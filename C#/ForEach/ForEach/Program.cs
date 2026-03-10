using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de repetição encontrada em apenas algumas linguagens, ForEach percorre Arrays
            string[] nomes = { "Carlos", "Felipe", "dos", "Santos", "Candido" };

            //primeiro voce tem uma variavel do mesmo tipo do array percorrido
            
            foreach (string palavra in nomes) { //para cada palavra no array nomes, repita o bloco de codigo
                Console.WriteLine("FOR EACH RODANDO " + palavra
                    );

                    
            }

        }
    }
}
