using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_C_
{   
    //Enum (enumerador) serve para criar tipos de variavel
    enum Cor { Azul, Verde, Amarelo, Branco }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enum 

            Cor corFavorita = Cor.Azul;
            Cor corFavoritaCarlos = Cor.Branco;

            Console.WriteLine((int)corFavorita);
            Console.WriteLine(corFavoritaCarlos);

            Console.ReadLine();

            
        }
    }
}
