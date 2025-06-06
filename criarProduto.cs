using System;

public class Produto : IProdutos
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    string categoria { get;  set; }

    public produto(int id, string nome, decimal preco, int quantidade, string categoria)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
        categoria = categoria;
    }
}
public class Cliente : Iclientes
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }

    public Cliente(string nome, string email, int cpf)
    {
        Nome = nome;
        Email = email;
        CPF = cpf;
    }
}
{

