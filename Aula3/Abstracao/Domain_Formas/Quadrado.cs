using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Domain_Formas
{
    public class Quadrado : Forma
    {
        public double Lado { get; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
