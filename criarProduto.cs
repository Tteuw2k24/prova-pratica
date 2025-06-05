using System;

public class produto : IProduto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public produto(int id, string nome, decimal preco, int quantidade)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
}
public class cliente : Iclientes
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int CPF { get; set; }

    public cliente(string nome, string email, int cpf)
    {
        Nome = nome;
        Email = email;
        CPF = cpf;
    }
}
{

