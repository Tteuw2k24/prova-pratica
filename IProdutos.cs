using System;

namespace provaPratica
{   
   public interface IProdutos
    {
        int Id { get; set; }
        string Nome { get; set; }
        decimal Preco { get; set; }
        int Quantidade { get; set; }
        string categoria { get; set; } 
    }
}