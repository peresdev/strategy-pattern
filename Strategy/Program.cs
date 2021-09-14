using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta(new ContaCorrente());
            Console.WriteLine(c.calcularTaxa(10.0));
            
            Conta p = new Conta(new ContaPoupanca());
            Console.WriteLine(p.calcularTaxa(10.0));
        }
    }
}