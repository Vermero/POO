using static System.Console;
using System.Collections.Generic;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria a lista
            List<string> list = new List<string>();

            //Adiciona strings na lista
            list.Add("Julio"); list.Add("Henrique"); list.Add("Silva");

            //Le a lista
            WriteLine("LISTA 1: ");
            foreach (string obj in list)
            {
                WriteLine(obj);
            }

            WriteLine("-------------------------------");

            //Insere nova string na posição
            list.Insert(2, "Bermejos");

            //Le a lista
            WriteLine("LISTA 1: ");
            foreach (string obj in list)
            {
                //Escreve cada string da lista
                WriteLine(obj);                                
            }

            WriteLine("-------------------------------");

            //Mostra quantas strings tem na lista
            WriteLine("Quantidade de elementos na lista: " + list.Count);            

            //Encontra primeira string na lista que começa com a letra B
            string s1 = list.Find(x => x[0] == 'B'); WriteLine("Primeiro elemento que começa com a letra B: " + s1);

            //Encontra última string na lista que começa com a letra J
            string s2 = list.FindLast(x => x[0] == 'J'); WriteLine("Primeiro elemento que começa com a letra J: " + s2);

            #region ***NAO FUNCIONA***
            //Encontra primeiro char A
            int pos1 = list.FindIndex(x => x[0] == 'a'); WriteLine("Primeira Posição de A: " + pos1);

            //Encontra ultimo char I
            int pos2 = list.FindLastIndex(x => x[0] == 'i'); WriteLine("Última Posição de I: " + pos2);
            #endregion


            WriteLine("-------------------------------");

            //Cria nova lista com strings que tem 5 chars
            List<string> list2 = list.FindAll(x => x.Length == 5);

            //Le a lista
            WriteLine("LISTA 2: ");
            foreach (string objc in list2)
            {
                WriteLine(objc);
            }

            WriteLine("-------------------------------");

            //Remove a string da lista
            list.Remove("Silva");

            //Le a lista
            WriteLine("LISTA 1: ");
            foreach (string obj in list)
            {
                WriteLine(obj);
            }

            WriteLine("-------------------------------");

            //Remova char da string
            list.RemoveAll(x => x[0] == 'J');

            //Le a lista
            WriteLine("LISTA 1: ");
            foreach (string obj in list)
            {
                WriteLine(obj);
            }

            WriteLine("-------------------------------");

            //Remove char da posicao da string
            list.RemoveAt(1);

            //Le a lista
            WriteLine("LISTA 1: ");
            foreach (string obj in list)
            {
                WriteLine(obj);
            }

            WriteLine("-------------------------------");

            //Remove strins entre as posicoes
            list.RemoveRange(0, 1);

            //Le a lista
            WriteLine("LISTA 1: ");
            foreach (string obj in list)
            {
                WriteLine(obj);
            }

            Console.ReadKey();

        }
    }
}
