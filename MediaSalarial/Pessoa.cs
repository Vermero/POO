using static System.Console;
using System;

namespace Exercicio1
{
    public class Pessoa
    {
        //Variaveis da classe
        public string nome1, nome2;
        public int idade1, idade2;
        public double salario1, salario2, media;        

        public double Media()
        {
            media = (salario1 + salario2) / 2.0;
            WriteLine("\r\nA média salarial dos dois é de: " + media + " reais.");
            return media;
        }
        
        public void MaisVelha()
        {
            if (idade1 > idade2)
            {
                WriteLine("\r\nA pessoa mais velha é o(a): " + nome1 + ".");
            }
            else
            {
                WriteLine("\r\nA pessoa mais velha é o(a): " + nome2 + ".");
            }
        }
    }
}
