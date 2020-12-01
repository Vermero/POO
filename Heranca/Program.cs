﻿using static System.Console;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Goku", 0.0); 
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);
            
            //UPCASTING                
            Conta acc1 = bacc;                
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);                
            Conta acc3 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);

            // DOWNCASTING
            ContaJuridica acc4 = (ContaJuridica)acc2; 
            acc4.Emprestimo(100.0); 
            
            if (acc3 is ContaJuridica)
            {
                //ContaPoupanca acc5 = (ContaPoupanca)acc3 
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                WriteLine("Emprestimo!");
            }
            
            if(acc3 is ContaPoupanca)
            {
                //ContaPoupanca acc5 = (ContaPoupanca)acc3 
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.atualizacaoSaldo();
                WriteLine("Atualizado!");
            }

            ReadKey();
        }
    }
}
