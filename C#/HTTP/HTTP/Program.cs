using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HTTP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ReqList();
            ReqUnica();

            Console.ReadLine();


        }

        static void ReqList()
        {
            //Criando uma requisicao que vou enviar para essa URL
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
            requisicao.Method = "GET"; //Metodo que envia a requisicao pra internet

            //Estrutura de Codigo facilita o trabalho com Web Request, pois abre e fecha automaticamente a parte de conexao
            using (var resposta = requisicao.GetResponse()) //recebe a resposta
            {
                var stream = resposta.GetResponseStream();//Pega a resposta
                StreamReader leitor = new StreamReader(stream); //Descodifica os dados obtidos
                object dados = leitor.ReadToEnd(); //le os dados

                

                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());

                foreach (Tarefa tarefa in tarefas)
                {
                    tarefa.Exibir();
                }

                Console.WriteLine(tarefas);


                stream.Close();
                resposta.Close();



            }
        }

        static void ReqUnica()
        {
           
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/45");
            requisicao.Method = "GET"; 

          
            using (var resposta = requisicao.GetResponse()) 
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream); 
                object dados = leitor.ReadToEnd(); 

                

            Tarefa tarefas = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());

                tarefas.Exibir();


                stream.Close();
                resposta.Close();



            }
        }

    }
}
