using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Line, Quad, Rect, Tri, Circ

            IDraw forma = new Line(); //nao da pra instanciar interfaces, mas da pra instanciar objetos filhos de de Interaces

            //e quando eu tenho uma variavel do tipo interface, nao da pra acessar atributos, somente metodos

            forma.Draw();

            Console.ReadLine();

        }
    }

    //No C# um padrao é comecar as classes com I maiusculo, , nao usa modificador de acesso, pois tudo na interface é publico
    interface IDraw //define um conjunto de metodos que a classe tem que implementar
    {
        void Draw();
        float Area();

    }

    class Line : IDraw
    {
        public float Area()
        {
            return 20;
        }

        public void Draw()
        {
            Console.WriteLine(" -  Linha  - ");
        }
    }

    class Quad : IDraw
    {
        public float Area()
        {
            return 2;
        }

        public void Draw()
        {
            Console.WriteLine(" -  Quad  - ");
        }
    }

    class Rect : IDraw
    {
        public float Area()
        {
            return 10;
        }

        public void Draw()
        {
            Console.WriteLine(" -  Rect  - ");
        }
    }





}
