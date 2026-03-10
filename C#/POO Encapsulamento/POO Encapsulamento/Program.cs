using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Filme filme = new Filme("Ta dando onda", "Surf de pinguim", 2009, "DreamWorks");

            //usando metodo encapsulador publico para interagir com variavel privada
            filme.addAtor("Keanus Reeve");
            filme.addAtor("Wynonna Rider");
            filme.addAtor("Dwayne Johnson");

            filme.ExibirAtores();



         

             //se a variavel por publica da pra interagir em qualquer lugar do programa, por exemplo adicionando elementos na lista
             //filme.atores.Add("Brad Pitt")
             //filme.atores=null;
             //filme.atores.Clear();
            
            //se a variavel for privada para interagir, deve se usar METODOS ENCAPSULADORES, sao metodos privados que manipulam variaveis privadas

            Console.ReadLine();
        }
    }
}
