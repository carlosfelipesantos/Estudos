using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Estoque_Orientado_a_Objetos
{

    [System.Serializable]
    internal class Ebook: Produto, IEstoque
    {
        public string autor;
        private int vendas;

       public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Nao é possivel dar entrada no estoque de um Ebook, pois é um produto digital");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no Ebook {nome}");
            Console.WriteLine("Digite a quantidade de vendas que voce quer adicionar: ");
            int saida = int.Parse(Console.ReadLine());

            vendas += saida;
            Console.WriteLine("Venda registrada");

            Console.ReadLine();

        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preco: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("-------------------");
        }
    }
}
