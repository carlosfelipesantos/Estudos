using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Estoque_Orientado_a_Objetos
{

    [System.Serializable]
    internal class Curso: Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.autor = autor;
            
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no curso {nome}");
            Console.WriteLine("Digite a quantidade de vagas que voce deseja dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());

            vagas += entrada;
            Console.WriteLine("Entrada registrada");

            Console.ReadLine();


        }

        public void AdicionarSaida()
        {

            Console.WriteLine($"Consumir vagas do curso {nome}");
            Console.WriteLine("Digite a quantidade da vagas que voce quer consumir: ");
            int saida = int.Parse(Console.ReadLine());

            vagas -= saida;
            Console.WriteLine("Saida registrada");

            Console.ReadLine();


        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preco: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("-------------------");
        
        }
    }
}
