using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public abstract class Desconto
    {
        public abstract decimal Aplicar(decimal valor);
    }
}
