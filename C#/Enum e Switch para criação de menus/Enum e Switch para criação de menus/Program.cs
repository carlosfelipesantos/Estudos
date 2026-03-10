using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_e_Switch_para_criação_de_menus
{
    internal class Program
    {

        enum Opcao { Criar = 1, Deletar, Alterar, Listar, Atualizar }
        //Semelhante ao Array, incia em 0, porem alterando para iniciar em 1, "corrige"

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Alterar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine()); //ReadLine pega o que o usuário digitou como uma string, entao deve se converter
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Criou");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Deletou");
                    break;
                case Opcao.Alterar:
                    Console.WriteLine("Alterou");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Listou");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizou");
                    break;
                default:
                    Console.WriteLine("Opcao nao encontrada");
                    break;
            }      

            Console.ReadLine();
        }
    }
}
