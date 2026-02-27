using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoControle
{
    public class EmailService : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Email enviado: {mensagem}");
        }
    }
}
