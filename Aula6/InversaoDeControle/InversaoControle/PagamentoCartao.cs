using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoControle
{
    public class PagamentoCartao : IPagamento
    {
        public void Pagar(decimal  valor)
        {
            Console.WriteLine($"Pagamento via Cartão aprovado no valor de: {valor:C}");
        }
    }
}
