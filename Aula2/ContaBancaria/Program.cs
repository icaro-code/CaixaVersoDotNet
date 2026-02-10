using ContaBancaria.Domain;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main()
        {
            // Classes e objetos + construtor
            var cliente = new Cliente("Fernando", "123.456.789-00");
            ContaBase cc = new ContaCorrente(numero: 1001, titular: cliente, limiteChequeEspecial: 200m, saldoInicial: 50m);
            ContaBase cp = new ContaPoupanca(numero: 2001, titular: cliente, saldoInicial: 50m);

            var contas = new List<ContaBase> { cc, cp };

            foreach (var conta in contas)
            {
                conta.ExibirResumo();
                conta.Depositar(100m);
                conta.Sacar(120m, "Pagamento de conta de luz.");
                conta.ExibirResumo();
                Console.WriteLine();
            }

            Console.WriteLine("Teste de limites:");
            cc.Sacar(200m, "Conta pode ficar até o limite");
            cc.ExibirResumo();

            try
            {
                cp.Sacar(200m, "Poupança não permite negativo");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falhou como esperado: {ex.Message}");
            }
        }
    }
}
