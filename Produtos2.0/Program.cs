using static System.Console;
using System;

namespace Produtos2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Entre com os dados do produto.");
            Write("Nome: "); string nome = ReadLine();
            Write("Preço: ");  double preco = double.Parse(ReadLine());
            Write("Quantidade: "); int quantidade = int.Parse(ReadLine());

            Produto p = new Produto(nome, preco, quantidade);            

            WriteLine("\nDados do produto:\n" + p);

            Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int qnt = int.Parse(ReadLine());
            p.AdicionarProduto(qnt);

            WriteLine("\nDados atualizados:\n" + p);

            Write("\nDigite o número de produtos a serem removidos do estoque: ");
            qnt = int.Parse(ReadLine());
            p.RemoverProdutos(qnt);

            WriteLine("\nDados atualizados:\n" + p);



            ReadKey();
        }
    }
}
