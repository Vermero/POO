using static System.Console;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Colhe informações e cria a matriz
            Write("Digite a ordem da matriz: "); int N = int.Parse(ReadLine());
            
            int[,] matriz = new int[N, N];

            //Insere números inteiros na matriz
            WriteLine("\nDigite " + matriz.Length + " números inteiros para inserir na Matriz.");

            for(int i = 0; i < N; i++)
{
                for (int j = 0; j < N; j++)
                {
                    Write("Informe o elemento ({0},{1}): ", i, j);
                    matriz[i, j] = int.Parse(ReadLine());
                }
            }

            //Mostra a matriz
            WriteLine("\nMatriz: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Write(matriz[i, j] + "\t");
                }
                WriteLine();
            }

            //Mostra os números na diagonal da matriz
            WriteLine("\nNúmeros na diagonal: ");
            for(int i = 0; i < N; i++)
            {
                Write(matriz[i, i] + " ");
            }

            //Conta a quantidade de números negativos
            int negative = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(matriz[i, j] < 0)
                    {
                        negative += 1;
                    }
                }
            }
            Write("\n\nQuantidade de números negativos:\n" + negative);

            




            ReadKey();
        }
    }
}
