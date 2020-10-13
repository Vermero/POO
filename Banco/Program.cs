using static System.Console;
using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria a conta bancaria
            Write("Entre com o número da conta: "); int conta = int.Parse(ReadLine());
            Write("Entre com o nome do titular da conta: "); string titular = ReadLine();

            #region Deposito inicial
            Write("\nHaverá depósito inicial? (S/N)"); string sn = ReadLine();
            
            bool? inicial = null;
            double dInicial = 0;

            //Altera bool
            if (sn == "s")
            {inicial = true;}
            else{inicial = false;}
            
            if(inicial == true)
            {Write("Entre com o valor de depósito inicial: "); dInicial = double.Parse(ReadLine());}

            double saldo = 0;
            saldo += dInicial;
            #endregion

            //Mostra dados
            WriteLine("\n-DADOS DA CONTA-\n\nConta: " + conta + "\nTítular: " + titular + "\nSaldo: R$" + saldo);

            //Deposita novo valor
            Write("\nEntre com um valor para depósito: "); double deposito = double.Parse(ReadLine());
            saldo += deposito;

            //Mostra dados
            WriteLine("\n-DADOS ATUALIZADOS-\n\nConta: " + conta + "\nTítular: " + titular + "\nSaldo: R$" + saldo);

            //Retira valor
            Write("\nEntre com um valor para saque: "); double saque = double.Parse(ReadLine());
            saldo -= saque;

            //Mostra dados
            WriteLine("\n-DADOS ATUALIZADOS-\n\nConta: " + conta + "\nTítular: " + titular + "\nSaldo: R$" + saldo);


            ReadKey();
        }
    }
}
