using static System.Console;
using System;

namespace _02_09
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEstoque()
        {
            WriteLine(preco);
            WriteLine(quantidade);
            double total = preco * quantidade;
            WriteLine("\r\nDados do produto:\r\n" + nome + "\r\nR$" + preco + "\r\n" + quantidade + " unidades\r\n" + "total: R$" + total);
            return total;
        }

        public void AdicionarProdutos(int quantidade1)
        {
            WriteLine("\r\nDigite o número a ser adicionado no estoque: ");
            quantidade1 = int.Parse(ReadLine());
            quantidade = quantidade + quantidade1;
        }

        public void RemoverProdutos (int quantidade2)
        {
            WriteLine("\r\nDigite o número a ser removido do estoque: ");
            quantidade2 = int.Parse(ReadLine());
            quantidade = quantidade - quantidade2;
        }
    }

}
