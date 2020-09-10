using static System.Console;
using System;

namespace _07_09
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            //Criacao do objeto
            Retangulo retangulo = new Retangulo();

            //Coleta de dados
            Write("Entre com a largura do retângulo: "); retangulo.largura = double.Parse(ReadLine());
            Write("Entre com a altura do retângulo: "); retangulo.altura = double.Parse(ReadLine());

            //Chamada de metodos
            retangulo.Area();
            retangulo.Perimetro();
            retangulo.Diagonal();

            Write("\r\nAperte qualquer tecla para sair..."); ReadKey();
        }
    }
}
