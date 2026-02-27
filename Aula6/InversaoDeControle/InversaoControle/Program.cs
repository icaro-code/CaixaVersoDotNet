using InversaoControle;

public class Program
{
    public static void Main(String[] args)
    {
        //Console.WriteLine("=== SEM IoC ===");
        //var pedido = new Pedido(150.00m);
        //pedido.Finalizar();
        //Console.WriteLine("=== SEM IoC ===");

        Console.WriteLine("=== COM IoC ===");
        IPagamento pagamento1 = new PagamentoPix();
        var pedido1 = new Pedido(150.00m, pagamento1);
        pedido1.Finalizar();

        IPagamento pagamento2 = new PagamentoCartao();
        var pedido2 = new Pedido(200.00m, pagamento2);
        pedido2.Finalizar();

        INotificacao notificacao1 = new EmailService();
        var notificador1 = new Notificador(notificacao1);
        notificador1.Notificar("Pedido Realizado");

        INotificacao notificacao2 = new SmsService();
        var notificador2 = new Notificador(notificacao2);
        notificador2.Notificar("Pagamento não realizado");

        // Criar conteiner
        var container = new Container();

        // Qual implementação usar na interface
        container.Register<INotificacao, EmailService>();
        //container.Register<INotificacao, SmsService>();

        // Container resolve a dependência - criar a instância
        var notificacao = container.Resolve<INotificacao>();

        // ID manual: injetar a dependência no Notificador
        var noticador = new Notificador(notificacao);

        // Executa
        noticador.Notificar("Pedido Criado");


    }
}
