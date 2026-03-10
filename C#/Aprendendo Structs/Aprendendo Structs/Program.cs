using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//No C#, existe tipos de int, string, bool
//E existe duas formas de criar um tipo customizado
//Usando Structs(Forma mais simples) e Classes(Orientação a Objetos)

/* Usando Structs e Classes voce consegue atribuir tudo isso a um produto de uma vez

Produto -> nome, preco, peso, marca;
Produto.nome; Exibiria o nome do produto

string nomeProduto = "Bola";
float preco = 12f;
float peso = 1f;
string marca = "Nike";
*/


namespace Aprendendo_Structs
{
    internal class Program
    {   //Criando tipo Produto
        struct Produto
        {
            //Public para poder acessar esses atributos em qualquer parte do codigo
           public string nome;
           public float preco;
           public float peso;
           public string marca;

        }
        

        static void Main(string[] args)
        {
            //Criando uma variavel bola, que recebe os atributos de Produto
            Produto bola = new Produto();
            bola.nome = "Society";
            bola.preco = 14f;
            bola.peso = 1f;
            bola.marca = "Nike";

            Produto balde = new Produto();
            balde.nome = "Balde TOP";
            balde.preco = 5f;
            balde.peso = 1f;
            balde.marca = "Vanish";

            Console.WriteLine(bola.marca);
            Console.WriteLine(balde.nome);
            Console.ReadLine();
        }
    }
}
