using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Infra
{
    // Generics: reutilização + segurança de tipo (sem object/cast)
    public class Logger<T>
    {
        public void Info(string mensagem)
        {
            System.Console.WriteLine($"[LOG:{typeof(T).Name}] {mensagem}");
        }
    }
}
