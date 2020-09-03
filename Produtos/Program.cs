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
            produto.nome = ReadLine();

            Write("Preço: ");
            produto.preco = double.Parse(ReadLine());

            Write("Quantidade em estoque: ");
            produto.quantidade = int.Parse(ReadLine());

            #endregion

            #region Chamada de metodos

            produto.ValorTotalEstoque();
            
            produto.AdicionarProdutos(produto.quantidade);
            produto.ValorTotalEstoque();

            produto.RemoverProdutos(produto.quantidade);
            produto.ValorTotalEstoque();

            #endregion

            ReadKey();
        }
    }
}
