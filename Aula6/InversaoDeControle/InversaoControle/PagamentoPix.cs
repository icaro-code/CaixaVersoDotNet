namespace InversaoControle
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento via PIX realizado no valor de: {valor:C}");
        }
    }
}