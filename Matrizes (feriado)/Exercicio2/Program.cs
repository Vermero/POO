using static System.Console;
using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Colhe informações e cria matriz
            Write("Quantidade de linhas: "); int M = int.Parse(ReadLine());
            Write("Quantidade de colunas: "); int N = int.Parse(ReadLine());

            int[,] matriz = new int[M, N];

            //Insere número na matriz
            WriteLine("\nInsira " + matriz.Length + " números dentro da matriz.");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Write("Informe o elemento ({0},{1}): ", i, j);
                    matriz[i, j] = int.Parse(ReadLine());
                }
            }

            //Exibe matriz
            WriteLine("\nMatriz: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Write(matriz[i, j] + "\t");
                }
                WriteLine();
            }

            //Procura número dentro da matriz
            Write("\nDigite um número na Matriz: "); int X = int.Parse(ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(matriz[i, j] == X)
                    {
                        //Encontra a posição do número dentro da matriz
                        WriteLine("\nPosição do número " + X + ": " + i + ", " + j);

                        int cima;
                        int baixo;
                        int esquerda;
                        int direita;

                        //Checa quais são os números ao redor do número escolhido 
                        if(j - 1 >= 0)
                        {
                            esquerda = matriz[i, j - 1];
                            WriteLine("Número à esquerda: " + esquerda);
                        }
                        else if(j - 1 < 0)
                        {
                            WriteLine("Número à esquerda: Não existe.");
                        }

                        if (i - 1 >= 0)
                        {
                            cima = matriz[i - 1, j];
                            WriteLine("Número acima: " + cima);
                        }
                        else if(i - 1 < 0)
                        {
                            WriteLine("Número acima: Não existe.");
                        }

                        if (j + 1 < N)
                        {
                            direita = matriz[i, j + 1];
                            WriteLine("Número à direita: " + direita);
                        }
                        else if (j + 1 >= N)
                        {
                            WriteLine("Número à direita: Não existe.");
                        }

                        if (i + 1 < M)
                        {
                            baixo = matriz[i + 1, j];
                            WriteLine("Número abaixo: " + baixo);
                        }
                        else if (i + 1 >= M)
                        {
                            WriteLine("Número abaixo: Não existe.");
                        }
                    }
                }
            }

            ReadKey();
        }
    }
}
