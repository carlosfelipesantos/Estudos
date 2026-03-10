using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files___Leitura_de_Arquivos_de_Texto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fluxo de escrita
            StreamWriter escritor = File.AppendText("teste.txt");
            escritor.WriteLine("Ola");
            escritor.WriteLine("Mundo");
            escritor.Close();

            List<string> mensagens = new List<string>();




            //fluxo de leitura
            StreamReader leitor = new StreamReader("teste.txt");
            //string conteudo = leitor.ReadToEnd(); //le todo conteudo do arquivo e armazena em uma string


            //usando while para ler linha por linha e percorrer o arquivo
            string linha = "";

            while (linha != null) {
                linha = leitor.ReadLine();//le uma linha do arquivo
                if(linha != null)
                {
                    mensagens.Add(linha); //adicionando cada linha lida dentro de uma Lista
                }
               
            }

            //Devido as linhas do arquivo estarem dentro da Lista mensagens, posso escolher uma linha especifica
            Console.WriteLine(mensagens[3]);

            leitor.Close(); //tambem deve ser fechado

            //Acessando a Lista
            /* foreach(string i in mensagens)
              {
                  Console.WriteLine(i);
              }


              Console.WriteLine("Arquivo gerado");
              Console.ReadLine();
          */
        }
    }
}
