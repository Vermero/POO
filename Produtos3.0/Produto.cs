using System;

public class Produto
{
	//Declaração de variavéis
	private string Nome;
	private double Preco{ get; set; }
	private int Quantidade{ get; set; }

	//Construtor personalizado		
	public Produto(string nome, double preco, int quantidade)
	{
		Nome = nome;
		Preco = preco;
		Quantidade = quantidade;
	}

	#region Utilização do GET e SET

	public string GetNome()
	{
		return Nome;
	}

	public void SetNome(string nome)
	{
		if (nome != null && nome.Length > 1)
		{
			Nome = nome;
		}
	}

	public double GetPreco() 
	{ 
		return Preco; 
	} 

	public void SetPreco(double preco)
    {
		Preco = preco;
    }

	public double GetQuantidade() 
	{ 
		return Quantidade;
	}

	public void SetQuantidade(int quantidade)
    {
		Quantidade = quantidade;
    }

	#endregion

	public double ValorTotalEmEstoque()
	{
		return Preco * Quantidade;
	}

	public void AdicionarProduto(int quantidade)
	{
		Quantidade += quantidade;
	}

	public void RemoverProdutos(int quantidade)
	{
		Quantidade -= quantidade;
	}

	public override string ToString()
	{
		return Nome
		+ ", R$ "
		+ Preco
		+ ", "
		+ Quantidade
		+ " unidades, Total: R$ "
		+ ValorTotalEmEstoque();
	}
}



