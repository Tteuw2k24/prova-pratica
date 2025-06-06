using System;

public class Produto : IProdutos
{
	public int Id { get; private set; }
	public string Nome { get; private set; }
	public decimal Preco { get; private set; }
	public int Quantidade { get; private set; }
	public string Categoria { get; private set; } 

	public Produto(int id, string nome, decimal preco, int quantidade, string categoria)
	{
		Id = id;
		Nome = nome;
		Preco = preco;
		Quantidade = quantidade;
		Categoria = categoria;
	}
}
{
	
}
