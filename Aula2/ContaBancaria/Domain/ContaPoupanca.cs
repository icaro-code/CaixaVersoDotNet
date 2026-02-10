using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Domain
{
    public class ContaPoupanca : ContaBase
    {
        public ContaPoupanca(int numero, Cliente titular, decimal saldoInicial = 0m) : base(numero, titular, saldoInicial)
        {
        }
    }
}
