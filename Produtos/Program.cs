using static System.Console;
using System;

namespace _02_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando classe
            Produto produto = new Produto();

            #region Coleta de dados do produto

            WriteLine("Entre com os produtos: ");
            Write("Nome: ");
            produto.Nome = ReadLine();

            Write("Preço: ");
            produto.Preco = double.Parse(ReadLine());

            Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(ReadLine());

            #endregion

            #region Chamada de metodos

            produto.ValorTotalEstoque();
            
            produto.AdicionarProdutos(produto.Quantidade);
            produto.ValorTotalEstoque();

            produto.RemoverProdutos(produto.Quantidade);
            produto.ValorTotalEstoque();

            #endregion

            ReadKey();
        }
    }
}
