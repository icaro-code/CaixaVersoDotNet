using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Domain_Formas
{
    public class Circulo : Forma
    {
        public double Raio { get; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
