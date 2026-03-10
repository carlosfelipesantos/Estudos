using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.nome = "Joao";
            a.email = "joaozinho@gmail";
            a.senha ="123";
            a.turno = "Verspertino";

            a.Logar();

            Usuario u = new Usuario();
            u.nome = "asadas";
            u.email = "dadas";
            u.senha = "dasdas";
            //u.turno = nao funciona, pois o pai nao herda do filho


            Console.ReadLine();

        }
    }
}




//Herança: herdar atributos e metodos


//SISTEMA ESCOLAR COM TRES ENTIDADES: PROFESSOR, ALUNO, DIRETOR

//Professor: Nome, Email, Senha
//Aluno: Nome, Email, Senha
//Diretor: Nome, Email, Senha

//Criei 3 classes, se em cada classe eu colocar os 3 atributos individualmente para cada
//Quando criar um login, vou ter que tratar cada classe de forma diferente


//Utilizando Herança, define uma classe pai/mae e define subclasses
//Usuario: Nome, Email, Senha; Metodo: Logar();
//Professor, Aluno e Diretor herdam da classe usuário, porem os filhos tem atributos que a classe pai nao tem

//Professor: Materias
//Aluno: Notas
//Diretor: Reuniao