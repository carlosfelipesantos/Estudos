




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_de_Sobreposicao 


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Tarde", "Carlos", "ccfelipe@ajda", "43434"); 

            Zelador z = new Zelador("200", "Evanildo", "evanildo2eqe", "312312"); 


            
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(a);
            usuarios.Add(z);

            a.Exibir();

            Console.ReadLine();

        }
    }
}
