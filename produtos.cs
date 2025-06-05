using System;

namespace provaPratica
{
   public interface IProduto
    {
        public int Id { get; set }
        public string Nome { get; set }
        public decimal Preco { get; set }
        public int Quantidade { get; set}
    }
}