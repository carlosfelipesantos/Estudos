using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //Importando modulo Serializador

namespace Leitura_de_Arquivos_Binarios
{
    internal class Program
    {
        //Diferenca na pratica entre arquivos de texto e arquivos binários
        //Quando voce escreve em um arquivo de texto, voce pega qualquer dado, string, float, int, e é convertido em string

        //No arquivo binário, inves de converter os tipos para texto, voce mantem os tipos em sua forma original, uma variavel inteira salva em um arquivo nao é convertida pra texto, continua salva como inteira

        //Por isso quando abre um arquivo binario em um bloco de notas, nao da pra entender nada, pois os dados nao sao texto

  

        static void Main(string[] args)
        {
           

            //FileStream serve para leitura e escrita,          Open or Create, escolher o que quer fazer com o arquivo
            FileStream testandostream = new FileStream("meuarquivo.txt", FileMode.OpenOrCreate); //o conteudo importa, extensao nao importa, so é padronizacao

            //Para escrever de maneira binaria, precisa de um Serielizador (pega qualquer tipo de dado, e converte para uma cadeia de bytes)
            BinaryFormatter codificador = new BinaryFormatter();

            //Escrevendo em um arquivo binario
            codificador.Serialize(testandostream, 120);
            codificador.Serialize(testandostream, "Escrevendo em Binario");
            testandostream.Close();

            //Realizando a Leitura do Arquivo Binario, Se a serializacao é o processo de salvamento, A deserializacao é o processo de leitura


            FileStream testandostreamLeitura = new FileStream("meuarquivo.txt", FileMode.Open);

            BinaryFormatter decodificador = new BinaryFormatter();

            //Para ler é necessario saber o que foi salvo e a ordem, ex: int, string, float
            int deserializandoInt = (int)decodificador.Deserialize(testandostreamLeitura);
            string deserializandoString = (string)decodificador.Deserialize(testandostreamLeitura);

            Console.WriteLine(deserializandoInt);
            Console.WriteLine(deserializandoString);



           

            Console.ReadLine();

        }
    }
}
