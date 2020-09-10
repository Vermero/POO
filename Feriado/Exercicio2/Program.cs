using static System.Console;
using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criacao do objeto
            Funcionario funcionario = new Funcionario();
            
            //Coleta de dados
            WriteLine("Insira os dados do(a) funcionário(a).");
            Write("Nome: "); funcionario.nome = ReadLine();
            Write("Salário bruto: "); funcionario.salarioBruto = double.Parse(ReadLine());
            Write("Imposto: "); funcionario.imposto = double.Parse(ReadLine());

            //Chamada de metodos
            funcionario.SalarioLiquido();
            funcionario.AumentarSalario(funcionario.salarioBruto);


            Write("\r\nAperte qualquer tecla para sair..."); ReadKey();
        }
    }
}
