using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class DescontoPremium : Desconto
    {
        public override decimal Aplicar(decimal valor)
        {
            return valor * 0.8m;
        }
    }
}
