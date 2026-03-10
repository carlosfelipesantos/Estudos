using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Input/Output, manipulacao de arquivos: permite que o programa gere arquivos
namespace Files___Escrita_de_Arquivos_de_Texto
{
    internal class Program
    {       //Stream é o fluxo de comunicacao entre o C# e o arquivo
        static void Main(string[] args)
        {
            //Como escrever em arquivos de texto, no parametro informa o nome do arquivo que sera modificado
            StreamWriter escritor = new StreamWriter("teste.txt"); //caso o arquivo nao existe, ele é criado
            escritor.WriteLine("Testando StreamWriter");
            escritor.WriteLine("Funcionou?");
            escritor.Close();//sempre deve fechar o fluxo, senao nao funciona e fica rodando
            Console.WriteLine("Arquivo gerado");


            //Da forma acima, quando voce escreve outra mensagem no arquivo, as anteriores sao apagas

            //Da forma abaixo ele mantem, so adiciona
            StreamWriter escritaSalva = File.AppendText("teste2.txt");
            escritaSalva.WriteLine("Testando StreamWriter que adiciona informacoes sem remover");
            escritaSalva.Close();
            Console.WriteLine("Arquivo teste2.txt criado");
            Console.ReadLine();

        }
    }
}
