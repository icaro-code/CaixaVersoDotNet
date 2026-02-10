using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Domain.Notificacoes
{
    public class NotificacaoEmail : Notificacao
    {
        public NotificacaoEmail(string destinatario) : base(destinatario) { }

        public override void Enviar(string mensagem)
        {
            System.Console.WriteLine($"[EMAIL] Para: {Destinatario} | Msg: {mensagem}");
        }
    }
}
