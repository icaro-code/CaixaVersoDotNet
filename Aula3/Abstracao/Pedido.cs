using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Pedido
    {
        public decimal CalcularTotal(decimal valor, Desconto desconto)
        {
           return desconto.Aplicar(valor);
        }
    }
}
