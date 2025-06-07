
using System;

namespace provaPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o sistema de gestão de pedidos...\n");

            
            Console.WriteLine("--- Cadastro de Produtos ---");
            try
            {
                Produto notebook = new Produto(1, "Notebook Gamer X", 7500.00m, 10, "Eletrônicos");
                notebook.ExibirDetalhes();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar produto: {ex.Message}");
            }

            try
            {
                Produto teclado = new Produto(2, "Teclado Mecânico", 500.00m, 25, "Periféricos");
                teclado.ExibirDetalhes();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar produto: {ex.Message}");
            }

            
            Console.WriteLine("\n--- Testando Criação de Produtos Inválidos ---");
            try
            {
                Produto produtoInvalidoID = new Produto(0, "Caneta", 5.00m, 100, "Papelaria");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ERRO ESPERADO (ID Inválido): {ex.Message}");
            }

            try
            {
                Produto produtoInvalidoNome = new Produto(3, "", 20.00m, 50, "Livros");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ERRO ESPERADO (Nome Vazio): {ex.Message}");
            }

            try
            {
                Produto produtoInvalidoPreco = new Produto(4, "Mouse", -10.00m, 30, "Periféricos");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ERRO ESPERADO (Preço Negativo): {ex.Message}");
            }

            try
            {
                Produto produtoInvalidoCategoria = new Produto(5, "Monitor", 1500.00m, 15, "");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ERRO ESPERADO (Categoria Vazia): {ex.Message}");
            }

            
            Console.WriteLine("\n--- Cadastro de Clientes ---");
            try
            {
                Cliente cliente1 = new Cliente(101, "João Silva", "joao.silva@email.com", "12345678901");
                cliente1.ExibirInformacoes();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar cliente: {ex.Message}");
            }

            
            Console.WriteLine("\n--- Testando Criação de Clientes Inválidos ---");
            try
            {
                Cliente clienteInvalidoCPF = new Cliente(102, "Maria", "maria@email.com", "123"); // CPF curto
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ERRO ESPERADO (CPF Inválido): {ex.Message}");
            }

            try
            {
                Cliente clienteInvalidoEmail = new Cliente(103, "Pedro", "pedro.com", "11122233344"); // Email inválido
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ERRO ESPERADO (Email Inválido): {ex.Message}");
            }

            Console.WriteLine("\nTestes iniciais de classes e validações concluídos.");
        }
    }
}