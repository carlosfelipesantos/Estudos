
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Encapsulamento
{
    internal class Filme  //Encapsulamento responsavel por dar uma segurança a mais pro codigo

    { 
        //Encapsulamento tem a ver com os modificadores de acesso colocados em uma classe, seja atributos, ou funcoes: public, private
        //public permite que voce acesse o atributo fora do arquivo da classe
        public string nome;
        public string descr;
        public int ano;
        public string studio;
        
        //quando coloca private, a variavel so e acessada dentro do arquivo da classe, entao quando eu deixo privado eu tenho a garantia que somente nesse arquivo sera acessasdo
        private List<string> atores = new List<string>();

        static public string plataforma = "Netflix";

   
        public Filme(string nome, string descr, int ano, string studio)
        {
          
            this.nome = nome;
            this.descr = descr;
            this.ano = ano;
            this.studio = studio;
            Console.WriteLine("C# é muito legal");
        }



        public void Executar()
        {
            Console.WriteLine("Rodando Filme: " + nome);
            Console.WriteLine(atores); //variavel atores é privada, entao se colocar dentro do metodo da classe Filme, da pra acesasr
        }


        //Criando um metodo encapsulador (metodo publico para manusear dados privados)
        public void addAtor(string nome)
        {
            if(nome != null) //adicionando validacao no metodo, se o nome for diferente de null, adiciona na lista de atores
            {
                if (nome.Length > 4) //adicionando uma segunda validacao
                {
                    atores.Add(nome);  
                }
              
            }
          
        }

        public void ExibirAtores()
        {
            foreach(string ator in atores)
            {
                Console.WriteLine(ator);
            }
        }




    }
}
