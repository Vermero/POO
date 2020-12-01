using static System.Console;
using System;

public class Conta
{
	//Declarações de variáveis e uso de Encapsulamento
	public int Numero{get; private set;}
	public string Titular{get; private set;}
	
	//Utilização do protected para alteração de valores entre classes
	public double Saldo{get; protected set;}
	
	//Criação do construtor padrão e do construtor com parâmetros
	public Conta()
	{

	}
	
	public Conta(int numero, string titular, double saldo)
	{
		Numero = numero; 
		Titular = titular; 
		Saldo = saldo;
	}
	
	//Método de Saque
	public virtual void Saque(double saldoTotal)
	{
		Saldo -= saldoTotal + 5.0;
	}
	
	//Método de Deposito
	public void Deposito(double saldoTotal)
	{
		Saldo += saldoTotal;
	}
}

