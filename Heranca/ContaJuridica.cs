using static System.Console;
using System;

public class ContaJuridica : Conta
{
	//Declarações das variáveis e uso do encapsulamento
	public double EmprestimoLimite{get; set;}
	
	//Criação do construtor padrão
	public ContaJuridica()
	{
	
	}
	
	//Criação do construtor com parâmetros utilizando o da Classe Conta
	public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
	{
		EmprestimoLimite = emprestimoLimite;
	}

	public void Emprestimo(double saldoTotal)
	{
		if (saldoTotal <= EmprestimoLimite)
		{
			Saldo += saldoTotal;
		}
	}
}
