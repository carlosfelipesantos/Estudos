using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Classe_Abstrata //Basicamente Classe Abstrata é uma mistura de Herança + Interfaces 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Line, Quad, Rect, Tri, Circ

            Drawable shape = new Line();

            shape.Draw();

            Console.ReadLine();

        }
    }

    //Classe Abstrata voce define a assinatura dos metodos e faz uma implementacao(mesmo que vazia)
    abstract class Drawable
    {
        //A PRINCIPAL DIFERENCA ENTRE ABBSTRATA E INTERFACE: nas interfaces nao podem declarar variaveis, nas classses abstratas podem
        public int size;
        public int color;

       //sempre deve colocar public em metodos de classes abstratas, é uma regra do C#
       public abstract void Draw();


       public abstract float Area();
        
    }



    //Classe filha 
    class Line : Drawable //Heranca da classe abstrata
    {
        public override float Area() //metodos da classe abstrata
        {
            return 0;
        }

        public override void Draw() //metodos da classe abstrata
        {
            Console.WriteLine("Line");
        }
    }



}
