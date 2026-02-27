using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoControle
{
    public class SmsService : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"SMS enviado: {mensagem}");
        }

    }
}
