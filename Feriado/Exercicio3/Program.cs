using static System.Console;
using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criacao do objeto
            Alunos alunos = new Alunos();
            
            //Coleta de dados
            Write("Digite o nome do(a) aluno(a): ");
            alunos.nome = ReadLine();

            WriteLine("Digite as notas de " + alunos.nome + ":");
            alunos.nota1 = float.Parse(ReadLine());
            alunos.nota2 = float.Parse(ReadLine());
            alunos.nota3 = float.Parse(ReadLine());

            //Chamada do metodo
            alunos.Aprovacao();



            Write("\r\nAperte qualquer tecla para sair..."); ReadKey();
        }
    }
}
