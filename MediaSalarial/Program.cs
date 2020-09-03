using static System.Console;
using System;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Criacao dos objetos

            Pessoa pessoa = new Pessoa();

            #endregion

            #region Coleta de dados

            //Coleta pessoa 1
            WriteLine("Insira os dados da primeira pessoa.");
            Write("Insira o nome: "); pessoa.nome1 = ReadLine();
            Write("Insira a idade: "); pessoa.idade1 = int.Parse(ReadLine());
            Write("Insira o salário: "); pessoa.salario1 = double.Parse(ReadLine());

            //Coleta pessoa 2
            WriteLine("\r\nInsira os dados da segunda pessoa.");
            Write("Insira o nome: "); pessoa.nome2 = ReadLine();
            Write("Insira a idade: "); pessoa.idade2 = int.Parse(ReadLine());
            Write("Insira o salário: "); pessoa.salario2 = double.Parse(ReadLine());            

            #endregion

            #region Analise e resultado

            //Calculo media salarial
            pessoa.Media();

            //Resultado da pessoa mais velha
            pessoa.MaisVelha();

            #endregion
            
            ReadKey();
        }
    }
}
