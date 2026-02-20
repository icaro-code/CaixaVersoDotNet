using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Domain.Tarifas
{
    public class TarifaCarro : TarifaBase
    {
        public override decimal Calcular(int horas)
        {
            if (horas < 0) throw new ArgumentException("Horas inválidas.");
            return horas * 10m;
        }
    }
}
