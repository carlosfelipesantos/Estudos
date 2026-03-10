using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_vs_Objeto
{
    internal class Filme
    {
        //campos nao staticos so podem ser acessados por objetos instanciados
        public string nome;
        public string studio;
        public string duracao;
        List<string> atores = new List<string>();

        //variavel statica so pode ser acessado diretamente na classe
        static public string plataforma = "Netflix";


        
        public void Executar()
        {
            Console.WriteLine("Rodando filme: " + nome);
        }

        //static permite que eu use o metodo em outra classe sem precisar instanciar(criar) um objeto, exemplo: Filme.Executar(); = Acessando esse metodo diretamente na classe
        //porem nao da pra acessar atributos, filme.nome pois sao variaveis de instancia, entao deve se criar variaveis staticas

        //sem o static, eu teria que instanciar um objeto antes para acessar: Filme filme = new Filme(); filme.Executar(); = Acessando o metodo instanciando um objeto antes  
        static public void Pausar()
        {
            Console.WriteLine(plataforma);
            Console.WriteLine("Filme pausado ||");
        }

    }
}
