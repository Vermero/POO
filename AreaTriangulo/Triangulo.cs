using static System.Console;
using System;

namespace Exercicio1
{
    class Triangulo
    {
        public double A, B, C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p - A) * (p - B) * (p - C);
            return raiz;
        }
    }
}