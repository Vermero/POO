using static System.Console;
using System;
using System.Globalization;

namespace _02_09
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            double total = Preco * Quantidade;
            WriteLine("\r\nDados do produto:\r\n" + Nome + "\r\nR$" + Preco + "\r\n" + Quantidade + " unidades\r\n" + "total: R$" + total);
            return total;
        }

        public void AdicionarProdutos(int quantidade)
        {
            WriteLine("\r\nDigite o número a ser adicionado no estoque: ");
            quantidade = int.Parse(ReadLine());
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos (int quantidade)
        {
            WriteLine("\r\nDigite o número a ser removido do estoque: ");
            quantidade = int.Parse(ReadLine());
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + Quantidade
                + "unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
