using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public static class MethodExecutor
    {
        public static object Executar(object obj, string nomeMetodo, params object[] parametros)
        {
            //Executar(aluno, "Descrever")
            //Executar(aluno, "GerarMensagem", "Olá")
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (string.IsNullOrWhiteSpace(nomeMetodo)) throw new ArgumentException("Método Inválido");

            Type tipo = obj.GetType();

            MethodInfo metodo = tipo.GetMethod(nomeMetodo, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            if (metodo == null)
            {
                throw new InvalidOperationException($"Método '{nomeMetodo}' não encontrado no tipo {tipo.Name}.");
            }

            return metodo.Invoke(obj, parametros);
        }
    }
}
