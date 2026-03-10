




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_em_Herança //Polimorfismo: um conceito de POO: uma coisa, um objeto ou uma funcao pode ter multiplas formas

    
    //resumidamente imagina que eu criei 3 classes: aluno, zelador, diretor
    //e todas retornam a funcao Dados(); que contem nome, idade + nome da classe

    //polimorfismo é a funcao Dados(); baseado na classe que estiver retornar algo parecido mas com alguma variacao, nesse caso o nome da classe

    //E em um projeto grande voce nao precisa ter a funcao DadosAluno, DadosZelador etc... So chamar a funcao Dados() e o sistema interpreta oq é pra fazer

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno u = new Aluno("Tarde", "Jaco", "ccfelipe@ajda", "313123"); //Por eu ter salvo um dado do tipo filho(Aluno) em uma variavel do tipo pai (Usuario), so vai retornar dados da variavel Usuario, pois ela nao tem turma

            Zelador z = new Zelador("200", "Evanildo", "evanildo2eqe", "312312"); //Mesma coisa aqui, usuario nao tem salario, somente zelador, e como esta salvo em Usuario, nao retornara o salario

            //Para acessar dados unicos das variaveis filhas, deve se usar um cast
            Console.WriteLine(((Aluno)u).turno); //Convertendo variavel do tipo pai(usuario) para filho(aluno)
            Console.WriteLine(((Zelador)z).salario);

            //Lista de usuarios
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(u);
            usuarios.Add(z);

            //C# Executa baseado na assinatura (string, string)
            u.Logar("email", "asasas");

            //(string, int)
            u.Logar("ola", 123);

            Console.ReadLine();

        }
    }
}
