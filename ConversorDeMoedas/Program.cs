using static System.Console;
using System;

namespace ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();            
            
            WriteLine("Qual é a cotação do dólar?");
            conversor.cotacao = float.Parse(ReadLine());

            WriteLine("Quantos dólares você irá comprar?");
            conversor.dolares = float.Parse(ReadLine());

            conversor.Conta();


            
            
            
            ReadKey();
        }
    }
}
