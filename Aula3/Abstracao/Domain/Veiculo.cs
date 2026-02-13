using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Domain
{
    public class Veiculo
    {
        public string Placa { get; private set; }
        public TipoVeiculo Tipo { get; }

        public Veiculo(string placa, TipoVeiculo tipo)
        {
            SetPlaca(placa);
            Tipo = tipo;
        }

        private void SetPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
                throw new ArgumentException("Placa é obrigatório.");

            Placa = placa.Trim().ToUpper();
        }
    }
}
