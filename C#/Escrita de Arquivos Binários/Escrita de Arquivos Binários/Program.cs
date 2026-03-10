using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //Importando modulo Serializador

namespace Escrita_de_Arquivos_Binários
{
    internal class Program
    {
        //Diferenca na pratica entre arquivos de texto e arquivos binários
        //Quando voce escreve em um arquivo de texto, voce pega qualquer dado, string, float, int, e é convertido em string

        //No arquivo binário, inves de converter os tipos para texto, voce mantem os tipos em sua forma original, uma variavel inteira salva em um arquivo nao é convertida pra texto, continua salva como inteira

        //Por isso quando abre um arquivo binario em um bloco de notas, nao da pra entender nada, pois os dados nao sao texto

        //Criando Struct para salvar no arquivo binario
        [System.Serializable] //Estou dizendo que o tipo de dado Produto pode ser serializado, salvo em arquivos binarios
        struct Produto
        {
            public string nome;
            public float preco;

        }

        static void Main(string[] args)
        {
            //criando produto com info do struct para jogar no arquivo binario
            Produto banana = new Produto();
            banana.nome = "Banana da Terrra";
            banana.preco = 5f;

            //criando lista para salvar no arquivo binario
            List<string> lista = new List<string>();
            lista.Add("Macarrao");
            lista.Add("Alface");
            lista.Add("Cotonete");


            //FileStream serve para leitura e escrita,          Open or Create, escolher o que quer fazer com o arquivo
            FileStream testandostream = new FileStream("meuarquivo.txt", FileMode.OpenOrCreate); //o conteudo importa, extensao nao importa, so é padronizacao

            //Para escrever de maneira binaria, precisa de um Serielizador (pega qualquer tipo de dado, e converte para uma cadeia de bytes)
            BinaryFormatter codificador = new BinaryFormatter();

            //Escrevendo em um arquivo binario
            codificador.Serialize(testandostream, 120);
            codificador.Serialize(testandostream, "Escrevendo em Binario");

            //salvando a lista inteira com uma linha de codigo
            codificador.Serialize(testandostream, lista);
            codificador.Serialize(testandostream, banana);

            testandostream.Close();

        }
    }
}
