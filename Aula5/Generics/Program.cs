using Generics;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("=== Sem Generics ===");
        var caixaIntSemGenerics = new CaixaDeInteiros();
        caixaIntSemGenerics.Adicionar(42, 0);
        Console.WriteLine($"Posição 0: {caixaIntSemGenerics.Obter(0)}");

        var caixaStringSemGenerics = new CaixaDeStrings();
        caixaStringSemGenerics.Adicionar("Ricardo", 0);
        Console.WriteLine($"Posição 0: {caixaStringSemGenerics.Obter(0)}");
        Console.WriteLine("======");

        Console.WriteLine("=== Com Generics ===");
        //Caixa<int>
        var caixaInt = new Caixa<int>();
        caixaInt.Adicionar(10, 0);
        caixaInt.Adicionar(20, 1);
        Console.WriteLine($"Posição 0: {caixaInt.Obter(0)}");
        Console.WriteLine($"Posição 0: {caixaInt.Obter(1)}");

        //Caixa<string>
        var caixaString = new Caixa<string>();
        caixaString.Adicionar("Ricardo", 0);
        caixaString.Adicionar("Sandro", 1);
        Console.WriteLine($"Posição 0: {caixaString.Obter(0)}");
        Console.WriteLine($"Posição 0: {caixaString.Obter(1)}");

        //Caixa<DateTime>
        var caixaData = new Caixa<DateTime>();
        caixaData.Adicionar(new DateTime(2026,2,24), 0);
        Console.WriteLine($"Posição 0: {caixaData.Obter(0):dd/MM/yyyy}");

        //caixaInt.Adicionar("texto", 2);

        //return (int)obj;
        
        Console.WriteLine();
        Console.WriteLine("Fim");

        //Repository<Cliente> repo = new();
        //repo.Adicionar("João");
        //repo.Adicionar("joao@gmail.com");
        //repo.Adicionar(new Cliente());

        Repository<Cliente> repoCliente = new();
        repoCliente.Adicionar(new Cliente
        {
            Nome = "Michael",
            Email = "michael@gmail.com"
        });

        repoCliente.Adicionar(new Cliente
        {
            Nome = "Maria",
            Email = "maria@gmail.com"
        });

        Repository<Produto> repoProduto= new();
        repoProduto.Adicionar(new Produto
        {
            Nome = "Notebook",
            Preco = 4500m
        });

        repoProduto.Adicionar(new Produto
        {
            Nome = "Mouse",
            Preco = 120m
        });

        Console.WriteLine("\nCliente cadastrados:");
        foreach (var cliente in repo.ObterTodos())
        {
            Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Email}");
        }

        Console.WriteLine("\nCliente cadastrados:");
        foreach (var cliente in repoCliente.ObterTodos())
        {
            Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Email}");
        }

        Console.WriteLine("\nProdutos cadastrados:");
        foreach (var produto in repoProduto.ObterTodos())
        {
            Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Preco}");
        }


    }
}