using System;  //Serve para que o C# manipule dados do sistema operacional do usuário
using System.Collections.Generic; //Permite que o C# trabalhe com coleções de dados, como listas e dicionários
using System.Linq;  //Trabalha com uma grande quantidade de dados
using System.Text;  //Permite que o C# manipule strings


namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args) //Quando o usuário executar o programa, o C# executará este método primeiro
        {
            
            //Int - Números inteiros
            int idade = 20;

            //Float|Double|Decimal - Números decimais
            float altura = 1.76f;

            //Bool - Verdadeiro ou falso
            bool estudando = true;

            //Char - Caracteres único identificado por aspas simples ''
            char letra = 'A';

            //String - Texto identificado por aspas duplas ""
            string nome = "Carlos Felipe";

            //Var
            var cidade = "São Paulo"; //Var é uma variável que o C# identifica automaticamente o tipo de dado
            var temperatura = 25.5; //O C# identifica que é um double

            //Constante
            const string pais = "Brasil"; //Constante é uma variável que não pode ser alterada após a sua declaração

            //Dinamica - Permite que a variavel mude de tipo durante a execução do programa
            dynamic cor_favorita = "Vermelho";
            Console.WriteLine("Sua cor favorita é: " + cor_favorita);
            cor_favorita = 333;
            Console.WriteLine("Sua cor favorita em RGB é: " + cor_favorita);

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Seu nome é " + nome);
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Voce está estudando? " + estudando);
            Console.WriteLine("Sua sala é: " + letra);
         

            //Atualizando variaveis
            idade = 21;

            Console.WriteLine("Sua idade após seu aniversário será: " + idade);


            Console.ReadLine(); //Aguarda o usuário pressionar Enter para fechar o programa

        }
    }
}
