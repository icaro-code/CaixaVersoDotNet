using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Domain.Notificacoes
{
    // Classe base abstrata (herança) + define contrato comum
    public abstract class Notificacao
    {
        protected DateTime CriadaEm { get; } = DateTime.Now; // protected: filhas acessam
        public string Destinatario { get; } // contrato público

        protected Notificacao(string destinatario)
        {
            if (string.IsNullOrWhiteSpace(destinatario))
                throw new ArgumentException("Destinatário obrigatório.");

            Destinatario = destinatario.Trim();
        }

        // Polimorfismo: filhas sobrescrevem
        public virtual void Enviar(string mensagem)
        {
            Console.WriteLine($"[BASE] Para {Destinatario} às {CriadaEm}: {mensagem}");
        }

        // Sobrecarga: mesma intenção, assinatura diferente
        public void Enviar(string mensagem, int tentativas)
        {
            for (int i = 1; i <= tentativas; i++)
            {
                Console.WriteLine($"Tentativa {i}/{tentativas}...");
                Enviar(mensagem); // chama override da filha, se existir
            }
        }
    }
}
