using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var pagamento = new Pagamento();
        }
    }

    //Interfaces agem como um contrato, nao tem instanciar e nem implementacoes public void Pagar();
    public interface IPagamento
    {
        DateTime Vencimento { get; set; } //property
        void Pagar(double valor);//assinatura
    }

    //Implementando a interface IPagamento (cntrl .)
    public class Pagamento : IPagamento
    {
        public DateTime Vencimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Pagar(double valor)
        {
            
        }
    }

}
