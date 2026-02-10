using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Domain.Notificacoes
{
    public class NotificacaoSms : Notificacao
    {
        public NotificacaoSms(string destinatario) : base(destinatario) { }

        public override void Enviar(string mensagem)
        {
            System.Console.WriteLine($"[SMS] Para: {Destinatario} | Msg: {mensagem}");
        }
    }
}
