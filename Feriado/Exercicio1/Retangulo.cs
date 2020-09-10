using static System.Console;
using System;

public class Retangulo
{
	public double largura, altura, area, perimetro, diagonal;

	public double Area()
    {
		area = largura * altura;
		WriteLine("\r\nA área do retângulo é: " + area);
		return area;
    }

	public double Perimetro()
    {
		perimetro = largura + altura + largura + altura;
		WriteLine("O perímetro do retângulo é: " + perimetro);
		return perimetro;
    }

	public double Diagonal()
    {
		diagonal = Math.Sqrt(largura * largura + altura * altura);
		WriteLine("A diagonal do retângulo é: " + diagonal);
		return diagonal;
	}

}
