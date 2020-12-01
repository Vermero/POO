using System;
using System.Collections.Generic;
using FormasGeometricas.Entities;
using FormasGeometricas.Entities.Enums;
using static System.Console;

namespace FormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> list = new List<Forma>();
            WriteLine("Entre com o número de formas: ");
            int n = int.Parse(ReadLine());

            for (int i = 1; i <= n; i++)
            {
                WriteLine($"Forma #{i}:");

                Write("Retângulo ou Circulo(R / C) ? ");
                char ch = char.Parse(ReadLine());

                Write("Cor: (Preto / Azul / Vermelho): ");
                Cor cor = Enum.Parse<Color>(ReadLine);

                if (ch == 'R')
                {
                    Write("Largura: ");
                    double largura = double.Parse(ReadLine());
                    
                    Write("Altura: ");
                    double altura = double.Parse(ReadLine());

                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    WriteLine("Raio: ");
                    double raio = double.Parse(ReadLine());

                    list.Add(new Circulo(raios, cor));  
                }
                
                WriteLine();
                WriteLine("Área de cada forma: ");
                
                foreach(Forma forma in list)
                {
                    WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                }

            }

            ReadKey();
        }
    }   
}
