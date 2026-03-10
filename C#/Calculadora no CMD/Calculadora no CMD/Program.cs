using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_no_CMD
{
    internal class Program
    {
        enum Menu { Soma=1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) //Enquanto nao escolheu sair, exibe o menu
            {
                //Exibir o menu

                Console.WriteLine("Seja bem vindo a Calculadora CMD!");
                Console.WriteLine("");

                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");

                string opcaoTXT = Console.ReadLine();
                int opcaoINT = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoINT;

                /* versao mais pro, CAST
                Menu opcao = (Menu)int.Parse(Console.ReadLine()); //conversao por CAST
                */

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }   
               
                Console.Clear();
            }

        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtracao de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine("O resultado da subtracao é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisao de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float) a / (float) b; //fazendo CAST
            Console.WriteLine("O resultado da divisao é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicacao de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine("O resultado da multiplicacao é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potencia de um número: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Potencia de um número: ");
            Console.WriteLine("Digite o numero para calcular a raiz: ");
            int n1 = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(n1);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }




    }
}
