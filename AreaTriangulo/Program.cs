using static System.Console;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criacao dos objetos

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            #endregion

            #region Coleta de dados

            WriteLine("Entre com as medidas do triângulo X:");
                x.A = double.Parse(ReadLine());
                x.B = double.Parse(ReadLine());
                x.C = double.Parse(ReadLine());

            WriteLine("Entre com as medidas do triângulo Y:");
                y.A = double.Parse(ReadLine());
                y.B = double.Parse(ReadLine());
                y.C = double.Parse(ReadLine());

            #endregion

            #region Calculo

            double areaX = x.Area();
            double areaY = y.Area();

            #endregion

            #region Resultado

            WriteLine("Área de X = " + areaX.ToString());
            WriteLine("Área de Y = " + areaY.ToString());

            #endregion

            #region Maior area

            if (areaX > areaY)
            {
                WriteLine("A área do quadrado X é maior.");
            }
            else
            {
                WriteLine("A área do quadrado Y é maior.");
            }

            #endregion
            
            ReadKey();
        }
    }
}