using Reflection;
using System.Reflection;

public class Program
{
    public static void Main(String[] args)
    {
        //Reflection = inspeção em runtime
        //1 - Inspecionar: propriedades, métodos, atributos...
        //2 - Instanciar: Criar objeto só conhecendo o tipo em runtime.
        //3 - Alterar: Mudar valores de propriedades/ campos dinamicamente.
        //4 - Invocar: Executar métodos dinamicamente.

        //var aluno = new Aluno { Nome = "Maria", Idade = 15 };
        //Console.WriteLine($"Tipo: {aluno.GetType().Name}");

        //PropertyInfo[] props = aluno.GetType().GetProperties();
        //foreach (var p in props)
        //{
        //    Console.WriteLine($"{p.Name} ({p.PropertyType.Name}) = {p.GetValue(aluno)}");
        //}

        //var props1 = aluno.GetType().GetProperties(
        //    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        //foreach (var p in props1)
        //{
        //    Console.WriteLine($"{p.Name} ({p.PropertyType.Name}) = {p.GetValue(aluno)}");
        //}

        //var tipo = typeof(Produto);

        //object obj = Activator.CreateInstance(tipo);
        ////Produto obj = new Produto();

        //foreach (var prop in tipo.GetProperties())
        //{
        //    if (prop.Name == "Nome")
        //    {
        //        prop.SetValue(obj, "Mouse");
        //        //obj.Nome = "Mouse";
        //        //((Produto)obj).Nome = "Mouse";
        //    }

        //    if (prop.Name == "Preco")
        //    {
        //        prop.SetValue(obj, 79.99m);
        //        //obj.Preco = 79.99m;
        //        //((Produto)obj).Preco = 79.99m;
        //    }
        //}

        //Console.WriteLine($"Criado: {((Produto)obj).Nome} - {((Produto)obj).Preco}");

        var aluno = new Aluno { Nome = "Ricardo", Ano = AnoEscolar.Setimo };

        MethodExecutor.Executar(aluno, "Descrever");

        var retorno = MethodExecutor.Executar(aluno, "GerarMensagem", "Olá");

        Console.WriteLine($"Retorno: {retorno}");


    }
}