using System;
using System.Collections.Generic;//Adiciona Listas, Dicionarios, HashTables, etc
using System.Linq; //Módulo com uma serie de funcoes de manipulacoes de dados, ex: Filtrar, Remover, Buscar dados de uma Lista etc
using System.Text;
using System.Threading.Tasks;

namespace Listas__Melhor_que_Arrays_
{
    internal class Program
    {   //Listas é melhor que o array devido aos metodos que podem ser utilizados
        //e que listas nao tem um limite predefinido igual array

        //arrays sao utilizados quando voce sabe exatamente a quantidade de dados a serem armazenados
       

        static void Main(string[] args)
        {   //variaveis primitivas, float, string, int

            //sempre que for criar outro tipo de variavel utiliza o new


            //Criando lista
            List<string> clientes = new List<string>();
            
            //adicionando elementos na lista
            clientes.Add("Joao");
            clientes.Add("Lima");
            string pessoa = "Jose";
            clientes.Add(pessoa);

            //acessar elementos na lista (igual array)
            Console.WriteLine(clientes[1]);
            Console.ReadLine();

        }
    }
}
