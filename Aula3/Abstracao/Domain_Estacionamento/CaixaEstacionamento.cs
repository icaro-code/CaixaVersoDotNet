using Abstracao.Domain.Tarifas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Domain
{
    public class CaixaEstacionamento
    {
        public decimal FecharConta(Ticket ticket, TarifaBase tarifa)
        {
            if (ticket is null) throw new ArgumentNullException(nameof(ticket));
            if (tarifa is null) throw new ArgumentNullException(nameof(tarifa));

            var horas = ticket.DuracaoEmHoras();
            var valor = tarifa.Calcular(horas);

            return valor;
        }
    }
}
