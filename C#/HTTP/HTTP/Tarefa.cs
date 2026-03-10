using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
     class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;


        public void Exibir()
        {
            Console.WriteLine("Objeto Tarefa:");
            Console.WriteLine($"userId: {userId}");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"completed: {completed}");
        }


  }


    }

