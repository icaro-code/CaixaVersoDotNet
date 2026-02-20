using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Domain.Tarifas
{
    public abstract class TarifaBase
    {
        public abstract decimal Calcular(int horas);
    }
}
