using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores 
{
    //Construtores servem passar os atributos para novas variaveis, de forma mais rapida sem ser linha por linha

    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            //Construtor tem 2 regras:
            //1° Ela é uma funcao especial que nao retorna nada
            //2° Precisa ter o o mesmo nome da struct
            //3° Precisa ser passado todos atributos, nao pode ser só um
            public Produto(string nome, float preco, float peso, string marca) //Receber parametros
            {
                //this serve para se referir ao atributo nome, enquanto so o nome referencia o parametro
                this.nome = nome; //Variavel do atributo (recebe) variavel do parametro
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;

            }

        }


        static void Main(string[] args)
        {
            Produto bola = new Produto("NikeBall", 12f, 1f, "Nike");
            Console.WriteLine(bola.nome);
            Console.WriteLine(bola.preco);
            Console.WriteLine(bola.peso);
            Console.WriteLine(bola.marca);

            
            

            Console.ReadLine();
        }
    }
}
