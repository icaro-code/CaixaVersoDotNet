using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Domain
{
    public class Ticket
    {
        public Veiculo Veiculo { get; }
        public DateTime Entrada { get; }
        public DateTime? Saida { get; private set; }

        public Ticket(Veiculo veiculo, DateTime entrada)
        {
            Veiculo = veiculo ?? throw new ArgumentNullException(nameof(veiculo));
            Entrada = entrada;
        }

        public void Finalizar(DateTime saida)
        {
            if (saida < Entrada)
                throw new ArgumentException("Saída não pode ser menor que a entrada.");

            Saida = saida;
        }

        // Regra: arredondar pra cima (1h10m = 2 horas)
        public int DuracaoEmHoras()
        {
            if (Saida is null)
                throw new InvalidOperationException("Ticket ainda não foi finalizado.");

            var duracao = Saida.Value - Entrada;

            if (duracao.TotalMinutes <= 0)
                return 0;

            // Arredonda para cima
            return (int)Math.Ceiling(duracao.TotalHours);
        }
    }
}
