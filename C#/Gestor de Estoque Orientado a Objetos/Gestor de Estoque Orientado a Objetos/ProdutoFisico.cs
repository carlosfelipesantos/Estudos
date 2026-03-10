using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Estoque_Orientado_a_Objetos
{
    [System.Serializable]//este tipo de dado pode ser salvo em arquivos
    internal class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque; //nao coloca estoque, pois quando vai cadastrar um produto novo nao faz sentido inserir a quantidade no estoque

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
  

        }

        public void AdicionarEntrada()
        {

            Console.WriteLine($"Adicionar entrada no estoque do produto {nome}");
            Console.WriteLine("Digite a quantidade que voce deseja dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());

            estoque += entrada;
            Console.WriteLine("Entrada registrada");

            Console.ReadLine();

        }

        public void AdicionarSaida()
        {

            Console.WriteLine($"Adicionar saida no estoque do produto {nome}");
            Console.WriteLine("Digite a quantidade que voce deseja retirar: ");
            int saida = int.Parse(Console.ReadLine());

            estoque -= saida;
            Console.WriteLine("Saida registrada");

            Console.ReadLine();

        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preco: {preco}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("-------------------");
        }
    }
}
