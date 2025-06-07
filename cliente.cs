using System;

public class Cliente : Iclientes
{
	public int Id { get; private set; }
	public string Nome { get; private set; }
	public string Email { get; private set; }
	public string CPF { get; private set; }

	public Cliente(int id, string nome, string email, string cpf)
	{
		if (id <= 0)
		{
			throw new ArgumentException("O ID do cliente deve ser um número positivo.", nameof(id));
        }

		if (string.IsNullOrWhiteSpace(nome))
		{
			throw new ArgumentException("O nome do cliente não pode ser vazio ou nulo.", nameof(nome));
        }

		if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) || !email.Contains("."))
		{
			throw new ArgumentException("O email do cliente deve ser válido.", nameof(email));
        }
		if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11) || !long.TryParse(cpf, out _))
		{
		throw new ArgumentException("O CPF do cliente deve conter 11 dígitos numéricos.", nameof(cpf));
		}

		Id = id;
		Nome = nome;
		Email = email;
		CPF = cpf;
	}

	public void AtualizarEmail(string novoEmail)
	{
		if (string.IsNullOrWhiteSpace(novoEmail) || !novoEmail.Contains("@") || !novoEmail.Contains("."))
		{
			throw new ArgumentException("O novo email deve ser válido.", nameof(novoEmail));
		}
		Email = novoEmail;
		Console.WriteLine($"Email do cliente '{Nome}' atualizado para {Email}.");
    }

	public void AtualizarCPF(string novoCPF)
	{
		if (string.IsNullOrWhiteSpace(novoCPF) || novoCPF.Length != 11 || !long.TryParse(novoCPF, out _))
		{
			throw new ArgumentException("O novo CPF deve conter 11 dígitos numéricos.", nameof(novoCPF));
		}
		CPF = novoCPF;
		Console.WriteLine($"CPF do cliente '{Nome}' atualizado para {CPF}.");
    }

	public void ExibirDetalhes()
	{
		Console.writeLine("--- Detalhes do Cliente ---");
		Console.WriteLine($"ID: {Id}");
		Console.WriteLine($"Nome: {Nome}");
		Console.WriteLine($"Email: {Email}");
		Console.WriteLine($"CPF: {CPF}");
		Console.WriteLine("---------------------------");
		Console.WriteLine($"Cliente '{Nome}' (ID: {Id}) cadastrado com sucesso!");
    }
}
