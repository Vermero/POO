using static System.Console;
using System;

namespace Produtos_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleta e insere tamanho do array
            Write("Insira a quantidade de produtos: ");
            int n = int.Parse(ReadLine());
            Produto[] array = new Produto[n];

            //Coleta e insere dados da classe no array
            for(int i = 0; i < n; i++)
            {
                Write("\nNome: ");
                string name = ReadLine();
                Write("Preço: ");
                double price = double.Parse(ReadLine());
                array[i] = new Produto { Name = name, Price = price };                
            }

            //Soma valores do array
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i].Price;               
            }
            WriteLine("\nSoma: " + sum);

            //Cacula média dos valores do array
            double avarage = sum / n;
            WriteLine("\nMédia: " + avarage);



            ReadKey();
        }
    }
}
