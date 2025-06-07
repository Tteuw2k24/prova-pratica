using System;


namespace provaPratica
{ 

    public interface Iclientes
    {
        int Id { get;  set; }
        string Nome { get; set; }
        string Email { get; set; }
        string CPF { get; set; }
    }
}