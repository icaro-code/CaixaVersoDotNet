using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoControle
{
    public class Notificador
    {
        private readonly INotificacao _notificacao;

        public Notificador(INotificacao notificacao) 
        {
            _notificacao = notificacao;
        }

        public void Notificar(string mensagem)
        {
            //EmailService email = new EmailService();
            //email.Enviar(mensagem);
            _notificacao.Enviar(mensagem);
        }
    }
}
