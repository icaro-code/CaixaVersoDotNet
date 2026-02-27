using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoControle
{
    public class Pedido
    {
        private readonly decimal _valor;
        ////dependência concreta (acoplamento)
        //private PagamentoPix _pagamento;
        private readonly IPagamento _pagamento;

        //public Pedido(decimal valor)
        //{
        //    _valor = valor;
        //    // Sem IoC: a própria classe decide e cria a dependência
        //    _pagamento = new PagamentoPix();
        //}

        // COM IoC: a dependência vem de fora
        public Pedido(decimal valor, IPagamento pagamento)
        {
            _valor = valor;
            _pagamento = pagamento;
        }

        public void Finalizar()
        {
            Console.WriteLine($"Finalizando pedido no valor de {_valor:C}");
            _pagamento.Pagar(_valor);
        }
    }
}
