using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Domain
{
    public class ContaCorrente : ContaBase
    {
        public decimal LimiteChequeEspecial { get; }

        public ContaCorrente(int numero, Cliente titular, decimal limiteChequeEspecial, decimal saldoInicial = 0m) : base(numero, titular, saldoInicial)
        {
            if (limiteChequeEspecial < 0) throw new ArgumentException("Limite inválido.");
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        protected override void ValidarSaque(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException("Saque deve ser > 0.");
            if (Saldo - valor <= -LimiteChequeEspecial) throw new InvalidOperationException("Limite do cheque especial excedido.");

            //LimiteChequeEspecial = 500;
            //menor saldo permitido = -500

            //Saldo = 100
            //valor = 700

            //Saldo - valor = 100 - 700 = -600 
            //-600 <= -500
        }
    }
}
