using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* GerarPreco(-20, "Curso de C#");
             Console.ReadLine();
             FirstFunction();*/

            /* string valor = Console.ReadLine();
             Console.WriteLine("Foi digitado: " + valor);
             Console.ReadLine();*/

            Console.WriteLine(Somar(10, 20, 30));
            Console.ReadLine();
            
        }

        static void FirstFunction() 
        {
            Console.WriteLine("Testando função!");
            Console.WriteLine("Usando função!");
            Console.WriteLine("Função Testada");
        }

        static void GerarPreco(int preco, string nome)
        {
            int precoAbs = Math.Abs(preco);
            Console.WriteLine("Positivo: " + precoAbs);
            Console.WriteLine("Nome: " + nome +" Preco: " + preco);
            int valorFinal = preco * 2;
            Console.WriteLine(valorFinal);

        }

        static int Somar(int a, int b, int c) 
        {
            int resultado = (a + b + c);
            return resultado;
        }


    }
}
