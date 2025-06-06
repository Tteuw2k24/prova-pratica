using System;

public class Clisente : Iclientes
{
	public int Id { get; private set; }
	public string Nome { get; private set; }
	public string Email { get; private set; }
	public string CPF { get; private set; }

	public Clisente(int id, string nome, string email, string cpf)
	{
		Id = id;
		Nome = nome;
		Email = email;
		CPF = cpf;
	}
}
{
	
}
