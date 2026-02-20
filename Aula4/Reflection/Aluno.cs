using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public AnoEscolar Ano { get; set; }
        private string Sexo { get; set; } = "F";

        public void Descrever()
        {
            Console.WriteLine($"Aluno: {Nome} - {EnumHelper.ObterDisplay(Ano)}");
        }

        public string GerarMensagem(string prefixo)
        {
            return $"{prefixo}: {Nome}";
        }
    }
}
