using static System.Console;
using System;

sealed class ContaPoupanca : Conta 
{ 
    public double TaxaJuros{get;set;} 

    public ContaPoupanca() 
    { 

    }

    public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo) 
    { 
        TaxaJuros = taxaJuros; 
    }

    public sealed override void Saque(double saldoTotal) 
    { 
        base.Saque(saldoTotal); 
        Saldo -= 2.0; 
    }

    public void atualizacaoSaldo() 
    { 
        Saldo += Saldo * TaxaJuros; 
    }
}
