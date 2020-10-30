using static System.Console;
using System;

namespace Produtos3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS5", 6000.00, 10);

            WriteLine("Entre com os dados do produto.");
            Write("Nome: "); p.SetNome(ReadLine());
            Write("Preço: "); p.SetPreco(double.Parse(ReadLine()));
            Write("Quantidade: "); p.SetQuantidade(int.Parse(ReadLine()));            

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
