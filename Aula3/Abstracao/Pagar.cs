using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public abstract class PagamentoBase()
    {
        public void Processar(decimal valor)
        {
            ValidarValor(valor);
            Pagar(valor);
            Registrar(valor);
        }

        private void ValidarValor(decimal valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Valor inválido.");
            }
        }

        protected abstract void Pagar(decimal valor);

        private void Registrar(decimal valor)
        {
            Console.WriteLine("Pagamento registrado.");
        }
    }
}
