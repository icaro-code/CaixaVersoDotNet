using Abstracao;
using Abstracao.Domain;
using Abstracao.Domain.Tarifas;
using System.Data;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public static void Main(String[] args)
    {
        var pedido = new Pedido();

        decimal valor = 100m;

        decimal totalPremium = pedido.CalcularTotal(valor, new DescontoPremium());
        Console.WriteLine($"Total com desconto Premium: {totalPremium}");

        decimal totalComum = pedido.CalcularTotal(valor, new DescontoComum());
        Console.WriteLine($"Total com desconto Comum: {totalComum}");


        List<Forma> formas = new()
        {
            new Quadrado(5),
            new Circulo(3)
        };

        foreach (var forma in formas)
        {
            Console.WriteLine(forma.CalcularArea());
        }

        Console.WriteLine("=== Estacionamento ===");
        var caixa = new CaixaEstacionamento();

        // 1 Carro com 1h10m => 2hs
        var carro = new Veiculo("ABC-1234", TipoVeiculo.Carro);
        var ticketCarro = new Ticket(carro, new DateTime(2026, 02, 12, 21, 05, 00));
        ticketCarro.Finalizar(new DateTime(2026, 02, 12, 22, 15, 00));

        var valorCarro = caixa.FecharConta(ticketCarro, new TarifaCarro());
        Console.WriteLine($"Carro | Horas: {ticketCarro.DuracaoEmHoras()} | Total: R$ {valorCarro:0.00}");

        // 2 Moto com 2h05m => 3hs
        var moto = new Veiculo("DEF-1025", TipoVeiculo.Moto);
        var ticketMoto = new Ticket(moto, new DateTime(2026, 02, 12, 21, 05, 00));
        ticketMoto.Finalizar(new DateTime(2026, 02, 12, 23, 10, 00));

        var valorMoto = caixa.FecharConta(ticketMoto, new TarifaMoto());
        Console.WriteLine($"Moto | Horas: {ticketMoto.DuracaoEmHoras()} | Total: R$ {valorMoto:0.00}");

        // 3 Caminhonete com 3h00m => 3hs
        var caminhonete = new Veiculo("JAH-1025", TipoVeiculo.Caminhonete);
        var ticketCaminhonete = new Ticket(caminhonete, new DateTime(2026, 02, 12, 20, 05, 00));
        ticketCaminhonete.Finalizar(new DateTime(2026, 02, 12, 23, 05, 00));

        var valorCaminhonete = caixa.FecharConta(ticketCaminhonete, new TarifaCaminhonete());
        Console.WriteLine($"Caminhonete | Horas: {ticketCaminhonete.DuracaoEmHoras()} | Total: R$ {valorCaminhonete:0.00}");

        Console.WriteLine("=== Fim Estacionamento ===");
    }
}




////Sem o uso de Abstração
////public class Lampada
////{
////    public bool Estado;
////}

////Abstração básica
//using Abstracao;

//public class Lampada
//{
//    private bool _ligada;

//    public void Ligar()
//    {
//        _ligada = true;
//    }

//    public void Desligar()
//    {
//        _ligada = false;
//    }

//    public bool EstaLigada()
//    {
//        return _ligada;
//    }
//}

