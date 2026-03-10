using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch tem a mesma função do if, sendo mais adequado para multiplas condições
            string cor = "Verde";

            //Switch só realiza operações de igualdade, 10=10 funciona, comparação não funciona 10>20 nao funciona
            switch (cor) {

                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é Vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("Essa mensagem aparece caso nenhuma condição seja atendida");
                    break;
            }
            Console.ReadLine();

        }
    }
}
