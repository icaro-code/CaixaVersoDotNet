using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class DescontoComum : Desconto
    {
        public override decimal Aplicar(decimal valor)
        {
            return valor * 0.95m;
        }
    }
}
