using System;

namespace provaPratica
{
    

        public produtos(string nome, double preco, int quantidade, int id)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
    public class clientes
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }

        public clientes(string nome, string Email, int cpf)
        {
            Nome = nome;
            this.Email = Email;
            CPF = cpf;
        }
    }
}