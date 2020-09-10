using static System.Console;
using System;

public class Alunos
{
	public string nome;
	public float nota1, nota2, nota3;

	public void Aprovacao()
    {
        float total, resto;

        total = nota1 + nota2 + nota3;
		WriteLine("Nota final = " + total);

		if (total >= 60)
        {
			WriteLine("Aprovado(a)!");
        }
        else
        {
            resto = 60 - total;
            WriteLine("Reprovado(a)!\r\nFaltaram " + resto + " pontos.");
        }
    }
}
