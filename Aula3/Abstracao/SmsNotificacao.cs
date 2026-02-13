using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class SmsNotificacao : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine("Enviando por SMS");
        }
    }
}
