using static System.Console;
using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria array e variaveis
            string[] rooms = new string[10];
            string Nome;
            string Email;
            int Quarto;
            int x = 1;

            //Coleta numero de quartos
            WriteLine("Quantos quartos serão alugados?"); int N = int.Parse(ReadLine());
            
            //Passa por array
            for (int i = 0; i < N; i++)
            {
                //Coleta e insere dados no array
                Write("\nHóspede #" + x + "\nNome: "); Nome = ReadLine();
                Write("Email: "); Email = ReadLine();
                Write("Quarto: "); Quarto = int.Parse(ReadLine());

                rooms[Quarto-1] = Nome + ", " + Email;

                x++;
            }

            //Mostra quartos e seus hospedes
            Write("\nQUARTOS OCUPADOS\n");
            int count = 0;
            
            foreach(string room in rooms)
            {
                count++;
                WriteLine($"{count}: {room}");
            }


            ReadKey();           
        }
    }
}
