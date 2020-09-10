using static System.Console;
using System;

public class Funcionario
{
	public string nome;
	public double salarioBruto, imposto;

	public double SalarioLiquido()
    {
        salarioBruto -= imposto;
        WriteLine("\r\nFuncionário(a): " + nome + ", R$" + salarioBruto);
        return salarioBruto;
    }

	public void AumentarSalario(double porcentagem)
    {
        Write("\r\nDigite a porcentagem para aumentar o salário: ");
        porcentagem = double.Parse(ReadLine());
        
        porcentagem /= 100;

        double multi = salarioBruto * porcentagem;
        WriteLine("Aumento de: R$" + multi);
        salarioBruto += multi;

        WriteLine("\r\nDados atualizados: " + nome + ", R$" + salarioBruto);
    }
}
