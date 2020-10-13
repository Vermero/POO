using static System.Console;
using System;

namespace MédiaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coletando dados do array
            Write("Entre com o número de pessoas: "); 
            int n = int.Parse(ReadLine());

            //Criando array
            double[] array = new double[n];

            //Adicionando valores ao array
            for(int i = 0; i < n; i++)
            {
                Write("Altura da pessoa " + n + ": ");
                array[i] = double.Parse(ReadLine());
            }

            //Criando variavel para soma
            double sum = 0;

            //Somando todos valores do array
            for(int i = 0; i < n; i++)
            {
                sum += array[i];
            }

            //Calculando e mostrando média
            sum /= n;
            WriteLine("A média de altura das pessoas inseridas é: " + sum);


            
            
            
            
            ReadKey();
        }
    }
}
