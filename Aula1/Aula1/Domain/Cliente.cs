using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Domain
{
    public class Cliente
    {
        private readonly Guid _id; // private: detalhe interno

        public Guid Id => _id; // propriedade somente leitura (encapsulamento)
        public string Nome { get; private set; } // set privado: protege o estado

        // Construtor: garante objeto válido ao nascer
        public Cliente(string nome)
        {
            _id = Guid.NewGuid();
            SetNome(nome);
        }

        // Sobrecarga de construtor
        public Cliente(Guid id, string nome)
        {
            _id = id;
            SetNome(nome);
        }

        // Método público: única forma de alterar o nome com regras
        public void AtualizarNome(string novoNome) => SetNome(novoNome);

        // Método privado: regra interna (caixa preta)
        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome não pode ser vazio.");

            var n = nome.Trim();

            if (n.Length < 3)
                throw new ArgumentException("Nome deve ter pelo menos 3 caracteres.");

            // exemplo simples de validação: não permitir números
            foreach (var c in n)
                if (char.IsDigit(c))
                    throw new ArgumentException("Nome não pode conter números.");

            Nome = n;
        }
    }
}
