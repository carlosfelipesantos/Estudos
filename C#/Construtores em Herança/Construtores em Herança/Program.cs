using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_em_Herança //Polimorfismo: um conceito de POO: uma coisa, um objeto ou uma funcao pode ter multiplas formas
                                                         
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Tarde","Jaco", "ccfelipe@ajda", "313123");


            a.Logar();
            a.Exibir();

            Console.ReadLine();

        }
    }
}
