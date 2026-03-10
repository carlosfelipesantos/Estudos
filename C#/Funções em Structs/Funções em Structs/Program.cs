using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções_em_Structs
{
    internal class Program
    {
        //struct, é praticamente uma classe, voce cria tipos de variaveis
        struct Produto
        {  //geralmente as variaveis criadas na struct, se chamam atributo ou campo
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            //constructor, direciona os valores informados para class
            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }

         
         public void ExibirInfo()
            {
                Console.WriteLine($"Nome: { this.nome }");
                Console.WriteLine($"Preço: R$ { this.preco }");
                Console.WriteLine($"Peso: {this.preco} Kg");
                Console.WriteLine($"Marca: {this.marca} ");
            }

            //void siginifca que nao retorna nada
            //float quer dizer que a funcao ira retornar um float
            public float AdicionarCupom(float porcentagem)
            {
                float desconto = this.preco * porcentagem / 100f;
                return this.preco - desconto;
            }


        }


        static void Main(string[] args)
        {
            Produto bola = new Produto("Bola do ronaldinho ", 100f, 1f, "Nike");
            Produto balde = new Produto("Balde vermelho", 8f, 20f, "Pato");


            bola.ExibirInfo();
            Console.WriteLine("---------------");
            balde.ExibirInfo();

            float valorFinal = bola.AdicionarCupom(50f);
            balde.AdicionarCupom(50f);

            Console.WriteLine(valorFinal);

            Console.ReadLine();


        }
    }
}
