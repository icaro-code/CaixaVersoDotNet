using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Domain
{
    public abstract class ContaBase
    {
        public int Numero { get; }
        public Cliente Titular { get; }
        public decimal Saldo { get; protected set; }

        protected ContaBase(int numero, Cliente titular, decimal saldoInicial = 0m)
        {
            if (numero <= 0) throw new ArgumentException("Número inválido.");
            Titular = titular ?? throw new ArgumentNullException(nameof(titular));
            if (saldoInicial < 0) throw new ArgumentException("Saldo inicial não pode ser negativo.");
            
            Numero = numero;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException("Depósito deve ser > 0.");
            Saldo += valor;
        }

        // Polimorfismo
        public void Sacar(decimal valor)
        {
            ValidarSaque(valor);
            Saldo -= valor;
        }

        // Sobrecarga
        public void Sacar(decimal valor, string descricao)
        {
            Sacar(valor);
            Console.WriteLine($"Saque realizado: R$ {valor:0.00} | {descricao}");
        }

        protected virtual void ValidarSaque(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException("Saque deve ser > 0.");
            if (Saldo - valor < 0) throw new ArgumentException("Saldo insuficiente.");
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Conta #{Numero} | Titular: {Titular.Nome} | Saldo: R$ {Saldo:0.00}");
        }
    }
}
