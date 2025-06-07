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
			if (id <= 0)
			{
			throw new ArgumentException("O ID do produto deve ser um número positivo.", nameof(id));
			}
				if (string.IsNullOrWhiteSpace(nome))
				{
					throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.", nameof(nome));
				}
			if (preco < 0)
			{
			throw new ArgumentException("O preço do produto deve ser maior que zero.", nameof(preco));
			}
				if (quantidade < 0)
				{
				throw new ArgumentException("A quantidade em estoque não pode ser negativa.", nameof(quantidade));
				}
			if (string.IsNullOrWhiteSpace(categoria))
			{
			throw new ArgumentException("A categoria do produto não pode ser vazia ou nula.", nameof(categoria));	
			}

			Id = id;
			Nome = nome;
			Preco = preco;
			Quantidade = quantidade;
			Categoria = categoria;
			console.WriteLine($"Produto '{Nome}' (ID: {Id}) da categoria '{Categoria}' criado com sucesso!");
	}
	public void AtualizarPreco (decimal novoPreco)
	{
		if (novoPreco <= 0)
		{
			throw new ArgumentException("O novo preço deve ser maior que zero.", nameof(novoPreco));
        }
		Preco = novoPrecoPreco;
		console.WriteLine($"Preço do produto '{Nome}' atualizado para {Preco:C}.");
    }

	public void AdicionarEstoque(int quantidadeAdicional)
	{
		if (quantidadeAdicional <= 0)
		{
			throw new AargumentException("A quantidade adicional deve ser maior que zero.", nameof(quantidadeAdicional));
        }
		Quantidade += quantidadeAdicional;	
		console.WriteLine($"Quantidade do produto '{Nome}' aumentada em {quantidadeAdicional}. Estoque atual: {Quantidade} unidades.");
    }

	public void RemoverEstoque(int quantidadeRemovida)
	{
		if (quantidadeRemovida <= 0)
		{
			throw new ArgumentException("A quantidade removida deve ser maior que zero.", nameof(quantidadeRemovida));
		}
		if (quantidadeRemovida > Quantidade)
		{
			throw new InvalidOperationException("Não há estoque suficiente para remover essa quantidade.");
		}
		Quantidade -= quantidadeRemovida;
		console.WriteLine($"Quantidade do produto '{Nome}' reduzida em {quantidadeRemovida}. Estoque atual: {Quantidade} unidades.");

    }
	public void ExibirDetalhes()
	{
		console.writeLine($"--- Detalhes do Produto ---");
        Console.WriteLine($"ID: {Id}");
		Console.WriteLine($"Nome: {Nome}");
		Console.WriteLine($"Preço: {Preco:C}");
		Console.WriteLine($"Quantidade em estoque: {Quantidade}");
		Console.WriteLine($"Categoria: {Categoria}");
		console.wirteline($"---------------------------");
    }
