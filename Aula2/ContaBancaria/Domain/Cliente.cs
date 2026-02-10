using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Domain
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Documento { get; private set; }

        public Cliente(string nome, string documento)
        {
            SetNome(nome);
            SetDocumento(documento);
        }

        public void AtualizarNome(string novoNome) => SetNome(novoNome);

        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Nome é obrigatório.");
            }

            Nome = nome.Trim();
        }

        private void SetDocumento(string documento)
        {
            if (string.IsNullOrWhiteSpace(documento))
            {
                throw new ArgumentException("Documento é obrigatório.");
            }

            Documento = documento.Trim();
        }
    }
}
