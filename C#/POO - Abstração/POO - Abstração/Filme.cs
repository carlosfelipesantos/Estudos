using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___Abstração
{


    internal class Filme
    {

        public string nome;
        public string descricao;
        public string ano;
        public string studio;
        public List<string> atores = new List<string>();

        public void Executar()
        {
            Console.WriteLine("Rodando Filme: " + nome);
        }

        public void Pausar()
        {
            Console.WriteLine("||");
        }



    }
}
