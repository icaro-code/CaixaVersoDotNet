using Aula1.Domain.Notificacoes;
using Aula1.Domain;
using Aula1.Infra;

namespace Poo2RevisaoConsole
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Revisão POO (Console) ===");

            // Classes e objetos + construtor
            var cliente = new Cliente("Michael");
            var pedido = new Pedido(1001, cliente);

            // Métodos + sobrecarga (params)
            pedido.AdicionarItem("Mouse");
            pedido.AdicionarItem("Teclado", "Headset");
            pedido.ExibirResumo();

            // Herança + polimorfismo (lista do tipo base)
            List<Notificacao> notificacoes = new()
            {
                new NotificacaoEmail("michael@email.com"),
                new NotificacaoSms("+55 11 99999-0000")
            };

            foreach (var n in notificacoes)
            {
                n.Enviar($"Seu pedido #{pedido.Numero} foi criado!");
            }

            // Sobrecarga de método (tentativas)
            var email = new NotificacaoEmail("michael@email.com");
            email.Enviar("Confirmando envio com tentativas...", tentativas: 2);

            // Generics
            var loggerPedido = new Logger<Pedido>();
            loggerPedido.Info("Fluxo finalizado com sucesso.");

            // Encapsulamento: alteração via método, com validação
            cliente.AtualizarNome("Michael Tadeu");
            Console.WriteLine($"Cliente atualizado: {cliente.Nome} (Id: {cliente.Id})");

            Console.WriteLine("=== Fim ===");
        }
    }
}
