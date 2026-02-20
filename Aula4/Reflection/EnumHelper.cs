using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public static class EnumHelper
    {
        // var texto = EnumHelper.ObterDisplay(AnoEscolar.Setimo);
        public static string ObterDisplay(Enum valor)
        {
            var tipo = valor.GetType();
            var nome = Enum.GetName(tipo, valor);
            var campo = tipo.GetField(nome);

            var attr = (DisplayAttribute)Attribute.GetCustomAttribute(campo, typeof(DisplayAttribute));

            return attr?.Name ?? nome;
        }
    }
}
