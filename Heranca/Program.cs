using static System.Console;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaJuridica conta = new ContaJuridica(8010,"Tomb Raider", 100.0, 500.0); 
            WriteLine(conta.Saldo);

            ReadKey();
        }
    }
}
