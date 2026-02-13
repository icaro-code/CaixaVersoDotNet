using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class NotificacaoService
    {
        private readonly INotificacao _notificacao;

        public NotificacaoService(INotificacao notificacao)
        {
            _notificacao = notificacao;
        }

        public void Enviar(string mensagem)
        {
            _notificacao.Enviar(mensagem);
        }
    }
}
